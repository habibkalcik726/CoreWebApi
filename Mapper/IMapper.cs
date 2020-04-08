using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Mapper
{
    public interface IMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);

    }
}
