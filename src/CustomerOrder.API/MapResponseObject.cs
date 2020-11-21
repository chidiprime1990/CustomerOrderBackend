using AutoWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.API
{
    public class MapResponseObject
    {
        [AutoWrapperPropertyMap(Prop.Result)]
        public object Data { get; set; }
    }
}
