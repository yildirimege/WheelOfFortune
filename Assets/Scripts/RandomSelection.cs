using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSelection : MonoBehaviour
{
    public GameObject sq1, sq2, sq3, sq4, sq5, sq6, sq7, sq8, sq9, unlockButton;


    public Color32 defaultColor;
    public Color32 frameColor;
    int counter=0;
    public float traverseSpeedIncrease = 0.1f;
    public float traverseSpeed =0.01f;
   
  


    int previousNumber =10;
    int randomNumber = 0;
   




    // Start is called before the first frame update
    void Start()
    {
        ResetBoxColors();
    }

    public IEnumerator FrameTraverse()
    {
        while ( counter <=12)
        {

            randomNumber = RandomNumberGenerator(0, 9);
            if (randomNumber != previousNumber) // to avoid checking the same frame 2 times in a row.
            {
                ResetBoxColors();

                ColorChange(randomNumber);
                previousNumber = randomNumber;
                yield return new WaitForSeconds(traverseSpeed);
                traverseSpeed += traverseSpeedIncrease;
                counter++;
            }
        }
        

    }


    public void ButtonIsClicked()
    {
        StartCoroutine(FrameTraverse());
        unlockButton.GetComponent<Button>().enabled = false;
       


       
    }


    // Update is called once per frame
    void Update()
    {
      
        if (counter > 11) StopCoroutine(FrameTraverse());
                
    }


    public int RandomNumberGenerator(int min, int max)
    {
        int random = 0;

        random = Random.Range(min, max) % 9; // Will be used in random selection of frames. MAX IS EXCLUDED!
        return random;
    }

    public void ResetBoxColors()
    {
        sq1.GetComponent<Image>().color = Color.gray;
        sq2.GetComponent<Image>().color = Color.gray;
        sq3.GetComponent<Image>().color = Color.gray;
        sq4.GetComponent<Image>().color = Color.gray;
        sq5.GetComponent<Image>().color = Color.gray;
        sq6.GetComponent<Image>().color = Color.gray;
        sq7.GetComponent<Image>().color = Color.gray;
        sq8.GetComponent<Image>().color = Color.gray;
        sq9.GetComponent<Image>().color = Color.gray;



    }
   

    void ColorChange(int num)
    {
        
        switch (num)
        {
            case 0:
                sq1.GetComponent<Image>().color = Color.green;
                break;
            case 1:
                sq2.GetComponent<Image>().color = Color.green;
                break;
            case 2:
                sq3.GetComponent<Image>().color = Color.green;
                break;
            case 3:
                sq4.GetComponent<Image>().color = Color.green;
                break;
            case 4:
                sq5.GetComponent<Image>().color = Color.green;
                break;
            case 5:
                sq6.GetComponent<Image>().color = Color.green;
                break;
            case 6:
                sq7.GetComponent<Image>().color = Color.green;
                break;
            case 7:
                sq8.GetComponent<Image>().color = Color.green;
                break;
            case 8:
                sq9.GetComponent<Image>().color = Color.green;
                break;




        }
       



    }

   

}
