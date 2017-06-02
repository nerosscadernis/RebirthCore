using Rebirth.Common.Protocol.Enums;
using Rebirth.World.Datas.Maps;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives
{
    public class ObjectPosition
    {
        private DirectionsEnum m_direction;
        private CellMap m_cell;
        private MapTemplate m_map;
        private MapPoint m_point;
        public event System.Action<ObjectPosition> PositionChanged;
        public bool IsValid
        {
            get
            {
                return this.m_cell.Id > 0 && (long)this.m_cell.Id < 560L && this.m_direction > DirectionsEnum.DIRECTION_EAST && this.m_direction < DirectionsEnum.DIRECTION_NORTH_EAST && this.m_map != null;
            }
        }
        public DirectionsEnum Direction
        {
            get
            {
                return this.m_direction;
            }
            set
            {
                this.m_direction = value;
                this.NotifyPositionChanged();
            }
        }
        public CellMap Cell
        {
            get
            {
                return this.m_cell;
            }
            set
            {
                this.m_cell = value;
                this.m_point = null;
                this.NotifyPositionChanged();
            }
        }
        public MapTemplate Map
        {
            get
            {
                return this.m_map;
            }
            set
            {
                this.m_map = value;
                this.NotifyPositionChanged();
            }
        }
        public MapPoint Point
        {
            get
            {
                MapPoint arg_1E_0;
                if ((arg_1E_0 = this.m_point) == null)
                {
                    arg_1E_0 = (this.m_point = MapPoint.GetPoint(this.Cell));
                }
                return arg_1E_0;
            }
        }
        private void NotifyPositionChanged()
        {
            System.Action<ObjectPosition> positionChanged = this.PositionChanged;
            if (positionChanged != null)
            {
                positionChanged(this);
            }
        }
        public ObjectPosition(ObjectPosition position)
        {
            this.m_map = position.Map;
            this.m_cell = position.Cell;
            this.m_direction = position.Direction;
        }
        public ObjectPosition(MapTemplate map, CellMap cell)
        {
            this.m_map = map;
            this.m_cell = cell;
            this.m_direction = DirectionsEnum.DIRECTION_EAST;
        }
        public ObjectPosition(MapTemplate map, short cellId)
        {
            this.m_map = map;
            this.m_cell = map.Cells[(int)cellId];
            this.m_direction = DirectionsEnum.DIRECTION_EAST;
        }
        public ObjectPosition(MapTemplate map, CellMap cell, DirectionsEnum direction)
        {
            this.m_map = map;
            this.m_cell = cell;
            this.m_direction = direction;
        }
        public ObjectPosition(MapTemplate map, short cellId, DirectionsEnum direction)
        {
            this.m_map = map;
            this.m_cell = map.Cells[(int)cellId];
            this.m_direction = direction;
        }
        public ObjectPosition Clone()
        {
            return new ObjectPosition(this.Map, this.Cell, this.Direction);
        }
    }
}
