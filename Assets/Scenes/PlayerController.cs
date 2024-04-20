using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Скорость движения персонажа
   
    public float attackCooldown = 1f; // Время между атаками
    public float maxEnergy = 100f; // Максимальное количество энергии
    public float energyConsumptionRate = 10f; // Скорость расхода энергии

    private Rigidbody2D rb;
    private float nextAttackTime = 0f;
    private float currentEnergy;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentEnergy = maxEnergy;
    }

    private void Update()
    {
        // Получаем ввод от клавиш W, A, S, D
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput, 0f) * speed * Time.deltaTime;
        rb.velocity = new Vector2(movement.x, rb.velocity.y);

        // Расходуем энергию при движении
        currentEnergy -= energyConsumptionRate * Mathf.Abs(horizontalInput) * Time.deltaTime;

       

        // Атака
        if (Input.GetMouseButtonDown(0) && Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + attackCooldown;
        }
    }

    private void Attack()
    {
        // Здесь добавьте логику атаки (например, анимацию, нанесение урона и т. д.)
        Debug.Log("Атака!");
    }

    private void FixedUpdate()
    {
        // Пополнение энергии (например, отдых или использование предметов)
        currentEnergy = Mathf.Clamp(currentEnergy + Time.fixedDeltaTime, 0f, maxEnergy);
    }
}
