using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types
{
    public interface AbstractInteractive
    {
        int Type { get; }
        uint CellId { get; set; }
        uint[] ActionId { get; }
        int Identifier { get; set; }
        bool IsOnMap { get; set; }
        InteractiveElement GetInteractiveElement(Character character);
        void Use(Character character, uint actionId);
    }
}
