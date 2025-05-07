using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class OpenDiolouge : MonoBehaviour
{
    //this is the diolouge script that opends on start

    bool talking;
    bool notTalking;

    public Text dialogueText;
    public GameObject Pannel;

    public string[] dialogueLines;

    public float textSpeed = 0.05f;
  //  public GameObject fullSprite; //this helps the box dissapear (i oriiginally used it to switch sprites during diolouge scenes)

   // public GameObject Choices; // really hoping this works (adding the choices to the end of the set of diolouge hoping to continue it from there.. it makes sence in my head- just go with it)

    private int currentLineIndex = 0;
    private bool isTyping = false;
    private bool dialogueActive = false;

    private void Start()
    {
        Pannel.SetActive(false);

        StartDialogue();

        //Choices.SetActive(false);
    }
    void Update()
    {
        noMovement();
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            if (isTyping)
            {
                // If the player presses Space while text is typing this finishes the line instantly
                StopAllCoroutines();
                dialogueText.text = dialogueLines[currentLineIndex];
                isTyping = false;
            }
            else
            {
                // Show the next line of dialogue
                NextLine();
            }
        }
    }

    public void StartDialogue()
    {
        talking = true;
        // this activateas the dialogue box and starts the first line
        // pressT.SetValue(true);
        Pannel.SetActive(true);
        dialogueActive = true;
       // fullSprite.SetActive(true);
        currentLineIndex = 0;
        StartCoroutine(TypeLine());
    }

    void NextLine()
    {
        currentLineIndex++;
        if (currentLineIndex < dialogueLines.Length)
        {
            StartCoroutine(TypeLine());
        }
        else
        {
            // End the dialogue when all lines are shown
            EndDialogue();
        }
    }

    IEnumerator TypeLine()
    {
        isTyping = true;
        dialogueText.text = "";

        // Type each character one by one
        foreach (char c in dialogueLines[currentLineIndex].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

        isTyping = false;
    }

    void EndDialogue()
    {
        notTalking = true;
        talking = false;
        Pannel.SetActive(false);
        dialogueActive = false;
        
        //fullSprite.SetActive(false);

        // Choices.SetActive(true);


    }

    private void noMovement()
    {
        if (talking == true)
        {
     
            Debug.Log("Talking");
           //Time.timeScale = 0.001f;
        }
        if (notTalking == true)
        {
     
          
            Debug.Log("Not Talking");
            //Time.timeScale = 1f;
        }
    }
}
