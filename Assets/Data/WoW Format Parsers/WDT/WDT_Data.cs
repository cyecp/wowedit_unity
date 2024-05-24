using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static partial class WDT  {

    public class WDTflagsdata
    {
        public bool adt_has_big_alpha;
        public bool adt_has_height_texturing;
        public bool[,] HasADT = new bool[64,64];
    }

    public static Dictionary<int, WDTflagsdata> Flags = new Dictionary<int, WDTflagsdata>(); // flags in a mapname dictionary (one wdt per map)
    public static Dictionary<(int, int), MapFileDataIds> WDTEntries = new Dictionary<(int, int), MapFileDataIds>();
    public struct MapFileDataIds
    {
        public int RootADT;
        public int OBJ0ADT;
        public int OBJ1ADT;
        public int TEX0ADT;
        public int LODADT;
        public int MapTexture;
        public int MapTextureN;
        public int MiniMapTexture;
    }
}
