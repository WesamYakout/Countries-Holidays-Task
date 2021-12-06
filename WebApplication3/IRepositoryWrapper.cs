namespace WebApplication3
{
    public interface IRepositoryWrapper
    {
        ICountryRepository Country { get; }
        IHolidayRepository Holiday { get; }
        void Save();
    }
}