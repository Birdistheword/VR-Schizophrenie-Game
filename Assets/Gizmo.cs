using UnityEngine;

public class Gizmo : MonoBehaviour
{
    public float gizmoSize = .75f;
    public Color gizmoColor = Color.yellow;

    // Start is called before the first frame update
    void onDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }


}
