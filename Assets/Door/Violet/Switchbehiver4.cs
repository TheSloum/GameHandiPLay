using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchbehiver4 : MonoBehaviour
{
    [SerializeField] Doorbehive4 _doorBehiver; 

    public List<Doorbehive4> _doorBehivers;

    [SerializeField] bool _isDoorOpenSwitch;
    [SerializeField] bool _isDoorCloseSwitch;

    float _switchSizeY;
    Vector3 _switchUpPos;
    Vector3 _switchDownPos;
    float  _switchSpeed = 1f;
    float _switchDelay = 0.2f;
    bool _isPressingSwitch = false;

    // Start is called before the first frame update
    void Awake()
    {
        _switchSizeY = transform.localScale.y  ;
       _switchDownPos  = transform.position ;
        _switchUpPos = new Vector3(transform.position.x, transform.position.y - _switchSizeY, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
         if (_isPressingSwitch)
        {
           MoveSwitchDown();
         }
         else if(!_isPressingSwitch)   
        {
           MoveSwitchUp();
         }
    }

    void MoveSwitchDown()
    {
        if (transform.position != _switchDownPos)
        {
         transform.position = Vector3.MoveTowards(transform.position,_switchDownPos , _switchSpeed * Time.deltaTime);
        }
    }

    void MoveSwitchUp()
    {
        if (transform.position != _switchUpPos)
        {
         transform.position = Vector3.MoveTowards(transform.position, _switchUpPos, _switchSpeed * Time.deltaTime);
        }
    }
    

       



    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "Player")
        {
            _isPressingSwitch = !_isPressingSwitch;

            if (_isDoorOpenSwitch && !_doorBehiver. _isDoorOpen)
            {
                 foreach (Doorbehive4 currentDB in _doorBehivers) {
             currentDB._isDoorOpen = !currentDB._isDoorOpen;
        }
                
            }
            else if (_isDoorCloseSwitch && _doorBehiver._isDoorOpen)
            {
                 foreach (Doorbehive4 currentDB in _doorBehivers) {
             currentDB._isDoorOpen = !currentDB._isDoorOpen;
        }
                
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(SwitchUpDelay(_switchDelay));
        }
    }

    IEnumerator SwitchUpDelay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        _isPressingSwitch = false;
    }
}

