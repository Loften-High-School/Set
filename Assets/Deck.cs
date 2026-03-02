using UnityEngine;
using TMPro;
using System;
using UnityEngine.EventSystems;
public class Deck : MonoBehaviour
{
    public int deck;
    public TextMeshProUGUI deckCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseOver()
    {
Debug.Log("Over");
deckCount.text = "There are " + deck + " cards left in the deck";
    }
    void OnMouseExit()
    {
deckCount.text = "";
    }
}