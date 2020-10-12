using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5 : MonoBehaviour {
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
                dialogue.SetActive(true);
                Char1name.text = "Narrator";
                Char1speech.text = "You arrive at the movie theater. It・s still the early afternoon so it・s pretty quiet and the lines are short. The only other people you can spot are an elderly couple who have probably watched every movie here twenty times over.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "You";
                Char1speech.text = "We are lucky, I thought there will be a lot of people on the weekend.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Maybe people are just worried about the covid so they decided to stay home.";
        }
       else if (primeInt == 5){
                Char1name.text = "You";
                Char1speech.text = "Glad we made the right choice!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                ArtChar1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "No lines, no assigned seats, and 6 dollar tickets. We are living like kings! You want popcorn?";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "Narrator";
                Char1speech.text = "You buy the theatre popcorn and are too embarrassed to tell them not to cover it in salt and cheap liquid butter. You take the bucket and the movie starts.";
                Char2name.text = "";
                Char2speech.text = "";     
        }
        else if (primeInt == 101){
                Char1name.text = "Narrator";
                Char1speech.text = "You get to the scene where Mr. StretchyLimbs starts fighting his clone and can feel your insides churning like an entire laundromat.";
                Char2name.text = "";
                Char2speech.text = "";     
        }
        else if (primeInt == 102){
                Char1name.text = "You";
                Char1speech.text = "Babe, I don't feel good.";
                Char2name.text = "";
                Char2speech.text = "";     
        }
        else if (primeInt == 103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = " *laughs* ：No kidding, you ate the world・s most disgusting popcorn. I gotta buy some food for my place. Wanna do that and I・ll drop you off after?";     
        }
        else if (primeInt == 104){
                Char1name.text = "";
                Char1speech.text = "-After the movie-";
                Char2name.text = "";
                Char2speech.text = "";     
        }
        else if (primeInt == 105){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Man! What a movie. I gotta grab some food for my apartment. You wanna come with me?";     
        }
       else if (primeInt == 106){
                Char1name.text = "You";
                Char1speech.text = "Ok, I need to get something to drink.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "You";
                Char1speech.text = "Babe, I'm on diet!";
                Char2name.text = "";
                Char2speech.text = "";               
        }
        else if (primeInt == 201){
                Char1name.text = "Narrator";
                Char1speech.text = "You sit through the entire 4 hour comic book epic. You have no idea what happened, but you think you had a good time";
                Char2name.text = "";
                Char2speech.text = "";               
        }
        else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Man! What a movie. I gotta grab some food for my apartment. You wanna come with me?";               
        }
       else if (primeInt == 203){
                Char1name.text = "You";
                Char1speech.text = "Ok, I need to get something to drink.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "You";
                Char1speech.text = "I don・t want to sit in the theatre staring at the screen without popcorn for 4 hours.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Are you sure you want to sit in the theatre straing at the screen without popcorn for 4 hours?";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange2a(){
               SceneManager.LoadScene("Scene6");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene6");
        }
}