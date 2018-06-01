using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Valve.VR;

public class Spawner : MonoBehaviour {
    private GameObject spawnpoint;
    public GameObject Block;
    private Chain bc;
    public GameObject gs;


    // Use this for initialization
    void Start () {
        spawnpoint = new GameObject();
        spawnpoint.transform.position = this.transform.position;
        spawnpoint.transform.rotation = this.transform.rotation;
        bc = gs.GetComponent<Chain>();
        Newblock();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.Newblock();
        }
	}

    public void Newblock()
    {
        transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z);
        GameObject blocklet = (GameObject)Instantiate(Block, spawnpoint.transform.position, spawnpoint.transform.rotation);
        blocklet.transform.parent = this.transform;
        bc.addNext();
        blocklet.transform.Find("Canvas/ID").GetComponent<TextMesh>().text = randomGen(15);
        blocklet.transform.Find("Canvas/Payload").GetComponent<TextMesh>().text = bc.head.payload;
    }

    private string randomGen(int length)
    {
        System.Random rand = new System.Random();
        const string chars = "ABCDEF0123456789";
        return new string(Enumerable.Repeat(chars, length).Select(s => s[rand.Next(s.Length)]).ToArray());
    }
}