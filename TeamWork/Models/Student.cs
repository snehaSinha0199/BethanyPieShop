using System.ComponentModel.DataAnnotations;

namespace TeamWork.Models
{
    public class Student
    {

        public int StudentID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(20,MinimumLength =5)]
      [Required(ErrorMessage ="Please set First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage ="Please enter your email id")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$",ErrorMessage ="Please enter corerect email id")]
        public string EmailId { get; set; }
       
        [Display(Name = "Last Name")]
        [StringLength(20, MinimumLength = 5)]
        [Required(ErrorMessage = "Please set Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Age")]
        [Range(16, 36)]
        public int Age { get; set; }

        /*[Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone is required")]
         [DataType(DataType.PhoneNumber)]

         public long Phone { get; set; }*/

        //[Validation(ErrorMessage ="input is not valid")]

        [RegularExpression(@"^[a-dA-D]$", ErrorMessage = "Choose out of: A B C D")                     ]
        public string Gender { get; set; }

        [Display(Name = "Team Name")]
        [RegularExpression(@"^[a-dA-D]$", ErrorMessage = "Choose out of: A B C D")]

        public string TeamName { get; set; }

     /*   [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password did not match")]
        public string ConfirmPassword { get; set; }*/



    }
}
    

