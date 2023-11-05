using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class SchemeDetails
    {
        [Key]
        public int DetailId { get; set; } //pk
        public string SchemeImage { get; set; } // URL or path to the image representing the scheme
        public string Description { get; set; }      
        public double MinAmount { get; set; } // minimum amount required for investment in the scheme
        public double MaxAmount { get; set; } // maximum amount allowed for investment in the scheme
        public int MinInvestmentTime { get; set; } // minimum period of time (in months) for investment
        public int MaxInvestmentTime { get; set; }  // maximum period of time (in months) for investment
        public int MinAge { get; set; } // minimum age requirement for the scheme
        public int MaxAge { get; set; } // maximum age allowed for the scheme
        public double ProfitRatio { get; set; } // ratio of profit associated with the scheme
        public double RegistrationCommRatio { get; set; }  // ratio of commission for registration related to the scheme       
        public double InstallmentCommRatio { get; set; } // ratio of commission for installments related to the scheme
        public bool IsActive { get; set; }
    }
}
