using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    [SerializeField] public int tileCountX,tileCountY,tileSize;
    [SerializeField] public GameObject tilePrefab;
    // Start is called before the first frame update
    private Dictionary<Vector2, GameObject> tileDictionary = new Dictionary<Vector2, GameObject>();
    void Start()
    {
        initializeTiles();        
    }
    void initializeTiles()
    {
        for (int i=0; i<tileCountX;i++)
        {
            for (int j = 0; j < tileCountY; j++)
            {
                if (tileDictionary.ContainsKey(new Vector2(i,j)) ==false)//this function should be able to be expanded upon
                {
                    Vector2 currVect = new Vector2(i,j);
                    GameObject currTile = Instantiate(tilePrefab,new Vector3(i * tileSize,j * tileSize,0),Quaternion.identity);
                    TileScript currScript = currTile.GetComponent<TileScript>();
                    currScript.init(currVect);
                    tileDictionary[currVect] = currTile;
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
