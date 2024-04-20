using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Скорость движения персонажа

    private void Update()
    {
        // Получаем ввод от клавиш W, A, S, D
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Вычисляем вектор движения
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // Применяем движение к позиции персонажа
        transform.Translate(movement);
    }
}
