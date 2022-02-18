using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    //declaring a variable and intializing it
    private int ramdonNum;
    public InputField userInput;
    public Text gameText;
    public int maxNumber;
    public int minNumber;
    public Button gameButton;
    public Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        gameText.text="Guess a number between "+minNumber+" and "+(maxNumber-1);
        ramdonNum = GetRandomNumber(minNumber,maxNumber);
        restartButton.interactable=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonClick() {

        string userInputValue = userInput.text;

        if (userInputValue != "")
        {
            int answer = int.Parse(userInputValue);

            if (answer == ramdonNum)
            {
               gameText.text = "Correct";
                gameButton.interactable = false;
                restartButton.interactable = true;
           
            }
            else if (answer > ramdonNum)
            {
                gameText.text="Lower";
            }
            else
            {
                gameText.text="Higher";
            }
        }
        else {
            gameText.text="Please Enter a Number ";
        }
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private int GetRandomNumber(int min, int max) {
        int random = Random.Range(min, max);
        Debug.Log("Max is " + max);
        Debug.Log("Min is " + min);
        return random;
    }
}
