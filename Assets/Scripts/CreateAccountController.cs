using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreateAccountController : MonoBehaviour {

    public Button btnCreateAccount;
    public Text lblError;
    public string MainGameScene;
    // Use this for initialization
    void Start()
    {
        btnCreateAccount.onClick.AddListener(DoCreateAccount);
    }

    public void DoCreateAccount()
    {
        SceneManager.LoadScene(MainGameScene);
    }
}