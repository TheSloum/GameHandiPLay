using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakDetect : MonoBehaviour
{
    
    public BoxCollider2D bc2D;
    public float raycastDistance = 5f;
    [SerializeField] private LayerMask playerLayerMask;
    public Rigidbody2D playerrb2D;
    public Rigidbody2D leftplank;
    public Rigidbody2D rightplank;

    private float speedy = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
            leftplank.simulated = false;
            rightplank.simulated = false;
            bc2D.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        speedy = playerrb2D.velocity.y;
        if (Break() && speedy < -18){
            bc2D.enabled = false;
            leftplank.simulated = true;
            rightplank.simulated = true;
        }
        Break();
    }
    private bool Break(){
        RaycastHit2D hit = Physics2D.BoxCast(bc2D.bounds.center, bc2D.bounds.size,0f, Vector2.up, raycastDistance, playerLayerMask);
        return hit.collider != null;
    }
}
