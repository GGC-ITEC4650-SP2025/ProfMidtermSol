using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 20; i++) {
            Vector3 p = new Vector3(Random.Range(-8f, 8f), 0, Random.Range(5f, 20f));
            GameObject g = Instantiate(prefab, p, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
