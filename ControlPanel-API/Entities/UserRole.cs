using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Entities
{
    /// <summary>
    /// A Role for the User.
    /// </summary>
    public class UserRole
    {
        #region Attributes
        private string name;
        private string description;
        #endregion

        #region Properties
        /// <summary>
        /// The name of the user given Role.
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

        /// <summary>
        /// The description of the user given role.
        /// </summary>
        public string Description { get { return description; } set { description = value; } }
        #endregion
    }
}
