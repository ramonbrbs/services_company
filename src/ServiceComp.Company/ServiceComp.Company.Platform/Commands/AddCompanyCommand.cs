using ServiceComp.Company.Domain;

namespace ServiceComp.Company.Platform.Commands
{
    public class AddCompanyCommand: BaseCommand
    {
        public string Name { get; set; }
        public string CorporateName { get; set; }
        public string DocumentNumber { get; set; }

        public Address Address { get; set; }
    }
}