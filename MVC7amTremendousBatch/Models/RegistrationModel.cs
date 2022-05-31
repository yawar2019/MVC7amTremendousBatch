using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC7amTremendousBatch.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage ="Full Name is Required")]
        public string fname { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        public string pwd { get; set; }
        [Compare("pwd")]
        public string ConfirmPwd { get; set; }
        [Required(ErrorMessage ="Gender is Required")]
        public string Gender { get; set; }
        public string java { get; set; }
        public string Dotnet { get; set; }
        [Required(ErrorMessage = "Department is Required")]
        [Display(Name ="Department")]
        public string Dept { get; set; }

        [DataType(DataType.EmailAddress,ErrorMessage ="Emailid is Required")]
        public string EmailId { get; set; }

        [Range(18,30,ErrorMessage ="18-30 required")]
        public int Age { get; set; }
        [StringLength(10,ErrorMessage ="max 10 character")]
        public string Address { get; set; }
    }
}