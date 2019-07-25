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

        AllBools.Add("waterInEG", false);
        AllBools.Add("waterInBowl2", false);
        AllBools.Add("waterInPot", false);
        AllBools.Add("tomatoInPot", false);
        AllBools.Add("cucumberInPot", false);
        AllBools.Add("cooking", false);
        AllBools.Add("cookingDone", false);
        AllBools.Add("PfeilSpawn", false);

        AllBools.Add("videoPlaying", false);
        AllBools.Add("pillsTaken", false);
        AllBools.Add("rightVideoWatched", false);
        AllBools.Add("taskFinished", false);
        AllBools.Add("arrowHitCount", 0);
        AllBools.Add("allArrowsHit", false);

    }

}
