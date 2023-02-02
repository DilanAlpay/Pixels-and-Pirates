using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInt : MonoBehaviour
{
    private Text t;
    public IntVar i;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Text>();
        i.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t.text = i.value.ToString();
    }
}
