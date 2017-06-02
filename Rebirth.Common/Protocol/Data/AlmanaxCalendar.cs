

















// Generated on 01/12/2017 03:53:10
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("AlmanaxCalendars")]
    
public class AlmanaxCalendar : IDataObject
{

public const String MODULE = "AlmanaxCalendars";
        public int id;
        public uint nameId;
        public uint descId;
        public int npcId;
        public List<int> bonusesIds;
        

}

}