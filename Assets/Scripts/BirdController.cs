using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flyPower;

    public AudioClip flyClip;
    public AudioClip gameOverClip;

    private AudioSource audioSource;

    public Animator animator;
    GameObject obj;
    GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        flyPower = 1000;

        audioSource = obj.GetComponent<AudioSource>();
        audioSource.clip = flyClip;

        if (gameController == null)
            gameController = GameObject.FindGameObjectWithTag("GameController");

        animator = obj.GetComponent<Animator>();
        animator.SetBool("isDead", false);
        animator.SetFloat("flyPower", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (gameController.GetComponent<GameController>().isEndGame == false)
            {
                audioSource.Play();
            }
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        }
        animator.SetFloat("flyPower", obj.GetComponent<Rigidbody2D>().velocity.y);
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        EndGame();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.GetComponent<GameController>().GetPoint();
    }

    void EndGame()
    {
        animator.SetBool("isDead", true);
        audioSource.clip = gameOverClip;
        audioSource.Play();
        gameController.GetComponent<GameController>().EndGame();
    }
}
