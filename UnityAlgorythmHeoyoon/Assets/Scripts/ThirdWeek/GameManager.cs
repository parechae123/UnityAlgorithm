using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GenericSingletone<GameManager>
{
    public int playerScore = 0;
    public void inscreaseScore(int amount)          //�Լ��� ���ؼ� ���������ش�.
    {
        playerScore += amount;
    }
}
