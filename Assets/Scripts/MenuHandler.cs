using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{

    private TextMeshProUGUI ScoreText;

    private void Start()
    {
        ScoreManager.Instance.LoadHighScore();
        ScoreText = GameObject.Find("Highest Score Text").GetComponent<TextMeshProUGUI>();
        ScoreText.text = "Highest Score: " + ScoreManager.Instance.playerName + " : " + ScoreManager.Instance.HighScore;
    }

    public void StartNew()
    {
        ScoreManager.Instance.currentPlayerName = GameObject.Find("PlayerNameText").GetComponent<TextMeshProUGUI>().text;
        // Load the main scene
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
