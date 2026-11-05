using UnityEngine;

public class HpPractice : MonoBehaviour
{

    public int currentHp;
    public int maxHp;

    [ContextMenu("체력")]
    void PrintHp()
    {
        int a = currentHp * 100 / maxHp;
        Debug.Log("HP" + a + "%");

      

        Debug.Log("Hp");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
