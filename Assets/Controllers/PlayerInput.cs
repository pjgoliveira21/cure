using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerInput : MonoBehaviour
{
    public Tile cureStation;
    public Tilemap itemsMap; 
    public PlayerMovement playerMovementScript;
    
    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript= this.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) {
            // get current grid location
            Vector3Int currentCell = itemsMap.WorldToCell(transform.position);
        
            if(playerMovementScript.lastPos==1) currentCell.y+=1;
            if(playerMovementScript.lastPos==2) currentCell.x-=1;
            if(playerMovementScript.lastPos==3) currentCell.y-=1;
            if(playerMovementScript.lastPos==4) currentCell.x+=1;
            itemsMap.SetTile(currentCell, cureStation);
            
            }  
    }      
}

