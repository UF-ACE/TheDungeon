using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Level: Describes a level
public class Level : MonoBehaviour {
    enum Mission { Capture, Assassinate, Steal }
    enum LevelSize { Small, Medium, Large }

    public Tileset tileset;
    Mission missionType;
    LevelSize size;
    List<ObjectivePosition> objectivePostions;

    int enteranceCount;

    // Awards
    int notorityAward, creditAward;

    void Start(){
        Vector2 shipCenter = getShipCenter(tileset.shipVertex);
        float shipRadius = getShipRadius(tileset.shipVertex, shipCenter);

                // Use the triangulator to get indices for creating triangles
        Triangulator tr = new Triangulator(tileset.shipVertex);
        int[] indices = tr.Triangulate();
 
        // Create the Vector3 vertices
        Vector3[] vertices = new Vector3[tileset.shipVertex.Length];
        for (int i=0; i<vertices.Length; i++) {
            vertices[i] = new Vector3(tileset.shipVertex[i].x, tileset.shipVertex[i].y, 0);
        }
 
        // Create the mesh
        Mesh msh = new Mesh();
        msh.vertices = vertices;
        msh.triangles = indices;
        msh.RecalculateNormals();
        msh.RecalculateBounds();
 
        // Set up game object with mesh;
        gameObject.AddComponent(typeof(MeshRenderer));
        MeshFilter filter = gameObject.AddComponent(typeof(MeshFilter)) as MeshFilter;
        filter.mesh = msh;

        //PlacePointsInShip(ref tileset.objectivePool, shipRadius, shipCenter);
        //PlacePointsInShip(ref tileset.pointOfInterestPool, shipRadius, shipCenter);
    }

    private void PlacePointsInShip(ref Objective[] objectivePool, float shipRadius, Vector2 shipCenter)
    {
        foreach(var objective in objectivePool){
            Vector2 temp = (UnityEngine.Random.insideUnitCircle * shipRadius) + shipCenter;
            while (!IsValidPoint(temp, objective.radius))
            {
                temp = (UnityEngine.Random.insideUnitCircle * shipRadius) + shipCenter;
                shipRadius *= 1.1f;
            }
            objectivePostions.Add(new ObjectivePosition(objective, temp));
        }
    }

    private bool IsValidPoint(Vector2 point, float radius)
    {
        foreach(var objP in objectivePostions)
        {
            if (Vector2.Distance(objP.position, point) < radius)
            {
                return false;
            }
        }
        return true;
    }

    private float getShipRadius(Vector2[] shipVertex, Vector2 shipCenter)
    {
        float r = 0.0f;
        foreach(var pt in shipVertex)
        {
            r = Math.Max(Math.Abs(Vector2.Distance(shipCenter, pt)), r);
        }
        return r;
    }

    private Vector2 getShipCenter(Vector2[] shipVertex)
    {
        Vector2 center = new Vector2();
        foreach(var pt in shipVertex)
        {
            center.x += pt.x;
            center.y += pt.y;
        }
        center.x /= shipVertex.Length;
        center.y /= shipVertex.Length;
        return center;
    }

}
