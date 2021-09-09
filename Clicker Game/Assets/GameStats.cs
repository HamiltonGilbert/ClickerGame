using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStats : MonoBehaviour
{
    [SerializeField] GameObject woodText;



    [SerializeField] int _wood = 0;
    [SerializeField] int _woodIncrement = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _wood += _woodIncrement;
            woodText.GetComponent<Text>().text = "Wood: " + _wood;
        }
    }
}
