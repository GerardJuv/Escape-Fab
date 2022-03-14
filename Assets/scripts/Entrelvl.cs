using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Entrelvl : MonoBehaviour
{
    public GameObject Ascensor;
    public Button Boton;
    public Image Fade;
    public Canvas botoncicos;

    public int LeveltoUnlock = 2;



    void OnTriggerEnter(Collider obj)
    {
        PlayerPrefs.SetInt("levelReached", LeveltoUnlock);
        Ascensor.GetComponent<Animator>().SetTrigger("Activar");
        Fade.GetComponent<Animator>().SetTrigger("Final");
        Invoke("Canvaaas", 5); 
        if (SceneManager.GetActiveScene().buildIndex == 4) {
              Boton.gameObject.SetActive(false);
           }
    }

    public void Canvaaas()
    {
        botoncicos.gameObject.SetActive(true);
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("0-Menu");
        Advertisement.Show();
    }
        public void LvlSelect()
    {
        SceneManager.LoadScene("1-LvlSelect");
        Advertisement.Show();
    }
    public void Nextlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Advertisement.Show();
    }
        
}
