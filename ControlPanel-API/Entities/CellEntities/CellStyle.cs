using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Entities.CellEntities
{
    public class CellStyle
    {
        #region Attributes
        private CellSize cellSize;
        private CellBorder cellBorder;
        private CellColor cellColor;
        #endregion

        #region Properties
        /// <summary>
        /// Modify the Cell Size.
        /// <see cref="CellEntities.CellSize"/>
        /// </summary>
        public CellSize CellSize { get { return cellSize; } set { cellSize = value; } }

        /// <summary>
        /// Modify the Cell Border.
        /// <see cref="CellEntities.CellBorder"/>
        /// </summary>
        public CellBorder CellBorder { get { return cellBorder; } set { cellBorder = value; } }

        /// <summary>
        /// Modify the Cell Color.
        /// <see cref="CellEntities.CellColor"/>
        /// </summary>
        public CellColor CellColor { get { return cellColor; } set { cellColor = value; } }
        #endregion
    }
}
