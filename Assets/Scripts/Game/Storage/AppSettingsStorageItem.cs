using System;
using BasisCore.Runtime.Storage;
using UnityEngine;

namespace App.Storage
{
    [Serializable] 
    public sealed class AppSettingsStorageItem : StorageItem
    {
        public bool IsMuteMusic { get; set; }
        public bool IsMuteSounds { get; set; }
        public bool IsVibration { get; set; }
    }
}