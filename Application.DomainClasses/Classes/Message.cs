using System;

namespace Application.DomainClasses.Classes
{
    public class Message
    {
        public int MessageId { get; set; }

        public string MessageForUserId { get; set; }
        public virtual ApplicationUser MessageForUser { get; set; }

        public string MessageFromUserId { get; set; }

        public virtual ApplicationUser MessageFromUser { get; set; }

        public string MessageContent { get; set; }

        public bool MessageRead { get; set; }

        public DateTime MessageCreatedOn { get; set; }

        public DateTime? MessageReadOn { get; set; }
    }
}