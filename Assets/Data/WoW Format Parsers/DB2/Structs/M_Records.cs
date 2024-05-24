using Assets.Const;
using Assets.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public partial class DB2
{

    public enum MapTypes : byte
    {
        Common = 0,
        Instance = 1,
        Raid = 2,
        Battleground = 3,
        Arena = 4,
        Scenario = 5
    }

    public sealed class MapRecord
    {
        public uint Id;
        public string Directory;
        public string MapName;
        public string MapDescription0;                               // Horde
        public string MapDescription1;                               // Alliance
        public string PvpShortDescription;
        public string PvpLongDescription;
        public float[] Corpse = new float[2];                                           // entrance coordinates in ghost mode  (in most cases = normal entrance)
        public byte MapType;
        public byte InstanceType;
        public byte ExpansionID;
        public ushort AreaTableID;
        public short LoadingScreenID;
        public short TimeOfDayOverride;
        public short ParentMapID;
        public short CosmeticParentMapID;
        public byte TimeOffset;
        public float MinimapIconScale;
        public short CorpseMapID;                                              // map_id of entrance map in ghost mode (continent always and in most cases = normal entrance)
        public byte MaxPlayers;
        public short WindSettingsID;
        public int ZmpFileDataID;
        public int WdtFileDataID;
        public int NavigationMaxDistance;
        public uint[] Flags = new uint[3];
    }
}
