using System;
using BasisCore.Runtime.Storage;
using UnityEngine;

namespace App.Storage
{
    [Serializable] 
    public class CurrencyStorageItem : StorageItem
    {
        public int Soft { get; set; }
        public int Hard { get; set; }
    }
}