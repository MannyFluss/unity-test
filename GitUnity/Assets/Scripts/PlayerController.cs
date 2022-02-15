using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject defaultBuilding;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseClick();
        }
    }

    void mouseClick()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePos,Vector2.zero,0);
        
        if (hit.collider != null)
        {
            TileScript tileScript = hit.collider.GetComponent<TileScript>();
            if (tileScript!=null)//we have clicked on a tile
            {
                tileScript.createBuilding(defaultBuilding);
                print("wahoo");
            }
        }
    }

}
