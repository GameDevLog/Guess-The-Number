using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberScript : MonoBehaviour
{
    public InputField input;
    public Text infoText;
    private int guessNumber;
    private int userGuessNumber;

    void Start()
    {
        guessNumber = Random.Range(0, 100);
    }

    public void CheckGuess()
    {
        userGuessNumber = int.Parse(input.text);

        if (userGuessNumber == guessNumber)
        {
            infoText.text = "You Guessed The Number! You Are A Wizard";
        }
        else if (userGuessNumber > guessNumber)
        {
            infoText.text = "Your Number Is Greater Than The Guess Number";
        }
        else
        {
            infoText.text = "Your Number Is Lower Than The Guess Number";
        }

        input.text = "";
    }
}
