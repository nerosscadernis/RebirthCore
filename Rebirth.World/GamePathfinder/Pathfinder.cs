using Rebirth.Common.GameData;
using Rebirth.World.Datas.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaknaCore.Debug.Utilities.Pathfinder.GamePathfinder
{
    public class Pathfinder
    {

        #region Declarations

        private bool useDiagonals;
        private bool find = false;   

        private Cell destinationCell, startCell;
        private MapTemplate currentMap;

        private CellMatrix matrix = new CellMatrix();
        private CellList openList = new CellList();
        private List<CellWithOrientation> m_cells;

        private const short MapWidth = 20;
        private const short MapHeight = 14;

        public int LoadedMapId
        {
            get
            {
                if (currentMap != null)
                    return currentMap.Id;
                return 0;
            }
        }
        public List<CellWithOrientation> Cells
        {
            get
            {
                return m_cells;
            }
            set
            {
                m_cells = value;
            }
        }
        #endregion

        #region Constructeurs

        public Pathfinder()
        {

        }

        #endregion

        #region Public method

        public void SetMap(MapTemplate map, bool useDiagonal)
        {
            currentMap = map;
            useDiagonals = useDiagonal;
            matrix.Clear();
            openList.Clear();
            find = false;
            CellMap cell;
            int id = 0;
            int loc1 = 0;
            int loc2 = 0;
            int loc3 = 0;
            for (int line = 0; line < 20; line++)
            {
                for (int column = 0; column < 14; column++)
                {
                    cell = currentMap.Cells[id];
                    bool Mov = currentMap.Cells[id].Mov;

                    //if (map.IsEntityOnCell((short)id))
                    //{
                    //    Mov = false;
                    //}
                    matrix.Add(id, new Cell(cell.MapChangeData != 0, Mov, true, column, loc3, id, new Point(loc1 + column, loc2 + column)));
                    id++;
                }
                loc1++;
                loc3++;
                for (int column = 0; column < 14; column++)
                {
                    cell = currentMap.Cells[id];
                    bool Mov = currentMap.Cells[id].Mov;
                    //unsafe { Mov = currentMap.Data.Cells[id].Mov; }
                    //if (map.IsEntityOnCell((short)id))
                    //{
                    //    Mov = false;
                    //}
                    matrix.Add(id, new Cell(cell.MapChangeData != 0, Mov, true, column, loc3, id, new Point(loc1 + column, loc2 + column)));
                    id++;
                }
                loc3++;
                loc2--;
            }
        }

        //public void SetMapInFight(MapTemplate map, Fight data)
        //{
        //    currentMap = map;
        //    useDiagonals = false;
        //    matrix.Clear();
        //    openList.Clear();
        //    find = false;
        //    CellMap cell;
        //    int id = 0;
        //    int loc1 = 0;
        //    int loc2 = 0;
        //    int loc3 = 0;
        //    for (int line = 0; line < 20; line++)
        //    {
        //        for (int column = 0; column < 14; column++)
        //        {
        //            cell = currentMap.Cells[id];
        //            bool Mov =  currentMap.Cells[id].Mov;
        //            if (!data.IsCellFree(cell))
        //            {
        //                Mov = false;
        //            }
        //            matrix.Add(id, new Cell(cell.MapChangeData != 0, Mov, true, column, loc3, id, new Point(loc1 + column, loc2 + column)));
        //            id++;
        //        }
        //        loc1++;
        //        loc3++;
        //        for (int column = 0; column < 14; column++)
        //        {
        //            cell = currentMap.Cells[id];
        //            bool Mov = currentMap.Cells[id].Mov;
        //            if (!data.IsCellFree(cell))
        //            {
        //                Mov = false;
        //            }
        //            matrix.Add(id, new Cell(cell.MapChangeData != 0, Mov, true, column, loc3, id, new Point(loc1 + column, loc2 + column)));
        //            id++;
        //        }
        //        loc3++;
        //        loc2--;
        //    }
        //}

 
        public void GetPath(short startCellId, short destinationCellId)
        {
            Find(startCellId, destinationCellId);
        }
        public void CutPath(int index)
        {
             CellWithOrientation[] newCells = new AmaknaCore.Debug.Utilities.Pathfinder.GamePathfinder.CellWithOrientation[index];
            if (index <= m_cells.Count())
            {
                Array.Copy(m_cells.ToArray(), newCells, index);
            }
            m_cells =  newCells.ToList();
        }
        #endregion

        #region Private method

        private void Find(short startCellId, short destinationCellId)
        {
            startCell = matrix[(int)startCellId];
            destinationCell = matrix[(int)destinationCellId];

            matrix[startCellId].Start = true;
            matrix[startCellId].InClosedList = true;

            matrix[destinationCellId].End = true;
            destinationCell = matrix[destinationCellId];
            foreach (Cell cell in matrix.Values)
            {
                cell.SetH(matrix[destinationCellId]);
            }

            Cell currentCell = matrix[startCellId];

            int startTime = Environment.TickCount;

            while (!find)
            {
                FindAvalableCell(currentCell);

                if (!find)
                {
                    if (openList.Count == 0)
                        return;

                    currentCell = openList[0];
                    currentCell.InClosedList = true;
                    currentCell.InOpenList = false;
                    openList.RemoveAt(0);
                }

                if((Environment.TickCount - startTime) > 500)
                {
                    return;
                }
            }

            List<CellWithOrientation> cells = new List<CellWithOrientation>();
            currentCell = matrix[destinationCellId];

            while (currentCell.Parent != null)
            {
                cells.Insert(0, new CellWithOrientation(currentCell.Id, currentCell.Location.x, currentCell.Location.y));
                currentCell = currentCell.Parent;

                if(cells.Count > 100)
                {
                    return;
                }
            }
            cells.Insert(0, new CellWithOrientation(startCellId, matrix[startCellId].Location.x, matrix[startCellId].Location.y));
            m_cells = cells;
        }

        private void FindAvalableCell(Cell cell)
        {
            Cell avalableCell;

            #region Haut-Droite
            if (cell.Position[0] == 0 && cell.Position[6] == 0)
            {
                avalableCell = cell.Pair ? matrix[cell.Id - 14] : matrix[cell.Id - 13];
                if (avalableCell.End)
                {
                    avalableCell.Parent = cell;
                    find = true;
                    return;
                }

                if (avalableCell.Walkable)
                {
                    if (!avalableCell.InOpenList && !avalableCell.InClosedList)
                    {
                        avalableCell.Parent = cell;
                        avalableCell.InOpenList = true;
                        openList.Add(avalableCell);
                        FixeCell(avalableCell, cell);
                    }
                }
            }
            #endregion

            #region Bas-Droite
            if (cell.Position[2] == 0 && cell.Position[6] == 0)
            {
                avalableCell = cell.Pair ? matrix[cell.Id + 14] : matrix[cell.Id + 15];
                if (avalableCell.End)
                {
                    avalableCell.Parent = cell;
                    find = true;
                    return;
                }

                if (avalableCell.Walkable)
                {
                    if (!avalableCell.InOpenList && !avalableCell.InClosedList)
                    {
                        avalableCell.Parent = cell;
                        avalableCell.InOpenList = true;
                        openList.Add(avalableCell);
                        FixeCell(avalableCell, cell);
                    }
                }
            }
            #endregion

            #region Haut-Gauche
            if (cell.Position[0] == 0 && cell.Position[4] == 0)
            {
                avalableCell = cell.Pair ? matrix[cell.Id - 15] : matrix[cell.Id - 14];
                if (avalableCell.End)
                {
                    avalableCell.Parent = cell;
                    find = true;
                    return;
                }

                if (avalableCell.Walkable)
                {
                    if (!avalableCell.InOpenList && !avalableCell.InClosedList)
                    {
                        avalableCell.Parent = cell;
                        avalableCell.InOpenList = true;
                        openList.Add(avalableCell);
                        FixeCell(avalableCell, cell);
                    }
                }
            }
            #endregion

            #region Bas-Gauche
            if (cell.Position[2] == 0 && cell.Position[4] == 0)
            {
                avalableCell = cell.Pair ? matrix[cell.Id + 13] : matrix[cell.Id + 14];
                if (avalableCell.End)
                {
                    avalableCell.Parent = cell;
                    find = true;
                    return;
                }

                if (avalableCell.Walkable)
                {
                    if (!avalableCell.InOpenList && !avalableCell.InClosedList)
                    {
                        avalableCell.Parent = cell;
                        avalableCell.InOpenList = true;
                        openList.Add(avalableCell);
                        FixeCell(avalableCell, cell);
                    }
                }
            }
            #endregion

            #region Droite
            if (cell.Position[6] == 0 && cell.Position[7] == 0 && useDiagonals)
            {
                avalableCell = matrix[cell.Id + 1];
                if (avalableCell.End)
                {
                    avalableCell.Parent = cell;
                    find = true;
                    return;
                }

                if (avalableCell.Walkable)
                {
                    if (!avalableCell.InOpenList && !avalableCell.InClosedList)
                    {
                        avalableCell.Parent = cell;
                        avalableCell.InOpenList = true;
                        openList.Add(avalableCell);
                        FixeCell(avalableCell, cell);
                    }
                }
            }
            #endregion

            #region Gauche
            if (cell.Position[4] == 0 && cell.Position[5] == 0 && useDiagonals)
            {
                avalableCell = matrix[cell.Id - 1];
                if (avalableCell.End)
                {
                    avalableCell.Parent = cell;
                    find = true;
                    return;
                }

                if (avalableCell.Walkable)
                {
                    if (!avalableCell.InOpenList && !avalableCell.InClosedList)
                    {
                        avalableCell.Parent = cell;
                        avalableCell.InOpenList = true;
                        openList.Add(avalableCell);
                        FixeCell(avalableCell, cell);
                    }
                }
            }
            #endregion

            #region Haut
            if (cell.Position[0] == 0 && cell.Position[1] == 0 && useDiagonals)
            {
                avalableCell = matrix[cell.Id - 28];
                if (avalableCell.End)
                {
                    avalableCell.Parent = cell;
                    find = true;
                    return;
                }

                if (avalableCell.Walkable)
                {
                    if (!avalableCell.InOpenList && !avalableCell.InClosedList)
                    {
                        avalableCell.Parent = cell;
                        avalableCell.InOpenList = true;
                        openList.Add(avalableCell);
                        FixeCell(avalableCell, cell);
                    }
                }
            }
            #endregion

            #region Bas
            if (cell.Position[2] == 0 && cell.Position[3] == 0 && useDiagonals)
            {
                avalableCell = matrix[cell.Id + 28];
                if (avalableCell.End)
                {
                    avalableCell.Parent = cell;
                    find = true;
                    return;
                }

                if (avalableCell.Walkable)
                {
                    if (!avalableCell.InOpenList && !avalableCell.InClosedList)
                    {
                        avalableCell.Parent = cell;
                        avalableCell.InOpenList = true;
                        openList.Add(avalableCell);
                        FixeCell(avalableCell, cell);
                    }
                }
            }
            #endregion

            SortOpenList();
        }

        private void SortOpenList()
        {
            bool ok = false;
            while (!ok)
            {
                ok = true;
                Cell temp;
                for (int i = 0; i < openList.Count - 1; i++)
                {
                    if (openList[i].F > openList[i + 1].F && PathingUtils.DistanceToPoint(openList[i].Location, destinationCell.Location) < PathingUtils.DistanceToPoint(openList[i + 1].Location, destinationCell.Location))
                    {
                        temp = openList[i];
                        openList[i] = openList[i + 1];
                        openList[i + 1] = temp;
                        ok = false;
                    }
                }
            }
        }

        private void FixeCell(Cell cellInspected, Cell currentCell)
        {
            double MovementCost = GetFixedMouvementCost(cellInspected, currentCell);
            cellInspected.G = (uint)MovementCost;
            cellInspected.H = (uint)GetFixedHeuristic(cellInspected, currentCell);
            cellInspected.F = cellInspected.G + cellInspected.H;
        }

        private double GetFixedMouvementCost(Cell cellInspected, Cell currentCell)
        {
            double poid = PointWeight(cellInspected.Location);
            return cellInspected.G + (cellInspected.Location.y == currentCell.Location.y || cellInspected.Location.x == currentCell.Location.x ? 10 : 15) * poid;
        }

        private double GetFixedHeuristic(Cell cellInspected, Cell currentCell)
        {
            bool _loc8_ = cellInspected.Location.x + cellInspected.Location.y == destinationCell.Location.x + destinationCell.Location.y;
            bool _loc9_ = cellInspected.Location.x + cellInspected.Location.y == startCell.Location.x + startCell.Location.y;
            bool _loc10_ = cellInspected.Location.x - cellInspected.Location.y == destinationCell.Location.x - destinationCell.Location.y;
            bool _loc11_ = cellInspected.Location.x - cellInspected.Location.y == startCell.Location.x - startCell.Location.y;

            double Heuristic = 10 * Math.Sqrt((destinationCell.Location.x - cellInspected.Location.x) * (destinationCell.Location.y - cellInspected.Location.y) + (destinationCell.Location.x - cellInspected.Location.x) * (destinationCell.Location.x - cellInspected.Location.x));

            if (cellInspected.Location.x == destinationCell.Location.x || cellInspected.Location.y == destinationCell.Location.y)
            {
                Heuristic = Heuristic - 3;
            }
            if ((_loc8_) || (_loc10_) || cellInspected.Location.x + cellInspected.Location.y == currentCell.Location.x + currentCell.Location.y || cellInspected.Location.x - cellInspected.Location.y == currentCell.Location.x - currentCell.Location.y)
            {
                Heuristic = Heuristic - 2;
            }
            if (cellInspected.Location.x == startCell.Location.x || cellInspected.Location.y == startCell.Location.y)
            {
                Heuristic = Heuristic - 3;
            }
            if ((_loc9_) || (_loc11_))
            {
                Heuristic = Heuristic - 2;
            }
 
            return Heuristic;
        }

        private double PointWeight(Point point)
        {
            double result = 1;
            int cellId = PathingUtils.CoordToCellId(point.x, point.y);
            int speed = currentMap.Cells[cellId].Speed;
            if (speed >= 0)
            {
                result = result + (5 - speed);
            }
            else
            {
                result = result + (11 + Math.Abs(speed));
            }
            return result;
        }

        #endregion

        public short[] GetCompressedPath()
        {
            List<CellWithOrientation> path = m_cells;
            List<short> compressedPath = new List<short>();
            if (path.Count < 2)
            {

                foreach (CellWithOrientation node in path)
                {
                    node.GetCompressedValue();
                    compressedPath.Add(node.CompressedValue);
                }
            }
            else
            {
                for (int i = 0; i < path.Count - 1; i++)
                {
                    path[i].SetOrientation(path[i + 1]);
                }

                path[path.Count - 1].SetOrientation(path[path.Count - 2].Orientation);
                foreach (CellWithOrientation cell in path)
                {
                    cell.GetCompressedValue();
                }
                compressedPath.Add(path[0].CompressedValue);
                for (int i = 1; i < path.Count - 1; i++)
                {
                    if (path[i].Orientation != path[i - 1].Orientation)
                        compressedPath.Add(path[i].CompressedValue);
                }
                compressedPath.Add(path[path.Count - 1].CompressedValue);
            }
            return compressedPath.ToArray();
        }




    }
}
