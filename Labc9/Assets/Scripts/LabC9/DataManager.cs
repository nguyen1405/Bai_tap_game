using UnityEngine;

public class DataManager : MonoBehaviour
{
    PlayerData data = new PlayerData();

    public void SaveData()
    {
        data.score = 100;
        data.level = 2;

        string json = JsonUtility.ToJson(data);

        PlayerPrefs.SetString("player", json);
        PlayerPrefs.Save();

        Debug.Log("Saved JSON: " + json);
    }

    public void LoadData()
    {
        string json = PlayerPrefs.GetString("player", "");

        if (json != "")
        {
            PlayerData loadedData = JsonUtility.FromJson<PlayerData>(json);

            Debug.Log("Score: " + loadedData.score);
            Debug.Log("Level: " + loadedData.level);
        }
        else
        {
            Debug.Log("No data found!");
        }
    }
}