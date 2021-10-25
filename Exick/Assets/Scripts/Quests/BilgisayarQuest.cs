using UnityEngine;

public class BilgisayarQuest : QuestSetup
{
    public Sprite initialSprite = null;
    public Sprite completedSprite = null;
    private SpriteRenderer spriteRenderer = null;
    public GameObject bilgisayar;
    public Transform itemTRSF;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = initialSprite;
    }

    protected override void Process()
    {
        spriteRenderer.sprite = completedSprite;
        Instantiate(bilgisayar, itemTRSF.position, transform.rotation);
    }
}
