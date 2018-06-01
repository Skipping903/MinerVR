using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public int genID;
    public string payload;
    public Block nextBlock;
    public Block prevBlock;
    
    public Block()
    {
        this.generate();
        nextBlock = null;
    }
    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void generate()
    {
        string[] names = new string[10];
        string[] adjectives = new string[10];
        names[0] = "Bob";
        names[1] = "John";
        names[2] = "Jack";
        names[3] = "Suzy";
        names[4] = "Sally";
        names[5] = "Brock";
        names[6] = "Kiki";
        names[7] = "Peter";
        names[8] = "Digiornio";
        names[9] = "Kelly";

        adjectives[0] = "big";
        adjectives[1] = "smart";
        adjectives[2] = "short";
        adjectives[3] = "small";
        adjectives[4] = "heavy";
        adjectives[5] = "light";
        adjectives[6] = "fast";
        adjectives[7] = "slow";
        adjectives[8] = "angry";
        adjectives[9] = "slow";

        System.Random rand = new System.Random();
        string ans = names[rand.Next(0,10)] + " is " + adjectives[rand.Next(0,10)];
        payload = ans;
        genID = rand.Next(0, 10);
    }

    public void addBlock(Block nextBlock)
    {
        if (this.nextBlock == null)
        {
            this.nextBlock = nextBlock;
        }
        else
        {
            Block temp = new Block();
            temp.setNext(nextBlock);
        }
    }
    public void setNext(Block b)
    {
        this.nextBlock = b;
    }
}
