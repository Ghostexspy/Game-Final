using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;
    
    float horizontal;
    float vertical;

    public Transform keyOffsetPoint;

    Rigidbody2D rigidbody2d;

    Animator animator;

    public KeyManager followingKey;

    [SerializeField]
    GameObject player;


    Vector2 lookDirection = new Vector2(1, 0);
    public Vector2 Checkpoint;


    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Checkpoint = rigidbody2d.position;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 move = new Vector2(horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }
        animator.SetFloat("Look X", lookDirection.x);
        animator.SetFloat("Look Y", lookDirection.y);
        animator.SetFloat("Speed", move.magnitude);

    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }

    public void Capture()
    {
       // Destroy(gameObject, 1f);
        StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {
        Destroy(gameObject, 1.25f);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("Main Scene");
    }

}
