using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) //If another GameObject with a 2D Collider on it hits this GameObject's collider
    {
        PlayerController.instance.coins++; //increase the player's score using the Singleton!
        Debug.Log("Score: " + PlayerController.instance.coins); //print the score to console, using the Singleton
        source.Play();
        Destroy(gameObject);
    }
}