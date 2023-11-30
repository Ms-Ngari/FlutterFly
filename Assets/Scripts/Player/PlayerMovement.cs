using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = -3;
    public float leftRightSpeed = 4;
    static public bool canMove = false;

    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward, Space.World);
        if (canMove == true)
        {

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.rightSide)
                {
                    transform.Translate(leftRightSpeed * Time.deltaTime * Vector3.left);
                }
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.leftSide)
                {
                    transform.Translate(leftRightSpeed * -1 * Time.deltaTime * Vector3.left);
                }
            }
        }
    }
}
