using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    
    public GameObject goal = null;
    public static int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (cnt < 3)
        {
            GameObject goal_new = GameObject.Instantiate(goal) as GameObject;
            goal_new.transform.position = new Vector3(Random.Range(-2, 2), Random.Range(2, 4), 10);
            cnt++;
        }
    }

   }
