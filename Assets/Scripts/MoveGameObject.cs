using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 3, 0);
    }

    void OnMouseDown()
    {
       /* float duration = 200000;
        float t = 0.0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            transform.Rotate(0, 3, 0);
        }*/
    }
}
