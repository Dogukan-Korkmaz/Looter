using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    private float hiz = 0.0001f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        x += Time.deltaTime * hiz;
        y += Time.deltaTime * hiz;

        transform.Translate(x, 0f, y);
    }
}
