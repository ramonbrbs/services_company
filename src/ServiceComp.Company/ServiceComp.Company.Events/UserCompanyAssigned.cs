using System;

namespace ServiceComp.Company.Events
{
    public class UserCompanyAssigned
    {
        public Guid UserId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime DateTime { get; set; }
    }
    
    public class UserCompanyUnAssigned
    {
        public Guid UserId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime DateTime { get; set; }
    }
}

