using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LakituMovement : MonoBehaviour
{
    public Transform Player;
    public float speed = 1f;
    private Rigidbody2D _rb2D;
    // Start is called before the first frame update
    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            Vector3 direction = (Player.position - transform.position).normalized;
            _rb2D.velocity = new Vector2(direction.x * speed, _rb2D.velocity.y);

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<MarioScript>())
        {
        
            GameManager.instance.ResetTime();
            GameManager.instance.LoadScene("Game");
        }
    }
}





