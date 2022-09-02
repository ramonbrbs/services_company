using System;

namespace ServiceComp.Company.Domain
{
    public class CompanyUser
    {
        public Guid UserId { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset AddedAt { get; set; }
    }
}