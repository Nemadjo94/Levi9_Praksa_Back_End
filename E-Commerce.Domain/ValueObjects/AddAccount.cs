using E_Commerce.Domain.Exceptions;
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
                throw new AddAccountInvalidException(accountString, exc);
            }

            return account;
        }

        public string Domain { get; private set; }

        public string Name { get; private set; }

        public static implicit operator string(AddAccount account)
        {
            return account.ToString();
        }

        public static explicit operator AddAccount(string accountString)
        {
            return For(accountString);
        }

        public override string ToString()
        {
            return $"{Domain}\\{Name}";
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Domain;
            yield return Name;
        }
    }
}
