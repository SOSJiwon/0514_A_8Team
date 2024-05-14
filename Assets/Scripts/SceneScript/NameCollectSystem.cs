using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NameCollectSystem : MonoBehaviour
{
    public TMP_InputField inputField;

    public void OnClickBtn()
    {
        if(inputField.text.Length < 2 || inputField.text.Length > 10)
        {
            return;
        }

        DataManger.Instance.username = inputField.text;
        SceneManager.LoadScene(1);
    }

}
