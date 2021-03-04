using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private Text scoreText;
    public float moveSpeed, jumpForce;
    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D myCollider;
    private Rigidbody2D rb;

    

    //private bool facingRight = true;
    //private float moveDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }


    private void Awake()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

 

    void Update()
    {
        
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }    
        }
        playerData.score += (int)(Time.deltaTime * 100f);
        scoreText.text = playerData.score.ToString("D5");
        // Get inputs
        //moveDirection = Input.GetAxisRaw("Horizontal"); // Scale of -1 -> 1.
        // Move
        //rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectable"))
        {
            ItemBase item = collision.GetComponent<ItemBase>();
            item.OnCollect(playerData);
        }
    }
}
[System.Serializable]
public class PlayerData
{
    public float moveSpeed, jumpForce;
    [HideInInspector] public int score;
}
