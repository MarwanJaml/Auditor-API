namespace APi.Models.Domain
{
    public class OfficeInfo
    {
        public int Id { get; set; }
        public required string OfficeName { get; set; }
        public List<string> PhoneNumbers { get; set; } = new List<string>();
        public List<string> Emails { get; set; } = new List<string>();
        public string? TaxNumber { get; set; }
        public int CertifiedAccountants { get; set; }
        public int Employees { get; set; }
        public List<string> LicensedAccountants { get; set; } = new List<string>();
        public List<string> LicenseNumbers { get; set; } = new List<string>();
        public int ExpectedBudgets { get; set; }
    }
}
