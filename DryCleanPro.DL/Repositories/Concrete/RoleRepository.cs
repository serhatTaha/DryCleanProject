using DryClean.DL.EfCoreContexts;
using DryClean.DL.Repositories.Abstract;
using DryClean.Entities.Conrete;

namespace DryClean.DL.Repositories.Concrete
{
    public class RoleRepository : RepositoryBase<Role, int, SqlDbContext>, IRoleRespository
    {

    }
}
