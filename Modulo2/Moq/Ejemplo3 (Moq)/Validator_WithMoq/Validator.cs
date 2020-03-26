using System.Collections.Generic;

namespace ValidatorWithMoq
{
    public class ValidatorRules
    {
        Dictionary<string, List<IValidatorRule>> _rules = new Dictionary<string, List<IValidatorRule>>();

        public void AddRule(string fieldName, IValidatorRule rule)
        {
            if (_rules.ContainsKey(fieldName))
            {
                _rules[fieldName].Add(rule);
            }
            else
            {
                _rules.Add(fieldName, new List<IValidatorRule> { rule });
            }
        }

        public bool IsValid(string fieldName, object value)
        {
            if(_rules.ContainsKey(fieldName))
            {
                var rules = _rules[fieldName];

                foreach (var rule in rules)
                {
                    var isValid = rule.IsValid(value);

                    if(!isValid)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
