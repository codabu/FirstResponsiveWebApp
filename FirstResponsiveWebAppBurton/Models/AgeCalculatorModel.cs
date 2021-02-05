using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppBurton.Models
{
    public class AgeCalculatorModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage =
            "Please enter a valid name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your birth year")]
        [Range(1900, 2015, ErrorMessage =
            "Birth year must be between 1900 and 2015")]
        public int? Year{ get; set; }

        [Required(ErrorMessage = "Please enter your birth month")]
        [Range(1, 12, ErrorMessage =
            "Birth month must be between 1 and 12")]
        public int? Month { get; set; }

        [Required(ErrorMessage = "Please enter the day you were born")]
        [Range(1, 31, ErrorMessage =
            "Day of birth must be between 1 and 31")]
        public int? Day { get; set; }
        public string AgeThisYear()
        {   string output;
            DateTime dateToday = DateTime.Now;
            int? todayDay = int.Parse(DateTime.Now.ToString("dd"));
            int? todayMonth = int.Parse(DateTime.Now.ToString("MM"));
            int? todayYear = int.Parse(DateTime.Now.ToString("yyyy"));
            int? age;
            age = todayYear - Year;
            if (Month > todayMonth || (Month == todayMonth && Day > todayDay ))
            {
                age--;
            }

            output = Name + " is " + age.ToString() + " years old.";
            return output;
        }
    }
}
