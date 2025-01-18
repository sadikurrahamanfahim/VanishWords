using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PrintScript : MonoBehaviour
{
    public GenerateChar englishChar;
    public TextMeshProUGUI[] textMeshes;
    public List<char> sortedAlphabet = new List<char>();

    private void OnEnable()
    {
        List<char> randomAlphabet = englishChar.GenearteRandomAlphabet(textMeshes.Length);
        SetText(randomAlphabet);
        randomAlphabet.Sort();
        sortedAlphabet = randomAlphabet;
    }

    void SetText(List<char> words)
    {
        for (var i = 0; i < words.Count; i++)
        {
            textMeshes[i].text = words[i].ToString();
        }
    }

    public void OnButtonClick(TMP_Text tmp)
    {
        if (tmp.text == sortedAlphabet[0].ToString())
        {
            tmp.gameObject.SetActive(false);
            sortedAlphabet.RemoveAt(0);
            if (sortedAlphabet.Count == 0)
            {
                SceneManager.LoadScene("MainGame");
            }
        }
    }
}