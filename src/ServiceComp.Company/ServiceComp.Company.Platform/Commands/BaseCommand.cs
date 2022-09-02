using System;

namespace ServiceComp.Company.Platform.Commands
{
    public class BaseCommand
    {
        public Guid LoggedUserId { get; set; }
        public Guid? CompanyId { get; set; }
    }
}