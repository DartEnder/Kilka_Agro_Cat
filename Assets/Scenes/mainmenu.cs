using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void PlayButtonClicked()
    {
        // Логика для кнопки "Играть"
        Debug.Log("Игра началась!");
    }

    public void SettingsButtonClicked()
    {
        // Логика для кнопки "Настройки"
        Debug.Log("Открыты настройки");
    }

    public void ExitButtonClicked()
    {
        // Логика для кнопки "Выход"
        Application.Quit();
    }
}
