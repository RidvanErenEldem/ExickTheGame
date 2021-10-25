using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GorevlerScript : MonoBehaviour
{
    private List<GameObject> OlusturulanPrefablar;
    public GameObject YeniObje;
    private List<Gorev> gorevler;
    public static GorevlerScript gorevlerScript;
     void Awake()
    {
        gorevlerScript = this;
        gorevler = new List<Gorev>();
        OlusturulanPrefablar = new List<GameObject>();
    }
    public void GorevEkle(Gorev yenigorev)
    {
        gorevler.Add(yenigorev);
        EkranGorevGuncelle();
    }
    public  bool GorevTamamla(Item esya)
    {
        for (int i = 0; i < gorevler.Count; i++)
        {
            if (gorevler[i].item == esya)
            {
                gorevler.RemoveAt(i);
                EkranGorevGuncelle();
                return true;
            }
            
        }
        return false;

    }
    public void EkranGorevGuncelle()
    {
       
        for (int i = 0; i < OlusturulanPrefablar.Count; i++)
        {
            Destroy(OlusturulanPrefablar[i].gameObject);
        }
        OlusturulanPrefablar.Clear();
        for (int i = 0; i < gorevler.Count; i++)
        {
            GameObject yeniObj = Instantiate(YeniObje, transform.position, transform.rotation).gameObject;
            OlusturulanPrefablar.Add(yeniObj);
            RectTransform rect = ((RectTransform)yeniObj.transform.GetChild(0));
            Vector2 ydegis = rect.localPosition;
            ydegis.y -= i* 200;
            rect.localPosition = ydegis;
            OlusturulanPrefablar[i].GetComponent<GorevEkrandaGoster>().Guncelle(gorevler[i]);
            
        }
    }
}
