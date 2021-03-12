using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    private Vector3 offset;
    public GameObject player;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        offset = player.transform.position - cam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = player.transform.position - offset;
    }
}
