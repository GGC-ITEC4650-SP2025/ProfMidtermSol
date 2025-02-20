using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinShooter : MonoBehaviour
{
    //Components Connected to the same gameObject as this one.

    //Components Connected to other gameObjects.
    Transform crossHairTran;
    Text shotsText;

    //public properties
    public GameObject coinPrefab;
    public float shotspeed;

    //private properties
    private int shotsLeft = 10;

    // Start is called before the first frame update
    void Start()
    {
        crossHairTran = GameObject.Find("CrossHair").transform;
        shotsText = GameObject.Find("Shots").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && shotsLeft > 0)
        {
            shotsLeft--;
            shotsText.text = "Shots: " + shotsLeft;
            GameObject g = Instantiate(coinPrefab);
            g.transform.position = transform.position;
            Vector3 v = (crossHairTran.position - transform.position);
            g.GetComponent<Rigidbody>().velocity = v.normalized * shotspeed;
        }
    }
}
