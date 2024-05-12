using BasisCore.Runtime.Storage;

namespace App.Storage
{
    public class ProfileProvider : IProfileProvider
    {
        private readonly IStorage<PersonalInfoStorageItem> _personalInfoStorageItem;
        private readonly IStorage<ProgressStorageItem> _progressStorageItem;
        private readonly IStorage<CurrencyStorageItem> _currencyStorageItem;

        public PersonalInfoStorageItem PersonalInfoData => _personalInfoStorageItem.Item;
        public ProgressStorageItem ProgressData => _progressStorageItem.Item;
        public CurrencyStorageItem CurrencyData => _currencyStorageItem.Item;

        public ProfileProvider(
            IStorage<PersonalInfoStorageItem> personalInfoStorageItem, 
            IStorage<ProgressStorageItem> progressStorageItem, 
            IStorage<CurrencyStorageItem> currencyStorageItem)
        {
            _personalInfoStorageItem = personalInfoStorageItem;
            _progressStorageItem = progressStorageItem;
            _currencyStorageItem = currencyStorageItem;
        }
    }
}