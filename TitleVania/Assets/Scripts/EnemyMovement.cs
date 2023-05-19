using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidyBody;

    void Start()
    {
        myRigidyBody = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        myRigidyBody.velocity = new Vector2(moveSpeed, 0f);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        moveSpeed = -moveSpeed;
        FlipEnemyFacing();
    }

    void FlipEnemyFacing()
    {

            transform.localScale = new Vector2(-(Mathf.Sign(myRigidyBody.velocity.x)), 1f);


    }

}
