using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 3.0f;

    public float size = 19.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);

        if(transform.position.x < -size)
        {
            transform.Translate(new Vector3(size * 2, 0, 0));
        }
    }
}
