using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class QuestSetup : MonoBehaviour 
{
    public Gorev quest = null;
    private bool isDone = false;

    private void Awake() 
    {
        gameObject.layer = LayerMask.NameToLayer("Interactable");
    }

    private bool Control()
    {
        return PlayerInteraction.playerInteraction.item == quest.item;
    }

    public bool Complete()
    {
        if(isDone)
            return true;

        if(!Control())  return false;
        if(!Finish())   return false;
        Process();
        
        isDone = true;
        return true;
    }

    protected abstract void Process();

    private bool Finish()
    {
        if(Control())
            if(GorevlerScript.gorevlerScript.GorevTamamla(PlayerInteraction.playerInteraction.item))
            {
                PlayerInteraction.playerInteraction.item = null;
                return true;
            }
        return false;
    }
}