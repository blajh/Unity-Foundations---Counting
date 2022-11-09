using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewCounter : MonoBehaviour
{
    public TMP_Text counterText;
    public int multiplier;
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
    private void OnTriggerEnter(Collider other)
    {
        count += multiplier;
        counterText.text = "Score : " + count;
    }
}
