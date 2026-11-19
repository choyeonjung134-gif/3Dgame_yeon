using UnityEngine;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {

        int totaldamage = 0;
        int criticalLine = 21950;

        
        foreach (int damage in damages)
        {

            totaldamage += damage;
            if (damage >= criticalLine);
            
        }
        Debug.Log("총 데미지" + criticalLine);
   
    }
    }
