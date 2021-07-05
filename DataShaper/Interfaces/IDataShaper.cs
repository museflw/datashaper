using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataShaper.Models;

namespace DataShaper.Interfaces
{
    public interface IDataShaper<T>
    {
        IEnumerable<ShapedEntity> ShapeData(IQueryable<T> entities, string fieldsString);
        ShapedEntity ShapeData(T entity, string fieldsString);
    }
}