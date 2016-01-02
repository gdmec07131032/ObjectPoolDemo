using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    public float xOff = -4.5f;
    public float yOff = 0.5f;

    public void SetPosition(int colIndex, int rowIndex)
    {
        transform.position = new Vector3(colIndex * 1+xOff, rowIndex * 1+yOff, 0);
    }
}
