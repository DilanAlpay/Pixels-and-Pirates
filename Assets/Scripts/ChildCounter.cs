using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCounter : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        print(transform.childCount);
    }
}
