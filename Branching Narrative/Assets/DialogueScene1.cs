using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1 : MonoBehaviour {
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

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               ArtChar1.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "Narrator";
                Char1speech.text = "You wake up on a Sunday morning. You are supposed to meet your boyfriend for lunch. There is still a fair bit of time before that happens.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 3){
                Char1name.text = "Phone";
                Char1speech.text = "Ring--Ring--";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 4){
                Char1name.text = "Mom";
                Char1speech.text = "Honey, I cut some sweet fruit for you, if you want some.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 5){
                Char1name.text = "You";
                Char1speech.text = "Thanks mom! Btw I’m meeting my bf for lunch later.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 6){
                Char1name.text = "Mom";
                Char1speech.text = "Good, you're finally getting some fresh air!";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 7){
                Char1name.text = "You";
                Char1speech.text = "HA HA very funny.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==8){
                ArtChar1.SetActive(true);
                Char1name.text = "Narrator";
                Char1speech.text = "So you decide to make some breakfast. Do you eat the fruit your mom bought you or eat the  4 day old turkey pie?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
                 // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
       else if (primeInt == 9){
                Char1name.text = "Narrator";
                Char1speech.text = "You eat the turkey pie, at least it's not the worst thing for you.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 10){
                Char1name.text = "Narrator";
                Char1speech.text = "Well, that ate up the morning. Guess I'll go see Christoff.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==11){
                Char1name.text = "Narrator";
                Char1speech.text = "After hanging around your apartment, You realize it's noon. You leave for lunch.";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "Jeda";
                Char1speech.text = "Then you are no use to me, and must be silenced.";
                Char2name.text = "";
                Char2speech.text = "";     
        }
       else if (primeInt == 101){
                Char1name.text = "Jeda";
                Char1speech.text = "Come back here! Do not think you can hide from me!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "Jeda";
                Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
                Char2name.text = "";
                Char2speech.text = "";               
        }
       else if (primeInt == 201){
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
        public void Choice1aFunct(){
                Char1name.text = "You";
                Char1speech.text = "Yum-- that was a lot of turkey with that pie!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 8;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "You";
                Char1speech.text = "Yeah, probably a good idea to satrt with some fruit.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 3;
                Choice1a.SetActive(false);
                Choice1b.SetActive(true);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange2a(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene2b");
        }
}