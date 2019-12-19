using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Graph
{
    // A list of graph connections.
    private List<SheetMover> WaypointConnections = new List<SheetMover>();
    public Graph()
    {
    }
    // Add connection.
    public void AddConnection(SheetMover aConnection)
    {
        WaypointConnections.Add(aConnection);
    }
    // Get the connections from a node to the nodes it is connected to.
    public List<SheetMover> GetConnections(GameObject FromNode)
    {
        List<SheetMover> TmpConnections = new List<SheetMover>();
        foreach (SheetMover aConnection in WaypointConnections)
        {
            if (aConnection.GetFromNode().Equals(FromNode))
            {
                TmpConnections.Add(aConnection);
            }
        }
        return TmpConnections;
    }
}