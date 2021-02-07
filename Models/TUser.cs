using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TUser
    {
        public int UserId { get; set; }
        public string UserLoginName { get; set; }
        public byte[] UserPasswordHash { get; set; }
        public Guid UserSalt { get; set; }
        public DateTime UserPassDate { get; set; }
        public string UserStatus { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
    }
}
