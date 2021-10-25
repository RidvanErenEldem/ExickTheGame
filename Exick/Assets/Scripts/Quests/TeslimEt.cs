using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeslimEt : QuestSetup
{
    public GameObject bilgisayar;
    public Transform instPos;
    
    
    protected override void Process()
    {
        Instantiate(bilgisayar, instPos.position, transform.rotation);
    }
}

