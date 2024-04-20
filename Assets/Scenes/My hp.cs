using UnityEngine;

public class DynamicDifficultyManager : MonoBehaviour
{
    public float baseDifficulty = 1f; // Базовая сложность
    public float difficultyIncreaseRate = 0.1f; // Скорость увеличения сложности
    public float difficultyDecreaseRate = 0.05f; // Скорость снижения сложности

    private float currentDifficulty;

    private void Start()
    {
        currentDifficulty = baseDifficulty;
    }

    private void Update()
    {
        // Здесь вы можете добавить логику для оценки успехов игрока
        // Например, проверять количество убитых врагов, пройденные уровни и т. д.

        // Пример: если игрок успешен, увеличиваем сложность
        if (PlayerIsSuccessful())
        {
            currentDifficulty += difficultyIncreaseRate * Time.deltaTime;
        }
        else
        {
            currentDifficulty -= difficultyDecreaseRate * Time.deltaTime;
        }

        // Ограничиваем сложность в пределах разумных значений
        currentDifficulty = Mathf.Clamp(currentDifficulty, 0.5f, 2f);

        // Применяем текущую сложность к игре
        ApplyDifficulty();
    }

    private bool PlayerIsSuccessful()
    {
        // Здесь реализуйте свою логику для определения успехов игрока
        // Например, проверьте, сколько врагов было убито, сколько очков набрано и т. д.
        // Верните true, если игрок успешен, и false в противном случае.
        return true; // Заглушка, замените на свою логику
    }

    private void ApplyDifficulty()
    {
        // Здесь примените текущую сложность к параметрам игры
        // Например, увеличьте скорость врагов, уменьшите здоровье игрока и т. д.
        Debug.Log($"Текущая сложность: {currentDifficulty}");
    }
}
