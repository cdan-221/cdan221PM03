using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene10 : MonoBehaviour {
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
               ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "That was a great day!";
        }
        else if (primeInt == 3){
               ArtChar1.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "Ya it was, I had a lot of fun!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Should we end the day with dessert?";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt ==5){
                Char1name.text = "You";
                Char1speech.text = "Oh that sounds great!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Oh look, you have cookies! That seems like a great dessert to me!";
        }
         else if (primeInt == 7){
                Char1name.text = "You";
                Char1speech.text = "Oh, I don't know if I should end the day with a treat? Or keep up with my diet and end strong...";
                Char2name.text = "";
                Char2speech.text = "";
        }
         else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "That's up to you babe, I'm going to eat this cookie though.";
        }
       else if (primeInt == 10){
                Char1name.text = "You";
                Char1speech.text = "I'm either going to have a cookie with you or this delicious fruit...";
                Char2name.text = "";
                Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
       else if (primeInt == 6){
                Char1name.text = "Jeda";
                Char1speech.text = "I am searching for a fugitive. Ragu Fahn.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Why do you think I know anything?";
        }
       else if (primeInt == 8){
                Char1name.text = "Jeda";
                Char1speech.text = "Do not play the stupid. You will take me to him.";
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "ya it’s probably because instead of treating yourself to one cookie you ate 10…";     
        }
       else if (primeInt == 101){
                Char1name.text = "You";
                Char1speech.text = "i think i'm going to be sick…";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "You";
                Char1speech.text = "ya it was hard but im happy i stuck with it through the end!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "oh I do not feel very good";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Boyfriend";
                Char1speech.text = "I'm so proud of you keeping up with your diet I'm sure you feel great!!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange2a(){
               SceneManager.LoadScene("end_lose");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("end_win");
        }
}