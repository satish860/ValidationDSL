using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSpec;
using ValidationDsl;

namespace ValidationDsl.Specs
{
    public class PropertyNameSpec:nspec
    {
        public void In_order_to_Select_the_Validation_for_Particular_Property()
        {
            context["First Should Select the property names Correctly"] = () =>
            {
                it["When Given the Property like p=>p.Name"] = () =>
                {
                    CustomerValidator CustomerValidator = TestInstance.CustomerValidator;
                    IRule Rule = CustomerValidator.RuleFor(p => p.Name);
                    Rule.ForProperty().should_be("Name");
                };

                it["When the Object is given instead of Value Type it should still get the name"] = () =>
                {
                    CustomerValidator CustomerValidator = TestInstance.CustomerValidator;
                    IRule Rule = CustomerValidator.RuleFor(p => p.Address);
                    Rule.ForProperty().should_be("Address");
                };
            };
        }
    }
}
