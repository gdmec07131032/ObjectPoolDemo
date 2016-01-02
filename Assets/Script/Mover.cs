using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed = 10;
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(h, v, 0);
    }
}
