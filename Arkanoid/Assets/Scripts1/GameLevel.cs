using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "GameData/Create/GameLevel")]
public class GameLevel : ScriptableObject
{
    public List<BlockObject> _listBlocks = new List<BlockObject>();

    
}

[System.Serializable]
public class BlockObject
{
    public Vector3 _position;
    public BlockData _block;
   // public string strBlock;
}