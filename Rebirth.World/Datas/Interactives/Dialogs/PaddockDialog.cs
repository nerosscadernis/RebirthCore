using Rebirth.Common.IStructures;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Dialogs
{
    public class PaddockDialog : IActivity
    {
        public DialogTypeEnum DialogType
        {
            get
            {
                return DialogTypeEnum.DIALOG_EXCHANGE;
            }
        }

        public Character Character
        {
            get;
            private set;
        }
        public virtual void Open()
        {
            this.Character.State = PlayerState.In_Paddock_Panel;
            this.Character.Activity = this;
        }

        public PaddockDialog(Character character, int skillId)
        {
            Character = character;
        }

        public void Close()
        {
            this.Character.State = PlayerState.Available;
            this.Character.Activity = null;
            Character.Client.Send(new ExchangeLeaveMessage((sbyte)DialogType, true));
        }
    }
}
