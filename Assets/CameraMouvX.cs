using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraMouvX : MonoBehaviour
{
    public float minX = -5.34f;
    public float maxX = 6.45f;
    public float cameraSpeed = 2f;
    public Transform playerTransform;
    public Transform camTransform;
    public PolygonCollider2D cam;
    private float targetX = 0f;
    public float maxO = 11.7f;
    public float minO = 0f;
    public float minS = 0f;
    public float maxS = 0f;
    public CinemachineVirtualCamera vcam;


    
float map(float s, float a1, float a2, float b1, float b2)
{
    return (a2 + (s-a1)*(b2-a2)/(b1-a1));
}

    void LateUpdate()
    {

        // Get the current camera position
        
        Vector3 currentPos = transform.position;
        // Calculate the target Y position based on the player's position
        float targetX = Mathf.Clamp(playerTransform.position.x, minX, maxX);

        // Lerp the camera towards the target Y position
        currentPos.x = Mathf.Lerp(currentPos.x, targetX, cameraSpeed * Time.deltaTime);

        // Update the camera position
        cam.offset = new Vector2(map(targetX, minX,minO, maxX, maxO),0f);
        vcam.m_Lens.OrthographicSize = map(targetX, minX,minS, maxX, maxS);
    }
    

 
   
}
