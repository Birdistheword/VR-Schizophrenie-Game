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
        AllBools.Add("waterInBowl", false);
        AllBools.Add("dishWashing", false);
        AllBools.Add("allPlatesGone", false);
        AllBools.Add("objectInHand", false);
        AllBools.Add("waterInPot", false);
        AllBools.Add("tomatoInPot", false);
        AllBools.Add("cucumberInPot", false);
        AllBools.Add("cooking", false);
    }

}
