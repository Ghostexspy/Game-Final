using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    private bool isFollowing;

    public float followSpeed;

    public Transform followTarget;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update() 
    {
        if(isFollowing)  //The "key" will follow the player
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="Player") //Checks if the player has interacted with the "key"
        {
            if(!isFollowing)
            {
                PlayerController mainCharacter = FindObjectOfType<PlayerController>();
                followTarget = mainCharacter.keyOffsetPoint;   
                isFollowing = true;   
                mainCharacter.followingKey=this;

            }
        }
    }
}
