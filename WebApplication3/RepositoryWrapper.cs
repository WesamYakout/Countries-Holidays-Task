namespace WebApplication3
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private ICountryRepository _country;
        private IHolidayRepository _holiday;
        public ICountryRepository Country {
            get {
                if(_country == null)
                {
                    _country = new CountryRepository(_repoContext);
                }
                return _country;
            }
        }
        public IHolidayRepository Holiday {
            get {
                if(_holiday == null)
                {
                    _holiday = new HolidayRepository(_repoContext);
                }
                return _holiday;
            }
        }
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}