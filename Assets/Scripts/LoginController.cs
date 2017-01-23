using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginController : MonoBehaviour {

    public Button btnLogin;
    public Button btnCreateAccount;
    public string CreateAccountSceneName;
    public Text lblError;
    // Use this for initialization
    void Start () {
        btnLogin.onClick.AddListener(DoLogin);
        btnCreateAccount.onClick.AddListener(GoToCreateAccount);	
	}

    public void DoLogin()
    {
        lblError.text = "Não implementado!" + Random.Range(1, 100);
    }

    public void GoToCreateAccount()
    {
        SceneManager.LoadScene(CreateAccountSceneName);
    }
}
