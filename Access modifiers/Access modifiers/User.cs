using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifiers
{
    internal class User
    {
        public User(string username)
        {
            UserName=username;
            
        }
        
        private string _userName;
        private string _password;

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length >= 6 && value.Length <= 25)
                {
                    _userName = value;
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                
                if (!String.IsNullOrWhiteSpace(value) && value.Length >= 8 && value.Length <= 25 && HasDigit(value) && HasUpper(value) && HasLower(value))
                {
                    _password = value;
                }
            }
        }


        public bool HasDigit(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasUpper(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsUpper(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasLower(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLower(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
