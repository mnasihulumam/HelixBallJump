using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{ 
    public GameObject[] characters;
    private int selectorCharacter = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject ch in characters)
        {
            ch.SetActive(false);
        }
        characters[selectorCharacter].SetActive(true);
    }

    public void ChangeCharacter(int newCharacter)
    {
        characters[selectorCharacter].SetActive(false);
        characters[newCharacter].SetActive(true);
        selectorCharacter =  newCharacter;
    } 
}
