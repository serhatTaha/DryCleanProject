using DryClean.DL.EfCoreContexts;
using DryClean.DL.Repositories.Abstract;
using DryClean.DL.Repositories.Concrete;
using DryClean.Entities.Conrete;

namespace DryCleanPro.DL.Repositories.Concrete
{
    public class CustomerRepository : RepositoryBase<Customer, int, SqlDbContext>, ICustomerRespository
    {

    }
}
