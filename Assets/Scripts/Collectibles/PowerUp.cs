using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{ 
    public GameObject thePlayer;
    public GameObject levelControl;
    public GameObject coin;
    public static bool creatingCoin = true;
    float z;
    float x;
    float y;
    float z1;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMovement>().moveSpeed = -20;
        levelControl.GetComponent<LevelDistance>().disDelay = 0.05F;

        CollectibleControl.coinCount += 10;

        new WaitForSeconds(7);
        thePlayer.GetComponent<PlayerMovement>().moveSpeed = -3;
        levelControl.GetComponent<LevelDistance>().disDelay = 0.35F;
        //PlayerMovement.moveSpeed = -3;
        //LevelDistance.disDelay = 0.35f;
        GenerateCoin.creatingCoin = true;


    }
}
