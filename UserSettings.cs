using System;
using System.Collections.Generic;

namespace CabMaker
{
    [Serializable]
    public class UserSettings
    {
        public string OutputFile { get; set; }
        public string RootDirectory { get; set; }
        public object CompressionType { get; set; }
        public object CompressionWindowSize { get; set; }
        public bool SaveUserSettings { get; set; }
        public bool DeleteSidecars { get; set; }
    }
}
