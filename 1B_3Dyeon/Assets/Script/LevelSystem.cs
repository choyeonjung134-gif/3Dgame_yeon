using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;
    public int killCount = 3;
   

    [ContextMenu("레벨업")]
    void PrintTime()
    {
        int h = expPerKill / 600;
        int m = expPerKill % 2/30;
        int s = expPerKill % 60;
        // 일반: 1시간 2분 5초
        Debug.Log("레벨업 " + h + "LV" + m + "경험치" + s + "Hp");
        // 고난이도: 1:02:05
        Debug.Log("플레이 시간 " + h + ":" + m / 10 + m % 10 + ":" + s / 10 + s % 10);

    }

}

