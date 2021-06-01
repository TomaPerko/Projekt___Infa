using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    
   public void ZapocniIgru()
    {
        //ucitava iducu scenu u slijedu kojeg smo odredili u unityu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
    }
    public void ZatvoriIgru()
    {
        //izlaz iz aplikacije
        Application.Quit();
    }
}
