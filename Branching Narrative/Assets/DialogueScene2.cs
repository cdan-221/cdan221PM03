using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2 : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "Narrator";
            Char1speech.text = "You arrive at his house where you are scheduled to meet at.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boyfriend";
            Char2speech.text = "Hey babe, I guess you are hungry, lets go have some pizza.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "You’ve been cheating on your diet a lot this week and maybe you’re better off changing where you’re eating today. .";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "You start having second thoughts about your choice.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "Something that's more healthy...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "But you haven't eaten pizza for a while...our boyfriend notices you spacing out.";
            Char2name.text = "Boyfriend";
            Char2speech.text = "What’s wrong, babe? You don't want pizza? We could always have something else";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "Narrator";
            Char1speech.text = "It’s nothing. This is what we decided to eat, and I know you like pizza. I don’t want to change it";
            Char2name.text = "Boyfriend";
            Char2speech.text = "How about salad?";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "Jeda";
            Char1speech.text = "Then you are no use to me, and must be silenced.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "Jeda";
            Char1speech.text = "Come back here! Do not think you can hide from me!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "Jeda";
            Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "You";
        Char2speech.text = "I don't know what you're talking about!";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "You";
        Char2speech.text = "Sure, anything you want... just lay off the club.";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene2a");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene2b");
    }
}
