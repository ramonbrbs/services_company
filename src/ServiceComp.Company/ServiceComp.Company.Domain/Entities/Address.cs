namespace ServiceComp.Company.Domain
{
    public class Address
    {
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Country Country { get; set; }
    }
}