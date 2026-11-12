using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack;
    public int defense;

    private bool isCritical;
    private bool targetIsBoss;

 [ContextMenu("데미지")]
    void Calc()
    {
        int damage = attack - defense;
     damage = Mathf.Max(damage, 1);
        // damage = damage<1 ? 1 :damage;
        if(isCritical)
        {
            damage = damage * 2;
        }
        if(targetIsBoss)
        {
            damage = damage / 2;

        }
        Debug.Log(damage);
    }

    [ContextMenu("예측 3")]
    void Predict3()
    {
        for (int i = 0; i < 3; i++) Debug.Log(i);
        for (int i = 1; i <= 10; i += 3) Debug.Log(i);
        for (int i = 5; i > 0; i -= 2) Debug.Log(i);
        int sum = 0;
        for (int i = 1; i <= 4; i++) sum += i;
        Debug.Log(sum);
    }

    [ContextMenu("격자")]
    void Grid()
    {
        string text = "";
        for (int row = 1; row <= 2; row++)
        {
            for (int col = 1; col <= 3; col++)
            {
                text += row + "-" + col + " ";
            }
            text += "\n";                            // backspace 아래 있는 원화 버튼
        }
        Debug.Log(text);
    }

    [ContextMenu("계단")]
    void Stairs()
    {
        int Heigh = 3;
        string result = "";
        for (int row = 1; row <= Heigh; row++)
        {
            for (int col =  0; col < row; col++)
            {
                result += "";
            }
            result += "/n";
        }
        Debug.Log(result);

    }
}
