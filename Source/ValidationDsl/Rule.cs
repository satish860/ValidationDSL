using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDsl
{
    public class Rule:IRule
    {
        public string PropertyName { get; set; }
        public Rule(string propertyName)
        {
            this.PropertyName = propertyName;
        }

        public string ForProperty()
        {
            return this.PropertyName;
        }
    }
}
