namespace APi.Models.Domain
{
    public class Customer
    {
        public int Id { get; set; }  
        public required string NationalId { get; set; } // الرقم الوطني  
        public required string TaxNumber { get; set; } // الرقم الضريبي
        public required string CustomerName { get; set; } // اسم العميل
        public required string RegistrationEntity { get; set; } // جهة التسجيل
        public required string CompanyType { get; set; } // نوع الشركة
        public required int  FinancialYear { get; set; } // السنة المالية
    }
}
