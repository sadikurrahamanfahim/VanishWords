using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GenerateChar
{
    public string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public List<char> GenearteRandomAlphabet(int count)
    {
        List<char> alphabetList = new List<char>(alphabet);
        List<char> randomAlphabet = new List<char>();
        int index = 0;
        for (int i = 0; i < count; i++)
        {
            index = UnityEngine.Random.Range(0, alphabetList.Count);
            randomAlphabet.Add(alphabetList[index]);
            alphabetList.RemoveAt(index);
        }
        return randomAlphabet;
    }
}
