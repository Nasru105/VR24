using UnityEngine;
using UnityEngine.UI; // Пространство имен для работы с Legacy Text

public class CollisionCounter : MonoBehaviour
{
    public Text scoreText; // Поле для Legacy Text
    public int score = 10; // Начальное значение счётчика

    void Start()
    {
        // Установить начальный текст
        UpdateScoreText();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Уменьшаем счётчик при столкновении
        score--;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        // Обновляем текст на UI
        scoreText.text = "Счетчик: " + score;
    }
}
