using System;

namespace ServiceComp.Company.Platform.Commands
{
    public class UnassignUserToCompanyCommand: BaseCommand
    {
        public Guid UserId { get; set; }
    }
}