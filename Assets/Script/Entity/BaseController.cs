using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D rb2d;

    [SerializeField] private SpriteRenderer characterRenderer;
    
    

    protected Vector2 moveDirection= Vector2.zero;
    public Vector2 MoveDirection { get { return moveDirection; } }

    protected Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get { return lookDirection; } }

    

    protected virtual void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }



    protected virtual void Start()
    {

    }


    
    protected virtual void Update()
    {
        //HandleAction();
        Rotate(lookDirection);
    }



    protected virtual void  FixedUpdate()
    {
        Movement(moveDirection);
    }

    private void Movement(Vector2 direction)
    {
        direction = direction*2; //statHandler.Speed;

        rb2d.velocity = direction; 


    }

    private void Rotate(Vector2 direction) 
    { 
      float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       bool isFlipped = Mathf.Abs(angle) > 90f;
        characterRenderer.flipX = isFlipped;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Object"))
        {
             // 플레이어가 접근하면 팝업 표시
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Object"))
        {
             // 플레이어가 벗어나면 팝업 숨김
        }
    }
}
