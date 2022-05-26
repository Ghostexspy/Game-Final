using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    private PlayerController Player;

    public SpriteRenderer spriteRen;
    public Sprite doorOpenSprite;

    public bool doorOpen, waitingToOpen;



    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waitingToOpen)
        {
            if (Vector3.Distance(Player.followingKey.transform.position, transform.position) < 0.1) //When the "key" interacts with the door trigger, the key will open the door and disappear
            {
                waitingToOpen = false;
                doorOpen = true;
                Destroy(gameObject);
                spriteRen.sprite = doorOpenSprite;

                Player.followingKey.gameObject.SetActive(false);
                Player.followingKey = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player") //Changes "key" follow target to door
        {
            if(Player.followingKey != null) 
            {
                Player.followingKey.followTarget = transform;
                waitingToOpen = true;
            }
        }
    }
}
