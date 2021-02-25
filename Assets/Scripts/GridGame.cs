using LLFramework;
using UnityEngine;


[System.Serializable]
public struct Mod
{
    public Vector2Int position;
    public Type type;
}

public enum Type
{
    Hole,
    Wall,  
}

public class GridGame : GridBase
{
    public TileGame prefabFloor;
    [SerializeField] GameObject prefabHole;
    [SerializeField] GameObject prefabWall;
    [SerializeField] Mod[] mods;

    
    public override void GenerateMap(TileBase tilebase)
    {     
        base.GenerateMap(tilebase);
        
        for (int i = 0; i < mapSize.x; i++)
        {
            for (int j = 0; j < mapSize.y; j++)
            {
                if (j == 0)
                    Instantiate(prefabWall, new Vector3(i , 0, j - 1), transform.rotation);
        
                if (i == 0)
                    Instantiate(prefabWall, new Vector3(i - 1, 0, j), transform.rotation);
        
                if (j == mapSize.y - 1)
                    Instantiate(prefabWall, new Vector3(i, 0, j + 1), transform.rotation);
                
                if (i == mapSize.x - 1)
                   Instantiate(prefabWall, new Vector3(i + 1, 0, j), transform.rotation);
        
                for (int c = 0; c < mods.Length; c++)
                {
                    if (mods[c].position.x == i && mods[c].position.y == j)
                    {
                        if (mods[c].type == Type.Hole)
                        {
                            DestroyImmediate(tile[i, j].gameObject);
                            tile[i, j] = Instantiate(prefabHole, new Vector3(i, 0, j), transform.rotation).GetComponent<TileBase>();
                        }
         
                        if (mods[c].type == Type.Wall)
                        {
                            DestroyImmediate(tile[i, j].gameObject);
                            tile[i, j] = Instantiate(prefabWall, new Vector3(i, 0, j), transform.rotation).GetComponent<TileBase>();
                        }
                    }
                }      
            }
        }
    }
}