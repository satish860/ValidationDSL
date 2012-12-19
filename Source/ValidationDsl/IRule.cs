using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidationDsl
{
    public interface IRule
    {
        string ForProperty();
    }
}
