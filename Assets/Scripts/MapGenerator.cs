using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public int width;
    public int height;
    
    [Range(0, 100)]
    public int randomFillPercent;
    
    
    int[,] map;


    void Start()
    {
        map = new int[width, height];       
    }

}
