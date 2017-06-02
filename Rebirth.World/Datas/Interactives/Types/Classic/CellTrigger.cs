using Rebirth.Common.Protocol.Enums;
using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types.Classic
{
    public abstract class CellTrigger
    {
        public MapTrigger Record
        {
            get;
            private set;
        }
        public ObjectPosition Position
        {
            get;
            private set;
        }
        public CellTriggerType TriggerType
        {
            get
            {
                return this.Record.TriggerType;
            }
        }
        protected CellTrigger(MapTrigger record)
        {
            this.Record = record;
            this.Position = record.GetPosition();
        }
        public abstract void Apply(Character character);
    }
}
