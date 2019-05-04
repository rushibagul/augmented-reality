using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

    // Use this for initialization

   
  //  public GameObject vaz = new GameObject();
  //  public GameObject sofa = new GameObject();
    public GameObject slid = new GameObject();
    public GameObject slid2 = new GameObject();
    Slider sli;
    Slider sli2;

    // new
    public GameObject[] bookCases = new GameObject[2];
    public GameObject[] chairs = new GameObject[9];
    public GameObject[] tables = new GameObject[4];
    public GameObject[] sofas = new GameObject[3];
    public GameObject[] fridges = new GameObject[2];

    //active list
    int activeBookCase;
    int activeChair;
    int activeTable;
    int activeSofa;
    int activeFridge;



    

	void Start () {

        for(int i = 0; i < 2; i++)
        {
            bookCases[i].SetActive(false);
        }

        for(int i = 0; i < 9; i++)
        {
            chairs[i].SetActive(false);
        }

        for(int i = 0; i < 4; i++)
        {
            tables[i].SetActive(false);
        }

        for(int i = 0; i < 3; i++)
        {
            sofas[i].SetActive(false);
        }

        for(int i = 0; i < 2; i++)
        {
            fridges[i].SetActive(false);
        }

       // sofa.SetActive(false);
       // vaz.SetActive(false);
        sli = slid.GetComponent<Slider>();
        sli2 = slid2.GetComponent<Slider>();

        //allot
        activeBookCase = 0;
        activeChair = 0;
        activeTable = 0;
        activeSofa = 0;
        activeFridge = 0;
	}
	
	// Update is called once per frame
	void Update () {
       // sofa.transform.localScale = new Vector3(sli.value*62, sli.value * 62, sli.value * 62);
       // vaz.transform.localScale = new Vector3(sli.value * 33, sli.value * 33, sli.value * 33);

       // sofa.transform.localRotation = Quaternion.Euler(-90, 360 * sli2.value, 0f);
       // vaz.transform.localRotation = Quaternion.Euler(-90, 360 * sli2.value, 0f);



        //sofa.transform.Rotate(0, 360 * sli2.value, 0f);
        //vaz.transform.Rotate(0, 360 * sli2.value, 0f);

        for(int i = 0; i < 2; i++)
        {
            bookCases[i].transform.localScale = new Vector3(sli.value * 50, sli.value * 50, sli.value * 50);
            bookCases[i].transform.localRotation = Quaternion.Euler(-90, 360 * sli2.value, 0f);
        }

        for(int i = 0; i < 9; i++)
        {
            if (i != 7)
            {
                chairs[i].transform.localScale = new Vector3(sli.value * 50, sli.value * 50, sli.value * 50);
                chairs[i].transform.localRotation = Quaternion.Euler(-90, 360 * sli2.value, 0f);
            }
            else
            {
                chairs[i].transform.localScale = new Vector3(sli.value * 30, sli.value * 30, sli.value * 30);
                chairs[i].transform.localRotation = Quaternion.Euler(-90, 360 * sli2.value, 0f);
            }

        }

        for(int i = 0; i < 4; i++)
        {
            if (i != 2)
            {
                tables[i].transform.localScale =new Vector3(sli.value * 50, sli.value * 50, sli.value * 50);
                tables[i].transform.localRotation = Quaternion.Euler(-90, 360 * sli2.value, 0f);
            }
            else
            {
                tables[i].transform.localScale = new Vector3(sli.value * 50, sli.value * 2, sli.value * 50);
                tables[i].transform.localRotation = Quaternion.Euler(-90, 360 * sli2.value, 0f);
            }
        }

        for(int i = 0; i < 3; i++)
        {
            if (i != 0)
            {
                sofas[i].transform.localScale = new Vector3(sli.value * 30, sli.value * 30, sli.value * 30);
                sofas[i].transform.localRotation = Quaternion.Euler(-90, 360 * sli2.value, 0f);
            }
            else
            {
                sofas[i].transform.localScale = new Vector3(sli.value * 50, sli.value * 50, sli.value * 50);
                sofas[i].transform.localRotation = Quaternion.Euler(-90, 360 * sli2.value, 0f);
            }
        }

        for(int i = 0; i < 2; i++)
        {
            fridges[i].transform.localScale = new Vector3(sli.value * 50, sli.value * 50, sli.value * 50);
            fridges[i].transform.localRotation = Quaternion.Euler(-90, 360 * sli2.value, 0f);
        }

    }

   // public void Spawn1()
    //{
      //  sofa.SetActive(false);

        //vaz.SetActive(true);
    //}

    ///public void Spawn2()
   // {
    //    vaz.SetActive(false);

   //     sofa.SetActive(true);
   // }

    public void bookShelfClick()
    {
        for(int i = 0; i < 2; i++)
        {
            if (i == activeBookCase)
            {
                bookCases[i].SetActive(true);


                Debug.Log(activeBookCase);
            }
            else
            {
                bookCases[i].SetActive(false);
            }
        }

        for (int i = 0; i < 9; i++)
        {
            chairs[i].SetActive(false);
        }

        for (int i = 0; i < 4; i++)
        {
            tables[i].SetActive(false);
        }

        for (int i = 0; i < 3; i++)
        {
            sofas[i].SetActive(false);
        }

        for (int i = 0; i < 2; i++)
        {
            fridges[i].SetActive(false);
        }

        if (activeBookCase == 1)
        {
            activeBookCase = 0;
        }
        else
        {
            activeBookCase++;
        }

    }

    public void chairClick()
    {
        for(int i = 0; i < 9; i++)
        {
            if(i == activeChair)
            {
                chairs[i].SetActive(true);

            }
            else
            {
                chairs[i].SetActive(false);
            }
        }

        for (int i = 0; i < 2; i++)
        {
            bookCases[i].SetActive(false);
        }

        for (int i = 0; i < 4; i++)
        {
            tables[i].SetActive(false);
        }

        for (int i = 0; i < 3; i++)
        {
            sofas[i].SetActive(false);
        }

        for (int i = 0; i < 2; i++)
        {
            fridges[i].SetActive(false);
        }

        if (activeChair == 8)
        {
            activeChair = 0;
        }
        else
        {
            activeChair++;
        }
    }

    public void tableClick()
    {
        for(int i = 0; i < 4; i++)
        {
            if(i == activeTable)
            {
                tables[i].SetActive(true);

            }
            else
            {
                tables[i].SetActive(false);
            }
        }

        for (int i = 0; i < 2; i++)
        {
            bookCases[i].SetActive(false);
        }

        for (int i = 0; i < 9; i++)
        {
            chairs[i].SetActive(false);
        }


        for (int i = 0; i < 3; i++)
        {
            sofas[i].SetActive(false);
        }

        for (int i = 0; i < 2; i++)
        {
            fridges[i].SetActive(false);
        }

        if (activeTable == 3)
        {
            activeTable = 0;
        }
        else
        {
            activeTable++;
        }
    }

    public void sofaClick()
    {
        for(int i = 0; i < 3; i++)
        {
            

            if (i == activeSofa)
            {
                sofas[i].SetActive(true);

            }
            else
            {
                sofas[i].SetActive(false);
            }
        }

        for (int i = 0; i < 2; i++)
        {
            bookCases[i].SetActive(false);
        }

        for (int i = 0; i < 9; i++)
        {
            chairs[i].SetActive(false);
        }

        for (int i = 0; i < 4; i++)
        {
            tables[i].SetActive(false);
        }

        for (int i = 0; i < 2; i++)
        {
            fridges[i].SetActive(false);
        }

        if (activeSofa == 2)
        {
            activeSofa = 0;
        }
        else
        {
            activeSofa++;
        }
    }

    public void fridgeClick()
    {
        for(int i = 0; i < 2; i++)
        {
            if (i == activeFridge)
            {
                fridges[i].SetActive(true);


            }
            else
            {
                fridges[i].SetActive(false);
            }
        }

        for (int i = 0; i < 2; i++)
        {
            bookCases[i].SetActive(false);
        }

        for (int i = 0; i < 9; i++)
        {
            chairs[i].SetActive(false);
        }

        for (int i = 0; i < 4; i++)
        {
            tables[i].SetActive(false);
        }

        for (int i = 0; i < 3; i++)
        {
            sofas[i].SetActive(false);
        }

        if (activeFridge == 1)
        {
            activeFridge = 0;
        }
        else
        {
            activeFridge++;
        }


    }

}
