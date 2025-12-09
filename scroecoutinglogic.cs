using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroecoutinglogic : MonoBehaviour
{

    public scorescript logic;
    //poblic Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<scorescript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
 logic.addscore();
    }
}



