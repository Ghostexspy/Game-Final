using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    void Awake()
    {
        Instance = this;
    }

    public Sprite Scissors;
    public Sprite Keys;
    public Sprite Toothbrush;
    public Sprite Sharp_Toothbrush;

}
