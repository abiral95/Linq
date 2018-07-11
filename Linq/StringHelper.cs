using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Linq
{
    public static class StringHelper
    {

        public static string ChangeFirstLetterCase( this string inputString)
        {
            if(inputString.Length > 0)
            {
                char[] cArray = inputString.ToCharArray();
                cArray[0] = char.IsUpper(cArray[0]) ? char.ToLower(cArray[0]) : char.ToLower(cArray[0]);
                return new string(cArray);
            }
         
            return inputString;

        }

    }
}