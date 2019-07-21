using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentMenuTesting : MonoBehaviour
{
    [ContextMenuItem("Reset", "ResetBiography")]
    [Multiline(8)]
    string playerBiography = "";

    void ResetBiography()
    {
        playerBiography = "asdasdasd";
    }
}
