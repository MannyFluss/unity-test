using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public SpriteRenderer tileSprite;
    [SerializeField] static int width; 
    private Vector2 position;
    public bool occupied = false;
    // Start is called before the first frame update
    public void init(Vector2 _pos)
    {
        position = _pos;
        bool checkered = (position.x % 2 == 0 && position.y % 2 != 0) || (position.x % 2 != 0 && position.y % 2 == 0);
        if (checkered)
        {
            tileSprite.color = new Color(.5f,.5f,.5f,1f);
        }
    }
    void Start()
    {
        
    }

    public void createBuilding(GameObject building)
    {
        if (occupied){return;}
        occupied = true;
        Vector3 location = new Vector3(transform.position.x,transform.position.y,0);
        Instantiate(building, location ,Quaternion.identity);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
