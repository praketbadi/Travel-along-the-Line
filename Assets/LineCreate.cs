using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreate : MonoBehaviour
{
    public GameObject linePrefab;
    linescript activeLine;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGO = Instantiate(linePrefab);
            activeLine = lineGO.GetComponent<linescript>();
        }
        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }


        if (activeLine != null)
        {
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousepos);
        }
    }

}
