using System;
using System.ComponentModel.DataAnnotations;

namespace Mission4App.Models
{
    public class GradeCalcModel
    {

        // Check if the percentage is within the range of 0 and 100

        [Range(0, 100, ErrorMessage = "Percentage must be between 0% and 100%")]
        public int Assign { get; set; }

        [Range(0, 100, ErrorMessage = "Percentage must be between 0% and 100%")]
        public int Group { get; set; }

        [Range(0, 100, ErrorMessage = "Percentage must be between 0% and 100%")]
        public int Quiz { get; set; }

        [Range(0, 100, ErrorMessage = "Percentage must be between 0% and 100%")]
        public int Midterm { get; set; }

        [Range(0, 100, ErrorMessage = "Percentage must be between 0% and 100%")]
        public int Final { get; set; }

        [Range(0, 100, ErrorMessage = "Percentage must be between 0% and 100%")]
        public int Intex { get; set; }
    }
}
