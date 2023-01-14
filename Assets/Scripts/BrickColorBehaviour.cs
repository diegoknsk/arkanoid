using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickColorBehaviour : MonoBehaviour
{
    public Color[] damageColors;
    int maxHits;
    protected int hitNumbers;
    // Start is called before the first frame update
    void Start()
    {
        hitNumbers = 0;
        maxHits = damageColors.Length;

        GetComponent<SpriteRenderer>().color = damageColors[hitNumbers];

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
       
        hitNumbers++;

        if(hitNumbers >=maxHits)
        {
            Destroy(gameObject);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = damageColors[hitNumbers];
        }
    }
}
