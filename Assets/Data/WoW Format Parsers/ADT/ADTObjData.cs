using Assets.Data.WoW_Format_Parsers.WMO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Data.WoW_Format_Parsers.ADT
{
    public static class ADTObjData
    {

        public static Queue<ModelBlockData> ModelBlockDataQueue = new Queue<ModelBlockData>();
        public static ModelBlockData modelBlockData = new ModelBlockData();

        public class ModelBlockData
        {
            // Terrain Positioning //
            public Vector2 terrainPos = new Vector2();

            // WMO data //
            public Dictionary<int, int> WMOPath  = new Dictionary<int, int>();
            public List<int> WMOOffsets                = new List<int>();
            public List<WMOPlacementInfo> WMOInfo       = new List<WMOPlacementInfo>();

            // M2 data //
            public Dictionary<int, int> M2Path   = new Dictionary<int, int>();
            public List<int> M2Offsets                 = new List<int>();
            public List<M2PlacementInfo> M2Info         = new List<M2PlacementInfo>();
        }

        public class M2PlacementInfo
        {
            public int nameId;
            public int uniqueID;
            public Vector3 position;
            public Quaternion rotation;
            public float scale;
            public Flags.MDDFFlags flags;
        }

        public class WMOPlacementInfo
        {
            public int nameId;
            public int uniqueID;
            public Vector3 position;
            public Quaternion rotation;
            public BoundingBox extents;
            public Flags.MODFFlags flags;
            public int doodadSet;
            public int nameSet;
            public float Scale;
        }
    }
}