using E_Commerce.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.ValueObjects
{
    public class AddAccount : ValueObject
    {
        private AddAccount()
        {

        }

        public static AddAccount For(string accountString)
        {
            var account = new AddAccount();

            try
            {
                var index = accountString.IndexOf("\\", StringComparison.Ordinal);
                account.Domain = accountString.Substring(0, index);
                account.Name = accountString.Substring(index + 1);
            }
            catch(Exception exc)
            {
                throw new AddAccountInvalid
            }
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
