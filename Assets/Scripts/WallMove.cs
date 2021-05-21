using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public int moveSpeed;
    public float minY;
    public float maxY;

    public float oldPosition;
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        moveSpeed = 2;
        oldPosition = 10;
        minY = -1;
        maxY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("ResetWall"))
            obj.transform.position = new Vector3(oldPosition, Random.Range(minY, maxY + 5), 0);
    }
}
