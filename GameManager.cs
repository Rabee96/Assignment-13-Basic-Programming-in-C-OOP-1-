using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSpace;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();
        player1.InitializePlayer("Batman",70);
        player2.InitializePlayer("Joker",50);

        player1.Heal(90);
        
        player2.Heal(0);
        player2.Heal(-20);

        Debug.Log(player1.PlayerName);
        player1.Heal(50);
        Debug.Log(player2.PlayerName);
        player2.Heal(20);
        
        player2.Heal(true);
        Player.ShowPlayerCount();


    }
}
