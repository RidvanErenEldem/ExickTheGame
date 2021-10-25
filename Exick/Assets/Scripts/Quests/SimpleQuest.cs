using UnityEngine;

public class SimpleQuest : QuestSetup
{
    public Sprite initialSprite = null;
    public Sprite completedSprite = null;
    private SpriteRenderer spriteRenderer = null;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = initialSprite;
    }

    protected override void Process()
    {
        
        spriteRenderer.sprite = completedSprite;
    }
}
