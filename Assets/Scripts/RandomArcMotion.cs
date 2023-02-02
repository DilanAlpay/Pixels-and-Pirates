using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class RandomArcMotion : MonoBehaviour
{
    public Vector2 offsetX, offsetY;
    public float duration = 1;
    Vector2 startPos, endPos;
    public AnimationCurve xcurve, ycurve;
    public UnityEvent onEnd;

    void Start()
    {
        Vector2 offset;
        offset.x = Random.Range(offsetX.x, offsetX.y);
        offset.y = Random.Range(offsetY.x, offsetY.y);

        startPos = transform.position;
        endPos = startPos + offset;

        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        float timer = 0.0f;
        while (timer <= duration)
        {
            float x = Mathf.Lerp(startPos.x, endPos.x, xcurve.Evaluate(timer / duration));
            float y = Mathf.Lerp(startPos.y, endPos.y, ycurve.Evaluate(timer / duration));
            transform.position = new Vector2(x, y);
            timer += Time.deltaTime;
            yield return null;
        }
        onEnd.Invoke();
    }
}
