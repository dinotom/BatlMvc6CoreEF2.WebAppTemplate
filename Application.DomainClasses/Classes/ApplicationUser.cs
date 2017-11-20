using Application.DomainClasses.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Application.DomainClasses.Classes
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public SubscriptionLevel SubscriptionLevel { get; set; }
        public NotificationType NotificationType { get; set; }
        public string AvatarUrl { get; set; }
        public ICollection<Message> UserMessages { get; set; }
        public ICollection<Message> SentMessages { get; set; }
        public ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public Gender GetUserGender(string username)
        {
            //TODO: complete code, just stubbed out
            return Gender;
        }

        public string GetFullName(string username)
        {
            //TODO: complete code, just stubbed out
            return $"{FirstName} {LastName}";
        }

        public string GetFullName(int userId)
        {
            //TODO: complete code, just stubbed out
            return $"{FirstName} {LastName}";
        }

        //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        //{
        //    // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        //    var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
        //    // Add custom user claims here
        //    return userIdentity;
        //}
    }
}