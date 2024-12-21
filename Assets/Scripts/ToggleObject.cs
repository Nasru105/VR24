using UnityEngine;
using UnityEngine.UI;

public class ToggleObject : MonoBehaviour
{
    public GameObject targetObject; // ������, ������� ����� ������������/��������������
    public Button toggleButton;    // ������ ��� ���������� ��������

    void Start()
    {
        // ����������� ������� � ������� ������� ������
        toggleButton.onClick.AddListener(ToggleActiveState);
    }

    void ToggleActiveState()
    {
        // ��������� ������� ��������� ������� � ����������� ���
        targetObject.SetActive(!targetObject.activeSelf);
    }
}
