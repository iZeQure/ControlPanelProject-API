using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Entities
{
    /// <summary>
    /// Create a user defined control panel.
    /// </summary>
    public class ControlPanel
    {
        #region Attributes
        private string name;
        private DateTime dateOfCreation;
        private bool isPublic;
        private IEnumerable<Cell> cells;
        #endregion

        #region Properties
        /// <summary>
        /// The name of the control panel.
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

        /// <summary>
        /// The Date of where the Control Panel were created on.
        /// </summary>
        public DateTime DateOfCreation { get { return dateOfCreation; } set { dateOfCreation = value; } }

        /// <summary>
        /// Wether the Control Panel is public to other users.
        /// </summary>
        public bool IsPublic { get { return isPublic; } set { isPublic = value; } }

        /// <summary>
        /// Sums a collection of cells within the Control Panel.
        /// <see cref="Entities.Cell"/>
        /// </summary>
        public IEnumerable<Cell> Cells { get { return cells; } set { cells = value; } }
        #endregion
    }
}
