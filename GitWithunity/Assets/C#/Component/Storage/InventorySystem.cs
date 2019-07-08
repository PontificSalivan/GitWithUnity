using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class InventorySystem : MonoBehaviour
{
    private MasterItem[] Item = new MasterItem[50];
    private float Weight;
    private float MaxWeight;  
    public void AddToStorage(MasterItem item)
    {
        if(CheckWeight(item))
        {
            return;
        }
    }
    public void DropToWorld()
    {

    }
    public void RemoveItem()
    {

    }
    public bool CheckWeight(MasterItem item)
    {
        if ((item.GetWeight() + Weight) >= MaxWeight)
            return (false);
        else return (true);
    }


    // Start is called before the first frame update
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
