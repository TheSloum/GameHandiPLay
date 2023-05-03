using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
 
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Scene", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
            PlayerPrefs.SetInt("Scene", 1);

        }
    }

    
    
}
