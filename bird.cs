using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public scorescript logic;
    public Rigidbody2D myRigidbody;
    public float flappingStrenght;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<scorescript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for touch input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * flappingStrenght;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
    }

    public void FixedUpdate()
    {
        if (myRigidbody.transform.position.y < -26)
        {
            logic.gameover();
                
            }
            }
}
