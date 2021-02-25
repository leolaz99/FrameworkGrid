using UnityEngine;

namespace LLFramework
{ 
    public class GridBase : MonoBehaviour
    {
        public Vector2Int mapSize;
        public TileBase[,] tile;
        int cont = 0;

        public virtual void GenerateMap(TileBase tilebase)
        {
            tile = new TileBase[mapSize.x, mapSize.y];

            for (int i = 0; i < mapSize.x; i++)
            {
                for (int j = 0; j < mapSize.y; j++)
                {
                    tile[i, j] = Instantiate(tilebase, new Vector3(i, 0, j), transform.rotation);
                    tile[i, j].x = i;
                    tile[i, j].y = j;
                    tile[i, j].id = cont++;
                }
            }           
        }
    }
}