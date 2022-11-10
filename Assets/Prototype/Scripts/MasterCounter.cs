using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MasterCounter : MonoBehaviour
{
    public TMP_Text counterText;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToCount(int amount) {
        count += amount;
        counterText.text = "Score : " + count;
    }
}
