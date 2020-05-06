using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Entities.CellEntities
{
    public enum ShapeType { Default, Rounded, Squared, Circle }

    public class BorderShape
    {
        #region Attributes
        private ShapeType shapeType;
        private string description;
        #endregion

        #region Properties
        /// <summary>
        /// Declares the shape type of the border.
        /// </summary>
        public ShapeType ShapeType { get { return shapeType; } set { shapeType = value; } }

        /// <summary>
        /// Declares a description for the shape type.
        /// * If needed.
        /// </summary>
        public string Description { get { return description; } set { description = value; } }
        #endregion
    }
}
