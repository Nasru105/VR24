using UnityEngine;
using UnityEngine.UI; // ������������ ���� ��� ������ � Legacy Text

public class CollisionCounter : MonoBehaviour
{
    public Text scoreText; // ���� ��� Legacy Text
    public int score = 10; // ��������� �������� ��������

    void Start()
    {
        // ���������� ��������� �����
        UpdateScoreText();
    }

    void OnCollisionEnter(Collision collision)
    {
        // ��������� ������� ��� ������������
        score--;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        // ��������� ����� �� UI
        scoreText.text = "�������: " + score;
    }
}
