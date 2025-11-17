using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePremiumCalc.Domain.DTO_s
{
    public class PremiumRequest
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]     
        [Display(Name = "Age Next Birthday")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth (MM/YYYY)")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Occupation is required")]
        public string Occupation { get; set; }

        [Required(ErrorMessage = "Occupation factor is required")]       
        public decimal Factor { get; set; }

        [Required(ErrorMessage = "Death Sum Insured is required")]       
        [Display(Name = "Death – Sum Insured")]
        public decimal SumInsured { get; set; }

        [Display(Name = "Monthly Premium")]
        public decimal MonthlyPremium { get; set; }
    }
}
