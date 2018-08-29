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
        public Inventory pInventory;

        /******************************************************/
        // Constructor
        public Player( string username, string password, string email )
        {
            if (checkUsernameLength(username))
                this.Username = username;
            else throw new InvalidUsername("Invalid Length: " + username.Length.ToString());

            if (checkPassword(password))
                this.Password = password;
            else throw new InvalidPassword();

            this.Username = username;
            this.Password = password;
            this.EmailAddress = email;
            this.DateJoined = DateTime.Now;

            pInventory = new Inventory(this);
        }

        /******************************************************/
        // Gettors

        /******************************************************/
        // Settors

        /******************************************************/
        // Utility

    }
}
