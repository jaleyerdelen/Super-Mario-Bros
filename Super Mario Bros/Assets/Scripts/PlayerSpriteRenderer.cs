using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteRenderer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private PlayerMovements movement;

    public Sprite idle;
    public Sprite jump;
    public Sprite slide;
    public Sprite run;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movement = GetComponentInParent<PlayerMovements>();
            
    }

    private void LateUpdate()
    {
        if (movement.jumping)
        {
            spriteRenderer.sprite = jump;
        }
        else if (movement.sliding)
        {
            spriteRenderer.sprite = slide;
        }
        else if (movement.running)
        {
            spriteRenderer.sprite= run;
        }
        else
        {
            spriteRenderer.sprite = idle;
        }
            
    }
}
