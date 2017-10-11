using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour
{
    public float speed; 

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < -29.1f)
        {
            transform.position = new Vector2(0, 0);
        }
    }
}