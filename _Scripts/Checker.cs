using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour {
    public int id;
    private Chain bc;
    public GameObject gs;
    public GameObject Spawn;

    // Use this for initialization
	void Start () {
        bc = gs.GetComponent<Chain>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Dummy method to check
    private bool blockCheck(GameObject go)
    {
        if(int.Parse(go.GetComponentInChildren<TextMesh>().text) == bc.currID)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "guess")
        {
            if(blockCheck(collision.gameObject))
            {
                collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                collision.gameObject.transform.position = this.transform.position;
                collision.gameObject.transform.rotation = this.transform.rotation;
                Miner.haveGuess--;
                Spawn.GetComponent<Spawner>().Newblock();
            }
            else
            {
                collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                Miner.haveGuess--;
            }
        }
    }
}
