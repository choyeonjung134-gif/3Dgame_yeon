using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class ForeachPractice : MonoBehaviour
{
    public int[] monsterHps = { 0, 35, 0, 80, 12 };

    [ContextMenu("foreach 실습")]
    void CountAlive()
    {
        int alivecount = 0;
        int hpSum = 0;

        foreach (int hp in monsterHps)
        {
            if (hp > 0) ;
            alivecount++;
            hpSum += hp;
        }
        Debug.Log("살아 있는 몬스터" + alivecount + "마리");
        Debug.Log("남은 체력 합 " + hpSum);

    }
}
