using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject target;
    float moveSpeed;
    Vector3 directionToTarget;
    public GameObject explosion;
    public static bool GameOver = false;

    void Start()
    {
        target = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(1f, 3f);

    }
    // Get Input from User in Update. Called once per frame.
    void Update()
    {
        MoveEnemy();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                Spawner.spawnAllowed = false;
                Instantiate(explosion, collision.gameObject.transform.position, Quaternion.identity);
                FindObjectOfType<AudioManager>().Play("Explosion");
                Destroy(collision.gameObject);
                target = null;
                GameOver = true;
                break;

            case "Bullet":
                Instantiate(explosion, transform.position, Quaternion.identity);
                KillsCounter.killsNumber += 1;
                FindObjectOfType<AudioManager>().Play("Explosion");
                Destroy(collision.gameObject);
                Destroy(gameObject);
                break;
        }
    }
    void MoveEnemy()
    {
        if (target != null)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(directionToTarget.x * moveSpeed, directionToTarget.y * moveSpeed);
        }
        else
            rb.velocity = Vector3.zero;
    }
}
