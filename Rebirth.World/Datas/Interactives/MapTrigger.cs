using PetaPoco.NetCore;
using Rebirth.Common.Protocol.Enums;
using Rebirth.World.Datas.Bdd;
using Rebirth.World.Datas.Interactives.Types.Classic;
using Rebirth.World.Datas.Maps;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives
{
    [TableName("world_maps_triggers")]
    public class MapTrigger : ParameterizableRecord
    {
        private short m_cellId;
        private string m_condition;
        private ConditionExpression m_conditionExpression;
        private int m_mapId;
        private bool m_mustRefreshPosition;
        private ObjectPosition m_position;
        public int Id
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public short CellId
        {
            get
            {
                return this.m_cellId;
            }
            set
            {
                this.m_cellId = value;
                this.m_mustRefreshPosition = true;
            }
        }
        public int MapId
        {
            get
            {
                return this.m_mapId;
            }
            set
            {
                this.m_mapId = value;
                this.m_mustRefreshPosition = true;
            }
        }
        public CellTriggerType TriggerType
        {
            get;
            set;
        }
        public string Condition
        {
            get
            {
                return this.m_condition;
            }
            set
            {
                this.m_condition = value;
                this.m_conditionExpression = null;
            }
        }
        [Ignore]
        public ConditionExpression ConditionExpression
        {
            get
            {
                ConditionExpression result;
                if (string.IsNullOrEmpty(this.Condition) || this.Condition == "null")
                {
                    result = null;
                }
                else
                {
                    ConditionExpression arg_47_0;
                    if ((arg_47_0 = this.m_conditionExpression) == null)
                    {
                        arg_47_0 = (this.m_conditionExpression = ConditionExpression.Parse(this.Condition));
                    }
                    result = arg_47_0;
                }
                return result;
            }
            set
            {
                this.m_conditionExpression = value;
                this.Condition = value.ToString();
            }
        }
        private void RefreshPosition(MapTemplate map)
        {
            CellMap cell = map.Cells[(int)this.CellId];
            this.m_position = new ObjectPosition(map, cell, DirectionsEnum.DIRECTION_EAST);
        }
        public ObjectPosition GetPosition()
        {
            return this.m_position;
        }
        public CellTrigger GenerateTrigger(MapTemplate map)
        {
            RefreshPosition(map);
            return DiscriminatorManager<CellTrigger>.Instance.Generate(Type, this);
        }
    }
}
