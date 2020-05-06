using ControlPanel_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel_API.Interfaces
{
    interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Create <see cref="T"/>.
        /// </summary>
        /// <param name="create"></param>
        void Create(T create);

        /// <summary>
        /// Delete <see cref="T"/>.
        /// </summary>
        /// <param name="delete"></param>
        void Delete(T delete);

        /// <summary>
        /// Update <see cref="T"/>.
        /// </summary>
        /// <param name="update"></param>
        void Update(T update);

        /// <summary>
        /// Get <see cref="T"/> by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Return all <see cref="T"/> entities.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
    }
}
