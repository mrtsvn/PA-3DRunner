using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class checkCollisions : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI CoinText;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Coin"))
        {
            //Debug.Log("Coin!");
            AddCoin();
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
        }

        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("Zort");
        }

    }

    public void AddCoin()
    {
        score++;
        CoinText.text = "Score: " + score.ToString();
         
    }



}
