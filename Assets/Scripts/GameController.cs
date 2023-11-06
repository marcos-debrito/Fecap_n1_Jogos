using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{   
    private PointsController pointsController;

    private void OnTriggerEnter(Collider alvo)
    {   
        pointsController = FindObjectOfType<PointsController>();
        pointsController.ChangeScore(); 
        Destroy(gameObject);    
    }

    void Start()
    {

    }
}
