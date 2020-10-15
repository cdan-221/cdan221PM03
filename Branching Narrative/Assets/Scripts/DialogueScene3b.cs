using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3b : MonoBehaviour {
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
                Char1name.text = "You";
                Char1speech.text = "I'll choose salad.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Salad?! Are you joking?!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "You";
                Char1speech.text = "No, I’m seriously having a diet these days.";
                Char2name.text = "";
                Char2speech.text = "";
        }
         else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Ummm...Ok? That's a challenge for me! *laughs* It’s your day today, babe!";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Babe, I was really banking on swallowing an entire pie this morning. But, I know how important this diet is for you. There’s a cafeteria with a salad bar across the street. Let’s go there.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 7){
                Char1name.text = "Narrator";
                Char1speech.text = "-You order a small size ceaser salad-";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==8){
                Char1name.text = "You";
                Char1speech.text = "Yum-- that was a lot of fresh lettuce with that salad!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Yeh...but I’m still hungry, eating grass is not enough for me, do you want to have some dessert?";
        }
        else if (primeInt ==10){
                Char1name.text = "You";
                Char1speech.text = "Of course, why not.";
                Char2name.text = "";
                Char2speech.text = "";
                 nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
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
        public void Choice1bFunct(){
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

        public void SceneChange2a(){
               SceneManager.LoadScene("Scene4");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene4");
        }
}
