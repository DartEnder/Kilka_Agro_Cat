using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelector : MonoBehaviour
{
    public void SetDifficulty(string difficulty)
    {
        // Здесь вы можете обработать выбранную сложность
        // Например, сохранить ее в статической переменной или PlayerPrefs

        // Загрузка сцены в зависимости от выбранной сложности
        switch (difficulty)
        {
            case "Easy":
                SceneManager.LoadScene("EasyLevel");
                break;
            case "Medium":
                SceneManager.LoadScene("MediumLevel");
                break;
            case "Hard":
                SceneManager.LoadScene("HardLevel");
                break;
            default:
                Debug.LogError("Неизвестная сложность: " + difficulty);
                break;
        }
    }
}
