
using UnityEngine;
using UnityEngine.SceneManagement;


public class main_menu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }


}
