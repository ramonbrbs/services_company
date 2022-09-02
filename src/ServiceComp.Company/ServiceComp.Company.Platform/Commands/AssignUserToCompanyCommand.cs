using System;

namespace ServiceComp.Company.Platform.Commands
{
    public class AssignUserToCompanyCommand: BaseCommand
    {
        public Guid UserId { get; set; }
    }
}