// Copyright 2000 softSurfer, 2012 Dan Sunday
// This code may be freely used and modified for any purpose
// providing that this copyright notice is included with it.
// SoftSurfer makes no warranty for this code, and cannot be held
// liable for any real or imagined damage resulting from its use.
// Users of this code must verify correctness for their application.
//Modifed 2018 Alex Hartley

// a Point is defined by its coordinates {int x, y;}
//===================================================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointInPolygon
{

    // isLeft(): tests if a point is Left|On|Right of an infinite line.
    //    Input:  three points P0, P1, and P2
    //    Return: >0 for P2 left of the line through P0 and P1
    //            =0 for P2  on the line
    //            <0 for P2  right of the line
    //    See: Algorithm 1 "Area of Triangles and Polygons"
    float isLeft(Vector2 P0, Vector2 P1, Vector2 P2)
    {
        return ((P1.x - P0.x) * (P2.y - P0.y)
                - (P2.x - P0.x) * (P1.y - P0.y));
    }
    //===================================================================

    // wn_PnPoly(): winding number test for a point in a polygon
    //      Input:   P = a point,
    //               V[] = vertex points of a polygon V[n+1] with V[n]=V[0]
    //      Return:  wn = the winding number (=0 only when P is outside)
    int
    wn_PnPoly(Vector2 P, Vector2[] V)
    {
        int wn = 0;    // the  winding number counter
        int n = V.Length;
        // loop through all edges of the polygon
        for (int i = 0; i < n; i++)
        {   // edge from V[i] to  V[i+1]
            if (V[i].y <= P.y)
            {          // start y <= P.y
                if (V[i + 1].y > P.y)      // an upward crossing
                    if (isLeft(V[i], V[i + 1], P) > 0)  // P left of  edge
                        ++wn;            // have  a valid up intersect
            }
            else
            {                        // start y > P.y (no test needed)
                if (V[i + 1].y <= P.y)     // a downward crossing
                    if (isLeft(V[i], V[i + 1], P) < 0)  // P right of  edge
                        --wn;            // have  a valid down intersect
            }
        }
        return wn;
    }
}
//===================================================================