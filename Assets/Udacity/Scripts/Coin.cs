using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        GameObject poof = (GameObject) Instantiate(coinPoof, transform.position, Quaternion.identity); 
        poof.transform.Rotate(-90f, 0f, 0f);
        // Make sure the poof animates vertically

        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);

    }

}
