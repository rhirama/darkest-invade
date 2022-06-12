using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Dungeon : MonoBehaviour
{
    [SerializeField] private DungeonsBase _base;
    [SerializeField] private int numRooms;
    [SerializeField] private int numCorridors;
    [SerializeField] private List<Room> _rooms;
    [SerializeField] private List<Corridor> _corridors;
    [SerializeField] private List<List<Corridor>> _structure;
    //difficulty ??
    //size ?? they are on dungeonsbase owo

    public DungeonsBase Base{
        get{return _base;}
    }

    public int NumRooms{
        get{return numRooms;}
    }

    public int NumCorridors{
        get{return numCorridors;}
    }

    public List<Room> Rooms{
        get{return _rooms;}
    }

    public List<Corridor> Corridors{
        get{return _corridors;}
    }

    public List<List<Corridor>> Structure{
        get{return _structure;}
    }

    //public Dungeon(DungeonsBase base, int numRooms, int numCorridors){}

    public static List<List<Corridor>> GenerateDungeon(int numRooms, double prob){
        var adjacencyList=new List<List<Corridor>> (numRooms);
        for (int i=0; i < numRooms; i++){
            adjacencyList.Add(new List<Corridor>());
        }
        for (int i=0; i < numRooms; i++){
            for (int j=0; j < numRooms; j++){
                double edgeProb = Random.Range(0f,1f);
                if(i!=j && adjacencyList.ElementAt(i).Count < 4 && edgeProb < prob ){
                    AddCorridor(adjacencyList,i,j);
                }
            }
        }
        return adjacencyList;
    }

    private static void AddCorridor(List<List<Corridor>> adjList, int i, int j){
        var cor=new Corridor();
        var rooms=new List<int>();
        rooms.Add(i);
        rooms.Add(j);
        cor.AdjRooms=rooms;
        adjList.ElementAt(i).Add(cor);
    }

}

//salas ou vertices
public class Room {
    public int Id {get; set;}
    public string RoomType {get; set;}
    public string Reward {get; set;}
    //public ?? Sprite {get; set;}
}

//corredores ou arestas
public class Corridor {
    public int Size {get; set;}
    public int Id {get; set;}
    public string CorridorType {get; set;}
    public List<int> AdjRooms {get; set;}
    //public ?? Sprites {get; set;}
    //public ?? Contents {get; set;}
}