using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody enemyRb;
    private GameObject player;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        // if the game object falls below -10 on the y-axis we gonna remove it
        // from the game
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        if (!player) return;
        /// challenge: set lookDirection to "enemy to player" vector
        Vector3 lookDirection = player.transform.position - transform.position;
        enemyRb.AddForce(lookDirection.normalized * speed);
    }
}
