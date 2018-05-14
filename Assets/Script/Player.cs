using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    Spaceship spaceship;

    IEnumerator Start(){
        spaceship = GetComponent <Spaceship>();
        
        // // ○正しい例
        // // 一時変数に格納
        // Vector3 pos = transform.eulerAngles;;
        // // 値を変更
        // pos.z = 180;
        // // 代入する
        // transform.eulerAngles = pos;

        while (true)
        {
            spaceship.Shot (transform);
            yield return new WaitForSeconds (spaceship.shotDelay);
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

     void OnTriggerEnter2D (Collider2D c){
        string layerName = LayerMask.LayerToName(c.gameObject.layer);
        if (layerName == "Bullet (Enemy)"){
            Destroy(c.gameObject);//弾の削除
        }

        if( layerName == "Bullet (Enemy)" || layerName == "Enemy"){
            spaceship.Explosion();//爆発とプレイヤーの削除
            Destroy(gameObject); 
        }
    }
}