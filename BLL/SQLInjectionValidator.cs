using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SQLInjectionValidator : AbstractValidator 
    {
        public override bool Validate(string value)
        {

            string[] forbiddenCharacters = { "'", "\"", ";", "--", "/*", "*/" };

            foreach (var character in forbiddenCharacters)
            {
                if (value.Contains(character))
                {
                    return false; 
                }
            }

            return base.Validate(value); 
        }
    }
    
}
