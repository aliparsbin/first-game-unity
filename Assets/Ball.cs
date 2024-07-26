using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    float horizontal, vertical;
    public float speed = 20f;
    Rigidbody rigid_body;
    

    int counter = 0;

    public Text textScore;

    void Move()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


        rigid_body.AddForce(new Vector3(horizontal * speed, 0, vertical * speed));

        
    }


    // Start is called before the first frame update
    void Start()
    {
        rigid_body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("cube"))
        {
            Destroy(other.gameObject);

            counter++;

            textScore.text = counter.ToString();

        }
    }
}
