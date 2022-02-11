using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public SpriteRenderer tileSprite;
    [SerializeField] static int width; 
    private Vector2 position;
    // Start is called before the first frame update
    public void init(Vector2 _pos)
    {
        position = _pos;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
