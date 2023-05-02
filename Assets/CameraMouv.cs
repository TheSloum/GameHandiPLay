using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouv : MonoBehaviour
{
    public float minY = -5.34f;
    public float maxY = 6.45f;
    public float cameraSpeed = 2f;
    public Transform playerTransform;
    public Transform camTransform;
    public PolygonCollider2D cam;
    private float targetY = 0f;
    public float maxO = 11.7f;
    public float minO = 0f;


    
float map(float s, float a1, float a2, float b1, float b2)
{
    return (a2 + (s-a1)*(b2-a2)/(b1-a1));
}

    void LateUpdate()
    {

        // Get the current camera position
        
        Vector3 currentPos = transform.position;
        // Calculate the target Y position based on the player's position
        float targetY = Mathf.Clamp(playerTransform.position.y, minY, maxY);

        // Lerp the camera towards the target Y position
        currentPos.y = Mathf.Lerp(currentPos.y, targetY, cameraSpeed * Time.deltaTime);

        // Update the camera position
        cam.offset = new Vector2(0f,map(targetY, minY,minO, maxY, maxO));
    }
    

 
   
}
