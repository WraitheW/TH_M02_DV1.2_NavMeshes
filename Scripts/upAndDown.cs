using UnityEngine;
using System.Collections;

public class upAndDown : MonoBehaviour
{

    //adjust this to change speed
    float speed = 1.5f;
    //adjust this to change how high it goes
    public float height = .25f;
    public float z = .001f;

    Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        transform.Rotate(new Vector3(0, z, 0));
    }
}