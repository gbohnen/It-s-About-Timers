using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

	public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }

    public void CalibrationButton()
    {
        SceneManager.LoadScene(1);
    }

    public void TestingButton()
    {

    }
}
