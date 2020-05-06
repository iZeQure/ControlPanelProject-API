using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Entities
{
    /// <summary>
    /// The base of the User Object.
    /// </summary>
    public class User : BaseEntity
    {
        #region Attributes
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string emailAddress;
        private string password;
        private bool onlineStatus;
        private bool isDisabled;
        private DateTime dateOfCreation;
        private UserRole userRole;
        private IEnumerable<ControlPanel> controlPanels;
        #endregion

        #region Properties
        /// <summary>
        /// The user's first name.
        /// </summary>
        public string FirstName { get { return firstName; } set { firstName = value; } }

        /// <summary>
        /// The user's last name.
        /// </summary>
        public string LastName { get { return lastName; } set { lastName = value; } }

        /// <summary>
        /// The user's phone number.
        /// </summary>
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }

        /// <summary>
        /// The User's Login Name / Contact Information.
        /// </summary>
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }

        /// <summary>
        /// The User's Login Secret.
        /// </summary>
        public string Password { get { return password; } set { password = value; } }

        /// <summary>
        /// The User's current online status.
        /// </summary>
        public bool OnlineStatus { get { return onlineStatus; } set { onlineStatus = value; } }

        /// <summary>
        /// Wether the user's account is disabled.
        /// </summary>
        public bool IsDisabled { get { return isDisabled; } set { isDisabled = value; } }

        /// <summary>
        /// The Date of when the user account was created.
        /// </summary>
        public DateTime DateOfCreation { get { return dateOfCreation; } set { dateOfCreation = value; } }

        /// <summary>
        /// The User's current account role.
        /// </summary>
        public UserRole UserRole { get { return userRole; } set { userRole = value; } }

        /// <summary>
        /// The collection of the user's Control Panels.
        /// </summary>
        public IEnumerable<ControlPanel> ControlPanel { get { return controlPanels; } set { controlPanels = value; } }
        #endregion
    }
}
