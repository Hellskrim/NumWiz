using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int guess;

    public Text numberGuess;

    int maxGuess = 7;

    void Start () {
        max = 1000;
        min = 1;
        nextGuess();
    }

    public void getHeigher()
    {
        min = guess;
        nextGuess();
    }
    public void getLower()
    {
        max = guess;
        nextGuess();
    }
    void nextGuess()
    {
        guess = Random.Range(min,max+1);
        numberGuess.text = "Is that "+guess.ToString()+"?";
        maxGuess--;
        if (maxGuess <= 0) { SceneManager.LoadScene("Win"); }
    }
    public void isEqual()
    {
        SceneManager.LoadScene("Lose");
    }
}
