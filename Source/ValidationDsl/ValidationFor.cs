using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDsl
{
    public abstract class ValidationFor<T>
    {
        public IRule RuleFor<TProperty>(Expression<Func<T,TProperty>> Property)
        {
            MemberExpression member = Property.Body as MemberExpression;
            if (member == null)
                throw new InvalidOperationException("RuleFor Takes only the Property,Check if you assigned a Method");
            Rule rule = new Rule(member.Member.Name);
            return rule;
        }
    }
}
