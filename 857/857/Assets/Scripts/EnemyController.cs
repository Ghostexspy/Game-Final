using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class EnemyController : MonoBehaviour
{
    [SerializeField]
    float speed;
    public bool vertical;
    public float changeTime = 3.0f;

    Rigidbody2D rigidBody2D;
    Animator anim;

    float timer;
    int direction = 1;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        timer = changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }

    private void FixedUpdate()
    {
        Vector2 position = rigidBody2D.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
            anim.SetFloat("Move X", 0);
            anim.SetFloat("Move Y", direction);
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction; 
            anim.SetFloat("Move X", direction);
            anim.SetFloat("Move Y", 0);
        }

        rigidBody2D.MovePosition(position);
    }

}

