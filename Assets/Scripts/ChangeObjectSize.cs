using UnityEngine;
using System.Collections;

public class ChangeObjectSize : MonoBehaviour
{
    Vector3 minScale;
    public Vector3 maxScale;
    public bool repeatable;
    public float speed = 0.1f;
    public float duration = 5f;

IEnumerator Start()
    {
        minScale = transform.localScale;
        while (repeatable)
        
        {
            yield return RepeatLerp(minScale, maxScale, duration);
            yield return RepeatLerp(maxScale, minScale, duration);


        }
    }
    public IEnumerator RepeatLerp (Vector3 a, Vector3 b, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }
    }
}