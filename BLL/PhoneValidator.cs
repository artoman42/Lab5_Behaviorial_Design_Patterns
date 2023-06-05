using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class PhoneValidator:AbstractValidator
    {
        public override bool Validate(string value)
        {
            string pattern = @"^(?:\+38|38)?\d{10}$";
            if (Regex.IsMatch(value, pattern))
            {
                return base.Validate(value);
            }
            else
                return false;
        }
    }
}
