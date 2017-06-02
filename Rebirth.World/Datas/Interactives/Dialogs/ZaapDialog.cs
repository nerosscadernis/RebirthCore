using Rebirth.Common.IStructures;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Datas.Characters;
using Rebirth.World.Datas.Interactives.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Dialogs
{
    public class ZaapDialog : IActivity
    {
        public DialogTypeEnum DialogType
        {
            get
            {
                return DialogTypeEnum.DIALOG_TELEPORTER;
            }
        }

        public Character Character
        {
            get;
            private set;
        }

        public virtual void Open()
        {
            this.Character.State = PlayerState.In_Zaap_Panel;
            this.Character.Activity = this;
        }

        public Zaap Zaap
        {
            get;
            private set;
        }

        public ZaapDialog(Character character, Zaap zaap)
        {
            this.Character = character;
            this.Zaap = zaap;
        }

        public void Close()
        {
            this.Character.State = PlayerState.Available;
            this.Character.Activity = null;
            Character.Client.Send(new LeaveDialogMessage((sbyte)DialogType));
        }
    }
}
