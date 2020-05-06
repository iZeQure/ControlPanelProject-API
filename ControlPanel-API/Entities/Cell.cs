using ControlPanel_API.Entities.CellEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Entities
{
    /// <summary>
    /// Create a Cell for the Control Panel.
    /// </summary>
    public class Cell
    {
        #region Attributes
        private int versionNumber;
        private bool visibility;
        private string data;
        private CellStyle cellStyle;
        #endregion

        #region Properties
        /// <summary>
        /// Versions Number for the current cell.
        /// </summary>
        public int VersionNumber { get { return versionNumber; } set { versionNumber = value; } }

        /// <summary>
        /// Visibility of the Cell.
        /// </summary>
        public bool Visibility { get { return visibility; } set { visibility = value; } }

        /// <summary>
        /// The Data value for the current cell.
        /// </summary>
        public string Data { get { return data; } set { data = value; } }

        /// <summary>
        /// Modify the Cell Style.
        /// <see cref="CellEntities.CellStyle"/>
        /// </summary>
        public CellStyle CellStyle { get { return cellStyle; } set { cellStyle = value; } }
        #endregion
    }
}
