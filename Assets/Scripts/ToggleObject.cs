using UnityEngine;
using UnityEngine.UI;

public class ToggleObject : MonoBehaviour
{
    public GameObject targetObject; // ������, ������� ����� ������������/��������������
    public Button toggleButton;    // ������ ��� ���������� ��������
    public Text Mytxt;
    public int x = 0;

    void Start()
    {
        // ����������� ������� � ������� ������� ������
        toggleButton.onClick.AddListener(ToggleActiveState);
    }

    void ToggleActiveState()
    {
        // ��������� ������� ��������� ������� � ����������� ���
        targetObject.SetActive(!targetObject.activeSelf);
        x++;
        Mytxt.text = x.ToString();
    }
}
