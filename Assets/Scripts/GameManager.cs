using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager
{
    public static int score = 0;
    public static int lives = 0;
    public static UnityEvent gameOver = new();
}

/* In any other script you can acces this like:
 * GameManager.score += 10;
 * 
 * void MyFunction()
 * {
 * }
 * 
 * GameManager.gameOver.AddListener(MyFunction);
 * 
 * GameManager.gameOver.Invoke();
 * 
 * 
 * If you want the event to have parameters, make it like this in the monostate GameManager:
 * public static UnityEvent<int> damageAllEnemies = new();
 * The <int> means the callbacks assigned to the event get an int parameter. They would look like:
 * void Damage(int hp)
 * {
 *      health -= hp;
 * }
 * 
 * The adding to the event is the same:
 * GameManager.damageAllEnemies.AddListener(Damage);
 */