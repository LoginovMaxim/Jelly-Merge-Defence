using System;
using BasisCore.Runtime.Storage;

namespace App.Storage
{
    [Serializable] 
    public class PersonalInfoStorageItem : StorageItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}