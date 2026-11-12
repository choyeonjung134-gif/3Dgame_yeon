using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerkill = 35;
    public int totalDamege = 250;
    public int hits = 20;


    public float expRate = 1.5f;


    [ContextMenu("플레이 시간")]
    void PrintTime()
    {
        int h = playSeconds / 3600;
        int m = playSeconds % 3600 / 60;
        int s = playSeconds % 60;
        // 일반: 1시간 2분 5초
        Debug.Log("플레이 시간 " + h + "시간 " + m + "분 " + s + "초");
        // 고난이도: 1:02:05
        Debug.Log("플레이 시간 " + h + ":" + m / 10 + m % 10 + ":" + s / 10 + s % 10);

    }

}
