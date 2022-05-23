using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "HighscoreSO", menuName = "Unity-Data-Persistence-Exercise/HighscoreSO", order = 0)]
public class HighscoreSO : ScriptableSingleton<HighscoreSO> {
    public string username;
    public int points;

    public void SaveNewScoreEntry(string usernameEntry, int pointsEntry) {
        if(pointsEntry < points) return;

        username = usernameEntry;
        points = pointsEntry;
    }
}
