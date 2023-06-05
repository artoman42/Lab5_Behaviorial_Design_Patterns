using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class XSSValidator : AbstractValidator
    {
        public override bool Validate(string value)
        {
            string pattern = @"<[^>]+>|&[^;]+;";
            if (!Regex.IsMatch(value, pattern))
            {
                return base.Validate(value);
            }

            return false; 
        }
    }
}
