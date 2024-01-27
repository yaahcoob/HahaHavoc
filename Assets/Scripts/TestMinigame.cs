using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMinigame : MonoBehaviour
{

    [SerializeField] private KeyCode player1Code;
    [SerializeField] private KeyCode player2Code;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(player1Code))
        {
            GameManager.Instance.DecrementPlayer2Lives();
            GameManager.Instance.EndMinigame();
        }

        if (Input.GetKeyDown(player2Code))
        {
            GameManager.Instance.DecrementPlayer1Lives();
            GameManager.Instance.EndMinigame();
        }
            
    }
}
