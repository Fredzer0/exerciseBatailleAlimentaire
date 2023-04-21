using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject tarte;
    [SerializeField] private float frequency = 2f;

    void Start()
    {
        InvokeRepeating("CreateTarte", frequency, frequency);
    }


    void CreateTarte()
    {
        float x = Random.Range(-5, 5);
        Instantiate(tarte, new Vector3(transform.position.x + x, transform.position.y, transform.position.z) , Quaternion.identity);
    }
}
