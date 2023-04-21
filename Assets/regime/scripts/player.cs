using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rig;
    private Collider2D col;
    private Vector2 mouvementFleche;
    private Vector2 lastDirection;
    public float vitesse;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        mouvementFleche = Vector2.zero;
        col = GetComponent<Collider2D>();
    }

    void Update()
    {
        mouvementFleche.x = Input.GetAxisRaw("Horizontal");
        mouvementFleche.y = Input.GetAxisRaw("Vertical");
    }

    // compensate for drag and mass
    private float calculate_force(float speed)
    {
       return vitesse * rig.drag * rig.mass;
    }

    void FixedUpdate()
    {
        float vel = rig.velocity.magnitude;

        if (vel >= 0.01)
        {
            lastDirection = rig.velocity;        
        }
        else if (lastDirection.magnitude > 0.1)
        {
            lastDirection = lastDirection.normalized * 0.05f;       
        }

    }

}
