using UnityEngine;

public class StatPractice : MonoBehaviour
{
    [ContextMenu("스탯")]
    void ShowStat()
    {
        Debug.Log("Stat");
    }

    public int level = 100;
    public float attack = 10;
    public bool isBoss = false;
    public string PlayerName = "PlayerName";

    void Start()
    {
        Debug.Log(attack);
    }

    void Update()
    {
        
    }
}
