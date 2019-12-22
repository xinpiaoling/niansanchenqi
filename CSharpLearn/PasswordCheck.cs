using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    class PasswordCheck
    {
        public static bool PasswordCheckMethod(string password)
        {
            string Check = "abcdefAbcd1234!@#$";
            char[] passwordChar = password.ToCharArray();
            for (int i = 0; i < passwordChar.Length; i++)
            {
                if (Check.Contains(passwordChar[i]))
                {
                    return true;
                }
                else
                {
                    //do nothing
                }
            }
            return false;
        }

    }
}
