using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Bns.Identity.Domain.Users
{
    public class User : Entity<Guid>    
    {
        public string UserName { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a salted and hashed representation of the password for this user.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// A random value that must change whenever a users credentials change (password changed, login removed)
        /// </summary>
        public string SecurityStamp { get; set; }

        [CanBeNull]
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

        /// <summary>
        /// Gets or sets the number of failed login attempts for the current user.
        /// </summary>
        public int AccessFailedCount { get; set; } = 0;

        public DateTime? CreateDate { get; set; } = DateTime.Now;

        public DateTime? ModificationDate { get; set; }

        public User(Guid id, string userName, string email) : base(id)
        {
            Check.NotNull(userName, nameof(userName));
            Check.NotNull(email, nameof(email));

            UserName = userName;
            Email = email;
        }
    }
}
