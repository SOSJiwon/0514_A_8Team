using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameCollectSystem : MonoBehaviour
{
    public TMP_InputField inputField;

    public Sprite[] characterSprite;

    public Image seletedChracter;

    public void ChoiceCharacter(int num)
    {
        seletedChracter.sprite = characterSprite[num];
        DataManger.Instance.characterNum = num;
    }

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
