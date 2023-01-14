using UnityEngine;
using UnityEngine.SceneManagement;

public class ArkanoidBallBheaviour : MonoBehaviour
{
    public GameManager gameManager;
    public float startSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = (Vector2.up + Vector2.right) * startSpeed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.onBallCollision(collision.gameObject);
        Debug.Log("Colidiu com paredes ou paddle");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.CompareTag("GameOver"))
        //{
        //    SceneManager.LoadScene(2);
        //    Debug.Log("========= GAME OVER =========");
        //}
        //else if (other.CompareTag("SpecialItem"))
        //{
        //    gameManager.onSpecialItemCollision(other.gameObject);

        //}
        gameManager.onBallCollision(other.gameObject);
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("====Área de Game Over");
    }
}
