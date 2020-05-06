using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Entities.CellEntities
{
    public class CellBorder
    {
        #region Attributes
        private int thickness;
        private BorderShape borderShape;
        #endregion

        #region Properties
        /// <summary>
        /// Declares the thickness of the border.
        /// </summary>
        public int Thickness { get { return thickness; } set { thickness = value; } }

        /// <summary>
        /// Declare a bordershape to the border.
        /// <see cref="BorderShape"/>
        /// </summary>
        public BorderShape BorderShape { get { return borderShape; } set { borderShape = value; } }
        #endregion
    }
}
