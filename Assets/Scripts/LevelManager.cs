using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tile;

    public static int[,] map;
    public static Vector3 START_POINT = new Vector3(0, 0, 0);
    public static Vector3 END_POINT = new Vector3(13, 7, 0);

    public float TileSize
    {
        get { return tile[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x; }
    }

    // Start is called before the first frame update
    void Start()
    {
        map = new int[,]
        {
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
        };
        fillTiles();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void fillTiles()
    {
        for (int y = 1; y > -9; y--)
        {
            for (int x = -1; x < 15; x++)
            {
                spawnTile(x, y);
            }
        }
    }

    private void spawnTile(int x, int y)
    {
        Debug.Log("x=" + x + " y=" + y);
        int type = 0;
        if (x < 0 || y > 0 || x > 13 || y < -7)
        {
            type = 0;
            Instantiate(tile[type], new Vector3(x * TileSize, y * TileSize, 0), Quaternion.identity);
            return;
        }

        type = map[y*-1, x];
        Instantiate(tile[type], new Vector3(x * TileSize, y * TileSize, 0), Quaternion.identity);

    }
}
