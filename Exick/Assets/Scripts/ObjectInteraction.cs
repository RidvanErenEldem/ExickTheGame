using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    [SerializeField] private Item item;
    void Start()
    {
        Guncelle(item);
    }

    public Item itemReturn ()
    {
        return item;
    }

    public void Guncelle(Item item2)
    {
        item = item2;
        this.GetComponent<SpriteRenderer>().sprite = item.Resim;
        this.transform.localScale = item.Boyut;
    }
}
