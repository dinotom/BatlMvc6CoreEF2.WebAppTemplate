using Application.DomainClasses.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Application.DomainClasses.Classes
{
    public class ContactUs
    {
        public int ContactUsId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string MobilePhone { get; set; }

        public ContactWho ContactWho { get; set; }

        //[Required(ErrorMessage = "Please note if this is an error report")]
        //public bool ReportingError { get; set; }

        [Required(ErrorMessage = "You meant to send us a message didn't you? Please add one.")]
        [StringLength(250)]
        public string Message { get; set; }

        public DateTime MessageSentTimestamp { get; set; }
    }
}