 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3a : MonoBehaviour {
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
                Char1speech.text = "What are you saying? You know I like pizza.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Well OK...What toppings do you want? There's Hawaiian, Bacon and Ham and...";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "You";
                Char1speech.text = "Of course the ham and bacon...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "...and don't forget the sides! I need BBQ chicken!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "Christoff";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Christoff";
                Char2speech.text = "Umm OK? I'll be right back...";
        }
       else if (primeInt == 8){
                Char1name.text = "Narrator";
                Char1speech.text = " -You both sit down and get a large pizza to split.-";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
         else if (primeInt == 9){
                Char1name.text = "Narrator";
                Char1speech.text = " -You feel your conscience telling you No...";
                Char2name.text = "";
                Char2speech.text = "";
                
        } else if (primeInt == 10){
                Char1name.text = "Narrator";
                Char1speech.text = " -...But, the gooey, greasy goodness of the 'za has seduced you.-";
                Char2name.text = "";
                Char2speech.text = "";
        }
                 else if (primeInt == 11){
                Char1name.text = "Christoff";
                Char1speech.text = "Damn, can't believe we finished all the pizza and sides.";
                Char2name.text = "";
                Char2speech.text = "";
        }
 else if (primeInt == 12){
                Char1name.text = "Christoff";
                Char1speech.text = "I'm stuffed and I think I'm having a food coma, Let's go buy some coffee!";
                Char2name.text = "";
                Char2speech.text = "";
                
        } else if (primeInt == 13){
                Char1name.text = "Christoff";
                Char1speech.text = "I don't want to fall asleep during our date!";
                Char2name.text = "";
                Char2speech.text = "";
        }
                 else if (primeInt == 14){
                Char1name.text = "You";
                Char1speech.text = "OK, Sure.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                
        }

         void SceneChange1a(){
                SceneManager.LoadScene("Scene4");}
}


        


   