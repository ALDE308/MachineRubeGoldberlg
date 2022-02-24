using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover3 : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Esperar");
    }

    IEnumerator Esperar(){
        yield return new WaitForSeconds(22);
        this.transform.Rotate(0, speed, 0, Space.Self);
        //Debug.Log("Si funciona");
    }
}
