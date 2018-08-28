using PlayerDatabaseModule.Exceptions;
using static PlayerDatabaseModule.Security.Validation;

namespace PlayerDatabaseModule
{
    public partial class Player
    {
        /******************************************************/
        // Member Variables
        private string username;
        private string password;
        //private long playerID;

        /******************************************************/
        // Constructor
        public Player( string username, string password, long id )
        {
            if (checkUsernameLength(username))
                this.username = username;
            else throw new InvalidUsername("Invalid Length: " + username.Length.ToString());

            if (checkPassword(password))
                this.password = password;
            else throw new InvalidPassword();

            //this.playerID = id;
        }

        /******************************************************/
        // Gettors
        public string getUsername() { return this.username; }
        public string getPassword() { return this.password; }
        //public long getID() { return this.playerID;  }

        /******************************************************/
        // Settors

        /******************************************************/
        // Utility

    }
}
