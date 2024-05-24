using System.Collections.Generic;
using UnityEngine;
using CASCLib;
using Assets.UI.CASC;
using DBFileReaderLib;

public partial class DB2
{
    public class DB2Reader
    {
        private CASCHandler Casc;
        private DBReader Reader;

        public DB2Reader(int FileDataId)
        {
            Casc = GameObject.Find("[CASC]").GetComponent<CascHandler>().cascHandler;
            
            var stream = Casc.OpenFile(FileDataId);
            Reader = new DBReader(stream);
        }
        public DB2Reader(string FileName)
        {
            Casc = GameObject.Find("[CASC]").GetComponent<CascHandler>().cascHandler;

            var stream = Casc.OpenFile(FileName);
            Reader = new DBReader(stream);
        }

        public Storage<T> GetRecords<T>() where T : class, new() => Reader.GetRecords<T>();

        public void PopulateRecords<T>(IDictionary<int, T> storage) where T : class, new() => Reader.PopulateRecords<T>(storage);
    }
}
