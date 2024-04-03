using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDataStructure : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int mapSize = 10000;
        float begin = Time.realtimeSinceStartup;
        initializeMapVia1DArray(mapSize);
        float end = Time.realtimeSinceStartup;
        Debug.Log("1D array took: " + (end-begin));

        begin = Time.realtimeSinceStartup;
        initializeMapVia2DArray(mapSize);
        end = Time.realtimeSinceStartup;
        Debug.Log("2D array took: " + (end - begin));
        /*
        begin = Time.realtimeSinceStartup;
        initializeMapViaDictionary(mapSize);
        end = Time.realtimeSinceStartup;
        Debug.Log("Dictionary array took: " + (end - begin));
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// initialize map data using dictionary of vectorint to int
    /// </summary>
    /// <param name="mapSize"></param>
    private void initializeMapViaDictionary(int mapSize)
    {
        Dictionary<Vector2Int, int> mapData = new Dictionary<Vector2Int, int>();
        
        int x = 0, y = 0;
        while (x < mapSize)
        {   
            while (y < mapSize)
            {
                mapData.Add(new Vector2Int(x, y), 1);
                y++;
            }
            x++;
            y = 0;
        }
    }

    /// <summary>
    /// Initialize data using 1D array
    /// </summary>
    /// <param name="mapSize"></param>
    private void initializeMapVia1DArray(int mapSize)
    {
        int[] mapData = new int[mapSize * mapSize];
        for(int i = 0; i < mapSize * mapSize; i++)
        {
            mapData[i] = 1;
        }
    }

    /// <summary>
    /// initialize data using 2D array
    /// </summary>
    /// <param name="mapSize"></param>
    private void initializeMapVia2DArray(int mapSize)
    {
        int[][] mapData = new int[mapSize][];
        for (int i = 0; i < mapSize; i++)
        {
            mapData[i] = new int[mapSize];
            for(int j = 0; j < mapSize; j++)
            {
                mapData[i][j] = 1;
            }
        }
    }
}
