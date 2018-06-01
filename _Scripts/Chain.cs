using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour {

    public Block head;
    public int currID;
    
    public Chain()
    {
        this.head = null;

    }

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addNext()
    {
        Block b = new Block();
        if(this.head == null)
        {
            this.head = b;
        }
        else
        {
            b.setNext(this.head);
            this.head = b;
            this.currID = b.genID;
        }
    }
}
