using UnityEngine;
using UnityEngine.UI;

public class ToggleObject : MonoBehaviour
{
    public GameObject targetObject; // Объект, который нужно активировать/деактивировать
    public Button toggleButton;    // Кнопка для выполнения действия

    void Start()
    {
        // Привязываем функцию к событию нажатия кнопки
        toggleButton.onClick.AddListener(ToggleActiveState);
    }

    void ToggleActiveState()
    {
        // Проверяем текущее состояние объекта и переключаем его
        targetObject.SetActive(!targetObject.activeSelf);
    }
}
