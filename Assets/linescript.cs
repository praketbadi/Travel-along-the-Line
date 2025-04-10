using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class linescript : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public EdgeCollider2D edgecol;

    List<Vector2> points = new List<Vector2>(); // Initialize in declaration

    public void UpdateLine(Vector2 mousepos)
    {
        if (points.Count == 0)
        {
            SetPoint(mousepos);
            return;
        }

        //check if the mouse has moved enough to insert new mousepos
        if (Vector2.Distance(points.Last(), mousepos) > .1f)
        {
            SetPoint(mousepos);        }
    }

    void SetPoint(Vector2 point)
{
    Vector3 linePoint = new Vector3(point.x, point.y, 0f); // Ensure Z is 0
    points.Add(point);
    lineRenderer.positionCount = points.Count;
    lineRenderer.SetPosition(points.Count - 1, linePoint);
    Debug.Log("LineRenderer Z: " + linePoint.z);

    if(points.Count>1){
        edgecol.points = points.ToArray();
    }
}
}