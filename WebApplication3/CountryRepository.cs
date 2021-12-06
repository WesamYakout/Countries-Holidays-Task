using WebApplication3.Models;

namespace WebApplication3
{
    public class CountryRepository : RepositoryBase<Country> , ICountryRepository
    {
        public CountryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}