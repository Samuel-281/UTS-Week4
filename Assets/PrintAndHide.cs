using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    int i = 3;
    public Renderer rend;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red"){
            if (i == 100)
            {
                gameObject.SetActive(false);  
            }
        }

        if (gameObject.tag == "Blue")
        {
            if (i == Random.Range(200,251))
            {
                rend.enabled = false;
            }
        }
    }
}
