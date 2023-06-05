using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class MailValidator : AbstractValidator
    {
        public override bool Validate(string value)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(value, pattern))
            {
                return base.Validate(value);
            }
            else
                return false;
        }
    }
}
