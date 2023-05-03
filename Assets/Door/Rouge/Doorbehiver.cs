using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorbehiver : MonoBehaviour
{
    public bool _isDoorOpen = false;
     Vector3 _doorClosedPos;
     Vector3 _doorOpendPos;
     float _doorSpeed = 10f;

    // Start is called before the first frame update
    void Awake()
    {
        _doorClosedPos = transform.position;
        _doorOpendPos = new Vector3(transform.position.x + 2.5f,transform.position.y,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (_isDoorOpen)
        {
           OpenDoor();
         }
         else if(!_isDoorOpen)   
        {
           CloseDoor();
         }
     }

     void OpenDoor()
     {
        if (transform.position != _doorOpendPos)
        {
         transform.position = Vector3.MoveTowards(transform.position, _doorOpendPos , _doorSpeed * Time.deltaTime);
        }
        if (_isDoorOpen)
        {
      }
     }
     void CloseDoor()
     {
        if (transform.position != _doorClosedPos)
        {
         transform.position = Vector3.MoveTowards(transform.position, _doorClosedPos , _doorSpeed * Time.deltaTime);
        }
     }

}