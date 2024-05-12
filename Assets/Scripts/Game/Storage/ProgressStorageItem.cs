using System;
using BasisCore.Runtime.Storage;

namespace App.Storage
{
    [Serializable]
    public class ProgressStorageItem : StorageItem
    {
        public int Level { get; set; } = 1;
        public int Experience { get; set; }
    }
}