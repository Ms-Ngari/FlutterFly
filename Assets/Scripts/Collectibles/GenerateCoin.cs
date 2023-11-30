using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCoin : MonoBehaviour
{
    public GameObject coin;
    public GameObject thePlayer;
    public static bool creatingCoin = true;
    float z;
    float x;
    float y;
    float z1;

    void Update()
    {
        if (creatingCoin == false)
        {
            creatingCoin = true;
            float x = thePlayer.transform.position.x;
            float y = thePlayer.transform.position.y;
            float z1 = thePlayer.transform.position.z;
            StartCoroutine(GenerateCoinCo());
        }

    }
    IEnumerator GenerateCoinCo()
    {
        z = z1 + 0.05f;
        Instantiate(coin, new Vector3(x, y, z), Quaternion.identity);
        yield return new WaitForSeconds(0.25f);
        creatingCoin = false;


    }
}
