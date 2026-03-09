using UnityEngine;
using System.Collections.Generic;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public int score;
    public List<string> shading;
    public List<string> shape;
    public List<string> color;
    public List<int> number;
    public List<GameObject> cards;
   public int trueDeck;
    public GameObject decks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CompleteSet()
    { 
       
        for(int i = 0; i < 3; i++)
        {
        score++;
         decks.GetComponent<Deck>().deck =  decks.GetComponent<Deck>().deck - 1;
         Instantiate(cards[Random.Range(0,80)], new Vector3(i,i,i), Quaternion.identity);
        }
    }
}