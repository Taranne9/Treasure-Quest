using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntoscoin : MonoBehaviour

    
{

    public int Puntossumados;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("Reward") && other.CompareTag("Player"))
        {
            other.GetComponent<ControlPlayer>().Sumarpuntaje(Puntossumados);
            Destroy(gameObject);
        }
    }
}
