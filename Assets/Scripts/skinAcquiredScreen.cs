using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skinAcquiredScreen : MonoBehaviour

{

    public Texture[] skins;
    public Button unlockButton;
    public Button returnButton;
    public GameObject text;
    public GameObject panel;
    public GameObject skin;
    public float sec = 5.5f;


    public void ButtonClickShowPanel()
    {
        StartCoroutine(ShowPanel());



    }

    public void Return()
    {
        
        SceneManager.LoadScene("CaseScene");

        

    }
  
    // Start is called before the first frame update
    void Start()
    {
        panel.GetComponent<Image>().enabled = false;
        text.SetActive(false);
        GetComponent<MeshRenderer>().enabled = false;
        returnButton.GetComponent<Button>().enabled = false;
        returnButton.GetComponent<Image>().enabled = false;


    }

    public void showSkin()
    {
        int skinNumber = Random.Range(0, 9);
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<MeshRenderer>().material.mainTexture = skins[skinNumber];
        




    }

    IEnumerator ShowPanel()
    {



        yield return new WaitForSeconds(sec);
        panel.GetComponent<Image>().enabled = true;
        text.SetActive(true);
        returnButton.GetComponent<Button>().enabled = true;
        returnButton.GetComponent<Image>().enabled = true;
        showSkin();
      



    }

  

    // Update is called once per frame
    void Update()
    {
        
    }
}
