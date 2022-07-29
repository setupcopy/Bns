using Volo.Abp.Application.Dtos;

namespace Bns.Identity.Application.Contracts.Users
{
    public  class UserDto : EntityDto<Guid>
    {
        public string UserName { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a salted and hashed representation of the password for this user.
        /// </summary>
        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the date and time when any user lockout ends.
        /// </summary>
        public DateTimeOffset? LockoutTime { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if the user could be locked out.
        /// </summary>
        /// <value>True if the user could be locked out, otherwise false.</value>
        public bool LockoutEnabled { get; set; } = false;

        public DateTime? CreateDate { get; set; } = DateTime.Now;

        public DateTime? ModificationDate { get; set; }
    }
}
