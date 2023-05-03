using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    public int loadedNumber;


    // Start is called before the first frame update
    void Start()
    {

        loadedNumber = PlayerPrefs.GetInt("Scene");

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            
            SceneManager.LoadScene(loadedNumber);
        }
    }
}
