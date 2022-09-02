using System;
using System.Threading.Tasks;

namespace ServiceComp.Company.Domain
{
    public interface ICompanyRepository
    {
        Task Save(Company company);
        Task<Company> Get(Guid companyId);
    }
}