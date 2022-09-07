using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    float t;
    public float timeToSwitch;
    public bool turnon;

    //Mat1 is the enabled color, Mat2 is the diabled color
    public Material Mat1;
    public Material Mat2;

    BoxCollider2D bc;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();

        sr = GetComponent<SpriteRenderer>();

        if (gameObject.CompareTag("Object2"))
        {
            t += timeToSwitch;
            turnon = false;
        }
        else
        {
            turnon = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

    if (turnon == true)
        {
            bc.enabled = true;
            sr.material = Mat1;
            if (t > timeToSwitch)
            {
                Debug.Log("Turn Off");
                turnon = false;
                t = 0;
            }
        }

    if (turnon == false)
        {
            bc.enabled = false;
            sr.material = Mat2;
            if (t > timeToSwitch)
            {
                Debug.Log("Turn On");
                turnon = true;
                t = 0;
            }
        }           
    }
}
