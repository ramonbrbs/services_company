using System;
using System.Threading.Tasks;
using ServiceComp.Company.Domain;
using ServiceComp.Company.Platform.Commands;

namespace ServiceComp.Company.Platform
{
    public class AppService: IAppService
    {
        private readonly ICompanyRepository _companyRepository;

        public AppService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        
        public async Task AssignUserToCompany(AssignUserToCompanyCommand command)
        {
            if (command.CompanyId is null) return;
            var company = await _companyRepository.Get(command.CompanyId.Value);
            company.AddUser(command.UserId);
            await _companyRepository.Save(company);
        }

        public async Task RemoveUserFromCompany(UnassignUserToCompanyCommand command)
        {
            if (command.CompanyId is null) return;
            var company = await _companyRepository.Get(command.CompanyId.Value);
            company.RemoveUser(command.UserId);
            await _companyRepository.Save(company);
        }

        public async Task CreateCompany(AddCompanyCommand command)
        {
            var company = new Domain.Company(command.Name, command.CorporateName, command.DocumentNumber,
                command.Address);
            company.AddUser(command.LoggedUserId);
            await _companyRepository.Save(company);
        }
    }
}



