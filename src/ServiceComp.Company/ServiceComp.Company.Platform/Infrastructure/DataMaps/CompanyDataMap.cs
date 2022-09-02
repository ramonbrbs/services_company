using System;
using ServiceComp.Company.Domain;

namespace ServiceComp.Company.Platform.Infrastructure.DataMaps
{
    public class CompanyDataMap
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CorporateName { get; set; }
        public string DocumentNumber { get; set; }
        public Address Address { get; set; }
    }
}