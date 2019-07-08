using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStats : MonoBehaviour
{
    public double Eat;      private double MaxEat;
    public double Water;    private double MaxWater;
    public double Health;   private double MinHealth; 
    private double MaxHealth;
    int Type;
    bool ChangeHealth(int i)
    {
        if(i!=1)
        Health = Health - 0.01;
        if(Health < 1)
        return true;
        else return false;
    }
    int ChangeStats()
    {
        if(Eat > 0)
            Eat = Eat - 0.5;
        else Eat = 0;
        if(Water > 0)
            Water = Water - 0.0005;
        else Water = 0;


        if((Water < 1 )||(Eat < 1))
        return 0;
        else return 1;
        
    }
    void ChangePStats()
    {
        if (Type == 1)
        {
            if ((Eat + 30)<100)
            Eat = Eat + 30;
            else Eat = 100;
        }
        else
        {
            if ((Water + 30)<100)
            Water = Water + 30;
            else Eat = 100;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        MaxEat = 100;   MaxWater = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(ChangeHealth(ChangeStats()))
        Debug.Log("Dead");
    }
}
