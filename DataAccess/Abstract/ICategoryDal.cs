using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Linq;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
       
    }
}
