using System;
using System.Collections.Generic;
using PlayerDatabaseModule.Exceptions;
using static PlayerDatabaseModule.Security.Validation;
using static PlayerDatabaseModule.DatebaseUtility.PlayerDB;

namespace PlayerDatabaseModule
{
    public static class GlobalPlayerInformation
    {
        public static int PlayerCount = 0;
        public static List<Player> playerList;

        public static void LoadPlayers()
        {
            playerList = LoadAllPlayers();
            PlayerCount = playerList.Count;
        }
    }
    public partial class Player
    {
        /******************************************************/
        // Member Variables
        private string username;
        private string password;
        private string email;
        public Inventory pInventory;

        /******************************************************/
        // Constructor
        public Player( string username, string password, string email )
        {
            if (checkUsernameLength(username))
                this.username = username;
            else throw new InvalidUsername("Invalid Length: " + username.Length.ToString());

            if (checkPassword(password))
                this.password = password;
            else throw new InvalidPassword();

            this.email = email;

            this.Username = username;
            this.Password = password;
            this.EmailAddress = email;
            this.DateJoined = DateTime.Now;

            pInventory = new Inventory(this);
        }

        /******************************************************/
        // Gettors
        public string getUsername() { return this.username; }
        public string getPassword() { return this.password; }

        /******************************************************/
        // Settors

        /******************************************************/
        // Utility

    }
}
