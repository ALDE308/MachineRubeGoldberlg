using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverX : MonoBehaviour
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
        yield return new WaitForSeconds(8);
        this.transform.Rotate(0, speed, 0, Space.Self);
        //Debug.Log("Si funciona");
    }
}
