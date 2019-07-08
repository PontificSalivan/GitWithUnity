using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MasterItem : MonoBehaviour
{
    private float Weight;
    private Renderer MR;

    public float GetWeight()
    {
        return Weight;
    }

    private void ToStorage()
    {
        MR.enabled = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        MR = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
