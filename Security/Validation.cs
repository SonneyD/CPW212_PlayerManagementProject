using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDatabaseModule.Security
{
    public static class Validation
    {
        public static bool checkUsernameLength( string username )
        {
            if (username.Length <= 3 || username.Length > 16)
                return false;

            return true;
        }

        public static bool checkPassword( string password )
        {
            if (password.Length <= 3 || password.Length > 16)
                return false;

            bool hasCap = false;
            bool hasSymbol = false;

            foreach( char l in password )
            {
                if (checkSymbol(l))
                    hasSymbol = true;
                if (Char.IsUpper(l))
                    hasCap = true;
            }

            return ( (hasCap && hasSymbol) ? true : false );
        }

        private static bool checkSymbol( char val )
        {
            switch( val )
            {
                case '!':
                    return true;
                case '@':
                    return true;
                case '#':
                    return true;
                case '$':
                    return true;
                case '%':
                    return true;
                case '^':
                    return true;
                case '&':
                    return true;
                case '*':
                    return true;

                default:
                    return false;
            }
        }

    }
}
