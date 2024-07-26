using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    IEnumerator IERotate()
    {
        transform.Rotate(new Vector3(0, 1, 0));

        yield return new WaitForSeconds(0.1f);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(IERotate());
    }
}
