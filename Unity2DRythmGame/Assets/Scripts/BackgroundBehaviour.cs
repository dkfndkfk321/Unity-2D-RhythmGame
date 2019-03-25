using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBehaviour : MonoBehaviour
{

    public GameObject background;
    private SpriteRenderer backgroundSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        backgroundSpriteRenderer = background.GetComponent<SpriteRenderer>();
        StartCoroutine(FadeOut(backgroundSpriteRenderer, 0.005f));

        IEnumerator FadeOut(SpriteRenderer spriteRenderer, float amount)
        {
            Color color = spriteRenderer.color;
            while(color.a > 0)
            {
                color.a -= amount;
                spriteRenderer.color = color;
                yield return new WaitForSeconds(amount);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
