using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private void OnApplicationQuit()
    {
        // Здесь вызовите ваш метод сохранения
        SaveGame();
    }

    private void SaveGame()
    {
        // Ваш код сохранения игры
        // Например, используйте PlayerPrefs или другие методы сохранения данных
        // Не забудьте сохранить позицию персонажа, состояние игры и другие важные параметры
        Debug.Log("Игра сохранена перед выходом.");
    }
}
