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
        int a = playSeconds * (int)expRate;
        Debug.Log("플레이 시간" + a + "년");



     
    }






}
