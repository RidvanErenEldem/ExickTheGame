using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject InterObj = null;
    public GameObject SecondObj = null;
    public GameObject instObject = null;
    public LayerMask mask; 
    public Item item = null;
    private Item temp = null;
    public Image tutulan;

    public static PlayerInteraction playerInteraction;

    private void Start() 
    {
        playerInteraction = this;
    }
    
    void Update()
    {
        
        if (Input.GetButtonDown("Interact"))
        {
            InterObj = FindClosest()?.gameObject;

            if(InterObj?.GetComponent<ObjectInteraction>())
            {
                if (InterObj && item == null)
                {
                    ObjectInteraction objectInteraction = InterObj.GetComponent<ObjectInteraction>();
                    item = objectInteraction.itemReturn();
                    Destroy(InterObj);
                }
                else if (InterObj && item != null)
                {
                    ObjectInteraction objectInteraction = InterObj.GetComponent<ObjectInteraction>();
                    temp = objectInteraction.itemReturn();
                    objectInteraction.Guncelle(item);
                    item = temp;
                }
            }
            else
                InterObj?.GetComponent<QuestSetup>()?.Complete();
        }
        else if(Input.GetButtonDown("Drop") && item != null)
        {
            Instantiate(instObject, transform.position, Quaternion.identity).GetComponent<ObjectInteraction>().Guncelle(item);
            item = null;
            tutulan.sprite = null;
        }
        
        if (item)
            tutulan.sprite = item.Resim;
        else
            tutulan.sprite = null;

    }

    Transform FindClosest()
    {
        Collider2D[] borderingProvinces = Physics2D.OverlapCircleAll(transform.position, 3, mask);

        float closestDistance = 99999;
        Transform closest = null;

        foreach (Collider2D hit in borderingProvinces)
        {
            var distance = (transform.position - hit.transform.position).magnitude;
            if (distance < closestDistance)
            {
                closest = hit.transform;
                closestDistance = distance;
            }
        }
        return closest;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Interactable"))
        {
            InterObj = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag ("Interactable"))
        {
            if(other.gameObject == InterObj)
            {
                InterObj = null;
            }
        }
    }
}
