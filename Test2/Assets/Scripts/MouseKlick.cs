using System.Collections;
using UnityEngine;

public class MouseKlick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Кликнул на " + name);
    }
}
