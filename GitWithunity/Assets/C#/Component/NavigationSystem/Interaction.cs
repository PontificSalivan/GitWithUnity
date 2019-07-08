using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interaction : MonoBehaviour
{
    private NavigationSystem NS;
    private Vector3 ActorLocation;
    private NavMeshAgent agent;
    private InventorySystem IS;
    private MasterItem MI;
    private bool SeeItem;
    // Start is called before the first frame update
    void Start()
    {
        NS = GetComponent<NavigationSystem>();
        agent = GetComponent<NavMeshAgent>();
        IS = GetComponent<InventorySystem>();
        SeeItem = false;
    }
    void OnTriggerStay(Collider other){
        
        if(other.GetComponent<MasterItem>())
        {
            print(other.gameObject.name);
            ActorLocation = other.transform.position;
            NS.SetPoint(ActorLocation);
            SeeItem = true;
            MI = other.GetComponent<MasterItem>();
        }
        

    }
    float getDistance() //Дистанция от персонажа до точки
    {
        float dis = Mathf.Sqrt((agent.transform.position.x - ActorLocation.x) +
                               (agent.transform.position.z - ActorLocation.z));
        return (dis);
    }
    public void TakeItem(MasterItem item)
    {
        
        IS.AddToStorage(item);
    }

    // Update is called once per frame
    void Update()
    {
        if(SeeItem)
            if(getDistance() < 2)
            {
                TakeItem(MI);
                MI = null;
            }
    }
}
