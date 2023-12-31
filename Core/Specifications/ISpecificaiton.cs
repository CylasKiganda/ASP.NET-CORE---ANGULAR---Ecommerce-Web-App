using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecificaiton<T>
    {
        Expression<Func<T,bool>> Criteria{get;}
        List<Expression<Func<T, object>>> Includes{get;}
    }
}