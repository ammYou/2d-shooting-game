using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    Spaceship spaceship;

    IEnumerator Start(){
        spaceship = GetComponent <Spaceship>();

        while (true)
        {
            spaceship.Shot (transform);
            yield return new WaitForSeconds (0.05f);
        }
    }


    void Update ()
    {
        // 右・左
        float x = Input.GetAxisRaw ("Horizontal");
        
        // 上・下
        float y = Input.GetAxisRaw ("Vertical");
        
        // 移動する向きを求める
        Vector2 direction = new Vector2 (x, y).normalized;
        
        // 移動する向きとスピードを代入する
        spaceship.Move (direction);
        
    }
}