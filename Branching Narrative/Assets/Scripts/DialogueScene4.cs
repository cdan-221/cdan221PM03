using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4 : MonoBehaviour {
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
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Narrator";
            Char3speech.text = "After 15 minutes walk you and Christoff finally found a coffee shop on the corner of the street.";

        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Christoff";
            Char2speech.text = "Well that was great? Damn, I am seriously craving some caffeine right now.” You wanna grab coffee?";
            Char3name.text = "";
            Char3speech.text = "";
		//gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Narrator";
            Char3speech.text = "You are attracted by the cakes in the dessert cabinet. So you didn’t hear what Christoff says.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Narrator";
            Char3speech.text = "Your boyfriend notices you spacing out again.";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Christoff";
            Char2speech.text = "Babe, are you listening?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "You";
            Char1speech.text = "Ohh, yes of course, coffee…...Christoff you see those cakes? They look delicious…";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "You";
            Char1speech.text = "I know we just finished our lunch, but…";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Christoff";
            Char2speech.text = "Sounds like we’re not leaving without having a piece of cake. Again, it’s your day today babe.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "Coffee Guy";
            Char1speech.text = "Hi, what can I get for you today?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()

        }


        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Christoff";
            Char2speech.text = "Aren't you on a diet?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Christoff";
            Char2speech.text = "Aren't you on a diet? I think..umm.. maybe you should go to your yoga class today?";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Christoff";
            Char2speech.text = "Nice! I need to satisfy my coffee demons. Let’s go!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
	Char3name.text = "Narrator";
            Char3speech.text = "You both go to your favorite cafe. The smell of stressed out college kids on overpriced laptops and exposed brick walls emanates throughout the store.";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Narrator";
            Char3speech.text = "You now have the energy of an unattended 13 year old boy. Your body may or may not also be vibrating uncontrollably.";
        }
         else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
	Char3name.text = "Narrator";
            Char3speech.text = "You both relax and get comfortable in the cafe. You feel safe with your boyfriend and would do anything to feel like this forever. As you sink further into the booth seat, your boyfriend asks…";
        }
        else if (primeInt == 204)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Christoff";
            Char2speech.text = "Hey! Have you seen Revengers: Endless Tussle yet? That movie was the best of the whole series!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 205)
        {
            Char1name.text = "You";
            Char1speech.text = "No, I haven’t you know I don’t care for movies like that.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 206)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Christoff";
            Char2speech.text = "C’mon! I can catch you up on all the lore in the car. The movie is only 4 hours!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 207)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
	Char3name.text = "Narrator";
            Char3speech.text = "You decide to go to the movies. You think it’s good your boyfriend is passionate about something. Even if it is watching Incredible Fella fight Regular Raccoon…again.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "You";
                Char1speech.text = "I don't know what you're talking about!";
                Char2name.text = "";
                Char2speech.text = "";
            	Char3name.text = "";
            	Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "You";
                Char1speech.text = "I’m down, and we just had lunch so let's grab coffee and go somewhere else!";
                Char2name.text = "";
                Char2speech.text = "";
            	Char3name.text = "";
            	Char3speech.text = "";
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
                SceneManager.LoadScene("Scene5");
        }
}
