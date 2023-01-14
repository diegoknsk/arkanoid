using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCrackBehaviour : MonoBehaviour
{
    public Sprite[] spriteList;
    int maxHits;
    protected int hitNumbers;
    // Start is called before the first frame update
    void Start()
    {

        hitNumbers = 0;
        maxHits = spriteList.Length;

        GetComponent<SpriteRenderer>().sprite = spriteList[hitNumbers];

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        hitNumbers++;

        if (hitNumbers >= maxHits)
        {
            Destroy(gameObject);
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = spriteList[hitNumbers];
        }
    }
}
