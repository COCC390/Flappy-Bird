using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float range;
    public int moveSpeed;

    private GameObject obj;
    private Vector3 oldPosition;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;
        range = 27.2f;
        moveSpeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));

        if(Vector3.Distance(oldPosition, obj.transform.position) > range)
            obj.transform.position = oldPosition;
    }
}
