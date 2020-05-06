using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Entities.CellEntities
{
    public class CellColor
    {
        #region Attributes
        private string textColor;
        private string backgroundColor;
        private string borderColor;
        #endregion

        #region Properties
        /// <summary>
        /// Declare a text font color.
        /// </summary>
        public string TextColor { get { return textColor; } set { textColor = value; } }

        /// <summary>
        /// Declare a background color.
        /// </summary>
        public string BackgroundColor { get { return backgroundColor; } set { backgroundColor = value; } }

        /// <summary>
        /// The color of the border.
        /// </summary>
        public string BorderColor { get { return borderColor; } set { borderColor = value; } }
        #endregion
    }
}
