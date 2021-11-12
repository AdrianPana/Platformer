using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public int score;

    public Rigidbody2D rb;

    private Animator anim;

    public int progress;

    public bool canJump = false;

    public Text scoreText;

    float jumpTimer = 0f;

    public GameObject finishMenu;
    public GameObject deathMenu;

    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        progress = GameObject.FindWithTag("Progress").GetComponent<ProgressScript>().progress;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();

        CorrectJump();

        Move();

    }

    void Move()
    {
        float xInput = Input.GetAxis("Horizontal");

        if (Mathf.Abs(xInput) > .01f) anim.SetBool("isRunning", true);
        else anim.SetBool("isRunning", false);

        if (xInput > 0.01f) transform.localScale = new Vector3(1, 1, 1);
        else if (xInput < -0.01f) transform.localScale = new Vector3(-1, 1, 1);

        transform.position += new Vector3(xInput, 0, 0) * moveSpeed * Time.deltaTime;
    }

    void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.Space))) && canJump == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
            canJump = false;
        }

        anim.SetBool("isGrounded", canJump);
    }

    void CorrectJump()
    {
        if (rb.velocity.y == 0f && canJump == false) jumpTimer += Time.deltaTime;
        else jumpTimer = 0f;

        if (rb.velocity.y == 0f && canJump == false && jumpTimer >= .5f) canJump = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {

            if (collision.gameObject.GetComponent<CoinScript>().collected == false) score++;
            collision.gameObject.GetComponent<CoinScript>().collected = true;
            SoundManager.PlaySound("coin");
            Destroy(collision.gameObject);
            
            scoreText.text = score.ToString();
        }

        else if (collision.tag == "Death")
        {
            SoundManager.PlaySound("death");
            transform.GetChild(1).parent = null;
            Destroy(this.gameObject);
            deathMenu.SetActive(true);
            
        }

        else if (collision.tag == "Door")
        {
            
           if (SceneManager.GetActiveScene().buildIndex == progress) GameObject.FindWithTag("Progress").GetComponent<ProgressScript>().progress++;
            SoundManager.PlaySound("win");
            transform.GetChild(1).parent = null;
            Destroy(this.gameObject);
            finishMenu.SetActive(true);
        }
    }

}
