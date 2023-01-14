using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHorizontalMovimentBehaviour : MonoBehaviour
{
    public float speed = 0.5f;
    public float paddleLimit = 6.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentPosition.x += speed;

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentPosition.x -= speed;
        }

        if (currentPosition.x >  (paddleLimit + speed) && currentPosition.x < (paddleLimit - speed))
        {
            transform.position = currentPosition;
        }
    }
}
