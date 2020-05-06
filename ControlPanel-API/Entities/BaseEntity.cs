using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Entities
{
    /// <summary>
    /// Base for all entities.
    /// </summary>
    public abstract class BaseEntity
    {
        #region Attributes
        private int id;
        #endregion

        #region Properties
        /// <summary>
        /// The unique identifier for the entity.
        /// </summary>
        public int Id { get { return id; } set { id = value; } }
        #endregion
    }
}
