using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : MonoBehaviour
{
    bool isPlanted = false;
    bool isHarvest = false;
    public GameObject plant;
    public GameObject corn;
    public GameObject[] plantStages;
    int plantStage = 0;
    //float timeBtwStages = 10.0f;
    float timer=4.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlanted==true)
        {
            timer -= Time.deltaTime;
            if (timer < 0 )
            {
                Destroy(plant);
                UpdatePlant();

            }
        }
    }
    private void OnMouseDown()
    {
        
        if (isPlanted)
        {
            return;
        }
        
        else
        {
            Plant();
        }
        if (isHarvest)
        {
            Harvest();
        }
        else
            return;

    }
    void Harvest()
    {
        isPlanted = false;
        isHarvest = false;
        plant.gameObject.SetActive(false);
        corn.gameObject.SetActive(false);
    }
    void Plant()
    {
        isHarvest = false;
        isPlanted = true;
        plant.gameObject.SetActive(true);
    }
    void UpdatePlant()
    {
        isPlanted = true;
        corn.gameObject.SetActive(true);
        isHarvest = true;
    }
}