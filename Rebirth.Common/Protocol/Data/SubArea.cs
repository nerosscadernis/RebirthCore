

















// Generated on 01/12/2017 03:53:15
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("SubAreas")]
    
public class SubArea : IDataObject
{

public const String MODULE = "SubAreas";
        public int id;
        public uint nameId;
        public int areaId;
        public List<AmbientSound> ambientSounds;
        public List<List<int>> playlists;
        public List<uint> mapIds;
        public Rectangle bounds;
        public List<int> shape;
        public List<uint> customWorldMap;
        public int packId;
        public uint level;
        public Boolean isConquestVillage;
        public Boolean basicAccountAllowed;
        public Boolean displayOnWorldMap;
        public List<uint> monsters;
        public List<uint> entranceMapIds;
        public List<uint> exitMapIds;
        public Boolean capturable;
        public List<uint> achievements;
        public List<List<int>> quests;
        public List<List<int>> npcs;
        public int exploreAchievementId;
        public Boolean isDiscovered;
        public List<int> harvestables;
        

}

}