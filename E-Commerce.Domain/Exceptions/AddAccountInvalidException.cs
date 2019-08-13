using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    public class AddAccountInvalidException : Exception
    {
        public AddAccountInvalidException(string addAccount, Exception exc) 
            : base($"Add Account \"{addAccount}\" is invalid.", exc)
        {

        }
    }
}
