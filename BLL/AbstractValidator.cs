using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class AbstractValidator : IValidator
    {
        private IValidator _nextValidator;

        public IValidator SetNext(IValidator validator)
        {
            this._nextValidator = validator;

            return validator;
        }

        public virtual bool Validate(string value)
        {
            if (this._nextValidator != null)
            {
                return this._nextValidator.Validate(value);
            }
            else
            {
                return true;
            }
        }
    }
}
