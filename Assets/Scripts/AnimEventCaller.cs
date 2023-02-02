using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class AnimEventCaller : MonoBehaviour
{
    public List<AnimEvent> events;
    private Dictionary<ScriptableObject, UnityEvent2> dict;
    // Start is called before the first frame update
    void Start()
    {
        dict = new Dictionary<ScriptableObject, UnityEvent2>();
        foreach (AnimEvent ae in events)
        {
            dict.Add(ae._key, ae._event);
        }
    }
    
    public void CallEvent(ScriptableObject obj)
    {
        dict[obj].Invoke();
    }

    [System.Serializable]
    public struct AnimEvent
    {
        public ScriptableObject _key;
        public UnityEvent2 _event;
    }
}
