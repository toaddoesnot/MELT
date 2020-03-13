using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTransparence : MonoBehaviour
{
    public float waiting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(FallTimer());
        }
    }

    IEnumerator FallTimer()
    {
        GetComponent<EdgeCollider2D>().enabled = false;
        GetComponent<Rigidbody2D>().gravityScale += 4;
        yield return new WaitForSeconds(waiting);
        GetComponent<EdgeCollider2D>().enabled = true;
        GetComponent<Rigidbody2D>().gravityScale -= 4;
    }
}
