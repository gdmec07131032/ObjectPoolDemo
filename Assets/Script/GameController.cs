using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject cubePrefab;
    public int rowNum = 6;
    public int colNum = 10;


	// Use this for initialization
    void Start()
    {
        for (int rowIndex = 0; rowIndex < rowNum; rowIndex++)
        {
            for (int colIndex = 0; colIndex < colNum; colIndex++)
            {
                GameObject o = Instantiate(cubePrefab) as GameObject;
                Cube cube = o.GetComponent<Cube>();
                cube.SetPosition(colIndex, rowIndex);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
