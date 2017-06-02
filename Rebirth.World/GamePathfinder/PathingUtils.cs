using Rebirth.Common.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaknaCore.Debug.Utilities.Pathfinder.GamePathfinder
{
    public static class PathingUtils
    {
        #region Declarations

        private const int MapHeight = 20;
        private const int MapWidth = 14;
        private const int MapCellsCount = 560;
        private static Point[] cellsPositions = new Point[MapCellsCount];

        #endregion

        #region PublicMethod

        static PathingUtils()
        {
            int _loc_1, _loc_2, _loc_3, _loc_4, _loc_5;
            _loc_1 = _loc_2 = _loc_3 = _loc_4 = _loc_5 = 0;

            while (_loc_5 < MapHeight)
            {
                _loc_4 = 0;
                while (_loc_4 < MapWidth)
                {
                    cellsPositions[_loc_3] = new Point(_loc_1 + _loc_4, _loc_2 + _loc_4);
                    _loc_3++;
                    _loc_4++;
                }
                _loc_1++;
                _loc_4 = 0;
                while (_loc_4 < MapWidth)
                {
                    cellsPositions[_loc_3] = new Point(_loc_1 + _loc_4, _loc_2 + _loc_4);
                    _loc_3++;
                    _loc_4++;
                }
                _loc_2 = _loc_2 - 1;
                _loc_5++;
            }
        }

        public static short CoordToCellId(int cellX, int cellY)
        {
            return (short)((cellX - cellY) * MapWidth + cellY + (cellX - cellY) / 2);
        }

        public static bool IsCellInMap(int CellId)
        {
            return (CellId > 0 && CellId < MapCellsCount);
        }

        public static bool IsCellInMap(int X, int Y)
        {
            return (cellsPositions.Contains(new Point(X, Y)));
        }

        public static short CoordToCellId(Point cellPosition)
        {
            return CoordToCellId(cellPosition.x, cellPosition.y);
        }

        public static Point CellIdToCoord(short cellId)
        {
            if (cellId < 0 || cellId >= cellsPositions.Count())
                throw new ArgumentOutOfRangeException("Invalid cell id");
            return cellsPositions[cellId];
        }

   
        public static uint DistanceToPoint(Point point1, Point point2)
        {
            return (uint)Math.Sqrt((point1.x - point2.x) * (point1.x - point2.x) + (point1.y - point2.y) * (point1.y - point2.y));
        }

        #endregion
    }
}