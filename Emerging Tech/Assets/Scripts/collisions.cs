using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collisions : MonoBehaviour
{

    int score = 0;
    public Text scoreText;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Food(Clone)")
        {
            Destroy(col.gameObject);
            score++;
        }
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

}