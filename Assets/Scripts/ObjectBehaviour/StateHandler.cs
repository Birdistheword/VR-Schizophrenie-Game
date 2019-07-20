using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateHandler : MonoBehaviour
{
    public Hashtable AllBools = new Hashtable();
    

    void Start()
    {
        // Eine Liste von allen Boolean Werten, die in den State Handler müssen
        AllBools.Add("waterInTub", false);
        AllBools.Add("waterInbBowl", false);
        AllBools.Add("allPlatesGone", false);
        AllBools.Add("objectInHand", false);

    }

}
