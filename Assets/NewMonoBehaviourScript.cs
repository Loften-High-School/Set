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
    public int fireball;
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
        for(int i; i < 3; i++)
        {
        score++;
        string objectShape = shape[Random.Range(0,2)];
        string objectShading = shading[Random.Range(0,2)];
        string objectColor = color[Random.Range(0,2)];
        int objectNumber = number[Random.Range(0,2)];
        fireball++;
        if(objectShading == "clear")
        {
            if(objectShape == "diamond")
            {
                if(objectColor == "red")
                {
                    if(objectNumber == 1)
                    {
                        Instantiate(cards[0], 0f, 0f, 0f);
                    }
                }
            }
        }
        }
    }
}
