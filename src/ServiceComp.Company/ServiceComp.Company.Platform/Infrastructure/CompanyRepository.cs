using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using ServiceComp.Company.Domain;

namespace ServiceComp.Company.Platform.Infrastructure
{
    public class CompanyRepository: ICompanyRepository
    {
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _database;

        public CompanyRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
            _database = mongoClient.GetDatabase("myservices");

        }
        
        public async Task Save(Domain.Company company)
        {
            throw new NotImplementedException();
        }

        public async Task<Domain.Company> Get(Guid companyId)
        {
            throw new NotImplementedException();
        }
    }
}