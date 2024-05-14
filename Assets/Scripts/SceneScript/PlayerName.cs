using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    public TMP_Text nameTxt;

    // Start is called before the first frame update
    void Start()
    {
        nameTxt = GetComponent<TMP_Text>();

        nameTxt.text = DataManger.Instance.username;
    }

    
}
