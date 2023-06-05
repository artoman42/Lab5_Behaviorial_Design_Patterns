using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class PostOfficeBranchValidator : AbstractValidator
    {
        
        public override bool Validate(string value)
        {
            string pattern = @"^[a-zA-Z0-9\s.,#-]+$";
            if (Regex.IsMatch(value, pattern))
            {
                return base.Validate(value);
            }
            else
                return false;
        }
    }
}
