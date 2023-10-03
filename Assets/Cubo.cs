using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public Transform target;
            public float speed;
            public float xTilt;

    
    // Start is called before the first frame update
    void Start()
    {
        if (target != null) return;

        target = gameObject.transform;
        Debug.Log("Target nao especificado, padronizando para o proprio objeto.");   
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.position, new Vector3(xTilt, 1, 2), speed * Time.deltaTime);
  
    }
}
