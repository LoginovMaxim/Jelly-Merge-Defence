namespace App.Storage
{
    public interface IProfileProvider
    {
        PersonalInfoStorageItem PersonalInfoData { get; }
        ProgressStorageItem ProgressData { get; }
        CurrencyStorageItem CurrencyData { get; }
    }
}