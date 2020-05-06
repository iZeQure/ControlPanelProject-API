using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Entities.CellEntities
{
    public enum SizeType { Small, Medium, Large, Fullsized }

    public class CellSize
    {
        #region Attributes
        private SizeType sizeType;
        #endregion

        #region Properties
        /// <summary>
        /// Decalre Size of the Cell.
        /// </summary>
        public SizeType SizeType { get { return sizeType; } set { sizeType = value; } }
        #endregion
    }
}
