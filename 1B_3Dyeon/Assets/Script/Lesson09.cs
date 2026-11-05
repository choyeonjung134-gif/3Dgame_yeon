using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    [ContextMenu("Hello")]
    void Hello()
    {
        Debug.Log("Hello");
    }

    [ContextMenu("테스트 1")]
    void Test1()
    {
        int hp = 10;
        Debug.Log(hp);
    }

    [ContextMenu("테스트 2")]
    void Test2()
    {
        int hp = 7;
        Debug.Log(hp);
    }

    public int gold = 100;

    [ContextMenu("골드 보기")]
    void ShowGold()
    {
        Debug.Log(gold);
    }

    [ContextMenu("오버플로")]
    void Overflow()
    {
        int gold = int.MaxValue;
        Debug.Log(gold);
        gold = gold + 1;
        byte red = 255;
        red++;
        Debug.Log(red);
    }

    [ContextMenu("정밀도")]
    void Precision()
    {
        double d = 0.1 + 0.2;
        Debug.Log(d == 0.3);

        float half = 1 / 2;
        Debug.Log(half);
    }


    public int attack = 10; //필드
    int killCount = 0;     //필드

    public string itemName = "포션";
    public int price = 30;
    public float discount = 0.5f;
    public bool isSoldOut = false;

    [ContextMenu("가격")]
    void ShowPrice()
    {
        float finalPrice = price * discount;
        Debug.Log(itemName + " " + finalPrice);
    }




    [ContextMenu("처치")]
    void CountKill()
    {
        int defense = 3;     // 지역 변수
        killCount = killCount + 1;
        Debug.Log(attack - defense);
        Debug.Log(killCount);
    }
    void Start()
    {
        Debug.Log(attack);
    }

    void Hit()
    {
        killCount = killCount + 1;
    }

    [ContextMenu("예측1")]
    void Predict1()
    {
        int hp = 10;
        hp = hp - 3;
        Debug.Log(hp);
        hp = 20;
        Debug.Log(hp);
        int maxHp = hp;
        hp = 5;
        Debug.Log(maxHp);
    }

    [ContextMenu("예측 2")]
    void Predict2()
    {
        int hp = 7;
        int maxHp = 10;
        Debug.Log(hp / maxHp);
        Debug.Log((float)hp / maxHp);
        Debug.Log(hp / 2);
        Debug.Log(hp / 2f);
        Debug.Log(hp % 2);
    }

    [ContextMenu("예측 3")]
    void Perdict3()
    {
        int a = 1;
        int b = 2;
        Debug.Log("합: " + a + b);
        Debug.Log("합: " + (a + b));
        Debug.Log(a + b + "점");
        Debug.Log("HP " + 7 / 2);

    }
}
