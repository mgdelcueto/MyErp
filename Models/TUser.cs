using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace MyErp.Models
{
    public partial class TUser
    {
        public int UserId { get; set; }

        [Display(Name="UserLoginName")]
        [Required(ErrorMessage="mUserLoginName"),StringLength(40)]
        public string UserLoginName { get; set; }
        public byte[] UserPasswordHash { get; set; }
        public Guid UserSalt { get; set; }
        public DateTime UserPassDate { get; set; }
        [Display(Name="UserStatus")]
        [Required(ErrorMessage="mUserStatus"),StringLength(4)]
        public string UserStatus { get; set; }
        [Display(Name="UserFirstName")]
        [Required(ErrorMessage="mUserFirstName"),StringLength(40)]
        public string UserFirstName { get; set; }
        [Display(Name="UserLastName")]
        [Required(ErrorMessage="mUserLastName"),StringLength(40)]
        public string UserLastName { get; set; }
    }
}
