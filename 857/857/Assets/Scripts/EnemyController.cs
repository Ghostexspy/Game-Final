using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public bool vertical;
    public float change = 3.0f;

    Rigidbody2D rigidBody2D;
    Animator anim;
    int direction = 1;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 position = rigidBody2D.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
            anim.SetFloat("MoveX", 0);
            anim.SetFloat("MoveY", direction);
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
            anim.SetFloat("MoveX", direction);
            anim.SetFloat("MoveY", 0);
        }

        rigidBody2D.MovePosition(position);
    }

}

