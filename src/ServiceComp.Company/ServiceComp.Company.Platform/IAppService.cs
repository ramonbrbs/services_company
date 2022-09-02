using System.Threading.Tasks;
using ServiceComp.Company.Platform.Commands;

namespace ServiceComp.Company.Platform
{
    public interface IAppService
    {
        Task AssignUserToCompany(AssignUserToCompanyCommand command);
        Task RemoveUserFromCompany(UnassignUserToCompanyCommand command);
        Task CreateCompany(AddCompanyCommand command);
    }
}