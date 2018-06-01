using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner : MonoBehaviour {
    public GameObject Guess;
    public static int haveGuess;
    public GameObject workTable;
    public GameObject Player;
	
    // Use this for initialization
	void Start () {
        haveGuess = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
	if(this.transform.position.y <= -5)
        {
            this.transform.position = workTable.transform.position;
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Boulder" && haveGuess <= 5)
        {
            //spawn the guess
            GameObject guessette = Instantiate(Guess, this.Player.transform);
            //Set Guess text;
            System.Random rand = new System.Random();
            guessette.GetComponentInChildren<TextMesh>().text = "" + rand.Next(0, 10);
            //TODO
            haveGuess += 1;
            Debug.Log("We hit it!");
        }
    }
}
