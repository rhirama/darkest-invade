using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dungeons : MonoBehaviour
{
    [SerializeField] private DungeonsBase _base;
    [SerializeField] private int _nRooms;
    [SerializeField] private int _nCorridors;
    [SerializeField] private Room[] _rooms;
}

//salas ou vertices
public class Room {
    public int Id {get; set;}
}

//corredores ou arestas
public class Corridor {
    public Room minor;
    public Room major;
}