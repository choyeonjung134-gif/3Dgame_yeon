using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 0;
        bool hasShield = true;
        bool isDead = hp <= 0;
        Debug.Log(isDead);
        Debug.Log(isDead && !hasShield);
        Debug.Log(isDead || hasShield);
        Debug.Log(!(hp > 0) == isDead);
    }

    [ContextMenu("쇼트 서킷")]
    void ShortCircuit()
    {
        int total = 100;
        int count = 0;
        if (count != 0 && total / count > 5)
        {
            Debug.Log("평균 5 초과");
        }
        if (count == 0 || total / count > 5)
        {
            Debug.Log("통과");
        }
        bool wrong = total / count > 5 && count != 0;
    }

    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;

        bool canAttack = hp > 0 && !isStunned;
        bool isDanger = hp <= maxHp / 4 || hasPoison;
        Debug.Log(canAttack);
        Debug.Log(isDanger);
    }
    [ContextMenu("if else")]
    void IfElse()
    {
        int hp = 3;
        if (hp <= 0)
        {
            Debug.Log("사망");
        }
        else
        {
            Debug.Log("생존");
        }
    }

    [ContextMenu("체력 상태")]
    void HpState()
    {
        int hp = 5;
        int maxHp = 10;
        float ratio = (float)hp / maxHp;
        if (ratio >= 0.7f)
        {
            Debug.Log("양호");
        }
        else if (ratio >= 0.3f)
        {
            Debug.Log("주의");
        }
        else
        {
            Debug.Log("위험");
        }
    

}

[ContextMenu("예측 2")]
    void Predict2()
    {
        int score = 95;
        if (score >= 60) Debug.Log("C");
        else if (score >= 80) Debug.Log("B");
        else if (score >= 90) Debug.Log("A");

        if (score >= 90) Debug.Log("A");
        if (score >= 80) Debug.Log("B");
        if (score >= 60) Debug.Log("C");
    }

    [ContextMenu("중괄호")]
    void Braces()
    {
        int hp = 10;
        if (hp <= 0)
            Debug.Log("사망");
        Debug.Log("게임 오버");

        if (hp <= 0)
        {
            Debug.Log("사망");
            Debug.Log("게임 오버");
        }
    }


}



