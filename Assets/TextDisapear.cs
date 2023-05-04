using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisapear : MonoBehaviour
{

    public int loadedNumber;
    public GameObject textDisapear;

    // Start is called before the first frame update
    void Start()
    {
        loadedNumber = PlayerPrefs.GetInt("Scene");
    }

    // Update is called once per frame
    void Update()
    {
        if (loadedNumber == 1)
        {
            textDisapear.SetActive(false);
        }

       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ChangeScene")
        {
            
            textDisapear.SetActive(false);
        }
    }
}
