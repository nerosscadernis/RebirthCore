using Rebirth.Common.IStructures;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Dialogs
{
    public class BookDialog : IActivity
    {
        public DialogTypeEnum DialogType
        {
            get
            {
                return DialogTypeEnum.DIALOG_BOOK;
            }
        }
        public Character Character
        {
            get;
            private set;
        }

        public uint BookId
        {
            get;
            private set;
        }

        public BookDialog(Character character, uint BookId)
        {
            this.Character = character;
            this.BookId = BookId;
            Open();
        }
        public virtual void Open()
        {
            this.Character.State = PlayerState.Available;
            this.Character.Activity = this;
            this.Character.Client.Send(new DocumentReadingBeginMessage(BookId));

        }
        public virtual void Close()
        {
            this.Character.State = PlayerState.Available;
            this.Character.Client.Send(new LeaveDialogMessage((sbyte)this.DialogType));
            this.Character.Activity = null;
        }
    }
}
