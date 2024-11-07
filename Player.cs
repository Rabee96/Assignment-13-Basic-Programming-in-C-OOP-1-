using UnityEngine;

namespace PlayerSpace
{
    public class Player
    {
        static int playerCount = 0;
        string playerName;
        public string PlayerName 
        {
            get { return playerName; }
        }
        int health;
        public int Health 
        {
            get { return health; }
        }

        public void InitializePlayer(string name,int healthPoints){
            playerCount++;
            playerName = name;
            health = healthPoints;
            
            Debug.Log($"Player {playerCount} has been created with name : {playerName} and {health} life points.");
        }

        public void Heal(int amount){

            if(amount >= 100 || amount + health>= 100 )
                Debug.Log($"Why not to ask for immortality instead, {playerName}😒");
            else if (amount <= 0)
                Debug.Log($"{playerName} are you quitting so fast 🤔, chose reasonable value 🤨");
            else if (health == 100)
                Debug.Log($"{playerName} you already have full life and you ask for more 🫤");
            else if (health + amount >=0 || health + amount <= 100){
                health += amount;
                Debug.Log($"You\'re current life points are {health}, Keep it up soldier 🫡");
            }
        }

        public void Heal (bool fullRestore){
            if(fullRestore)
                health = 100;
                Debug.Log($"{playerName} you\'re health has been fully restored, Keep it up soldier 🫡");
        }

        public static void ShowPlayerCount(){
            Debug.Log("There are " + playerCount + " Plyers in this game");
        }


    }
}