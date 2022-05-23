using TMPro;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    [SerializeField] private TMP_Text usernameText;

    private void Awake() {
        GameSession.Reset();
    }

    public void StartGame() {
        GameSession.username = usernameText.text;
        SceneManager.LoadScene(SceneUtility.GameplaySceneIndex);
    }

    public void QuitGame() {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
