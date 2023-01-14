using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{

    public GameObject prefabSpecialItem;
    public GameObject paddle;
    public TextMeshProUGUI  pointPanel;

    protected int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnItem",2);
        
    }

    protected void addPoint(int point)
    {
        score += point;
        pointPanel.text = score.ToString();

    }

    protected void spawnItem()
    {
        GameObject specialItem = Instantiate(prefabSpecialItem);
        specialItem.transform.position = new Vector2(Random.Range(-7, 7), Random.Range(-1, 2));
    }

    public void onSpecialItemCollision(GameObject other)
    {
        Vector2 size = paddle.GetComponent<SpriteRenderer>().size;
        size.x += 1;

        paddle.GetComponent<SpriteRenderer>().size = size;
        paddle.GetComponent<CapsuleCollider2D>().size = size;

        Destroy(other.gameObject);
    }

    public void onBallCollision(GameObject other)
    {
        if (other.CompareTag("GameOver"))
        {
            SceneManager.LoadScene(2);
        }
        else if (other.CompareTag("SpecialItem"))
        {
            onSpecialItemCollision(other);
        }
        else if (other.CompareTag("Brick"))
        {
            addPoint(10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
