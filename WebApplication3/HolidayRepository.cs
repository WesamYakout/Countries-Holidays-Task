using WebApplication3.Models;

namespace WebApplication3
{
    public class HolidayRepository : RepositoryBase<Holiday> , IHolidayRepository
    {
        public HolidayRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}