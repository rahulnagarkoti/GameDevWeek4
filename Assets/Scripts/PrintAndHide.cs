using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i=0;    

    // Start is called before the first frame update
    void Start()
    {
        i=3;
       
    }

    // Update is called once per frame
    void Update()
    {
        i++;
         if(gameObject.tag == "Red" && i == 100)
            gameObject.SetActive(false);

        int randomInt = Random.Range(200, 251);
        if(gameObject.tag == "Blue" && i == randomInt)
            rend.enabled = false;
        Debug.Log( gameObject.name+":"+ i.ToString());
    }
}
