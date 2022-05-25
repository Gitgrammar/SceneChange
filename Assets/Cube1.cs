using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube1 : MonoBehaviour
{
    public static Cube1 instance;//static 変数でCube1型のインスタンスを保持
    int num = 0;
     void Awake()
    {
        if (instance == null)
        {
            instance = this;//このインスタンスをstaticなisntance　に登録
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);//2回目以降重複して作成したgameObjectを削除
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            num++;
            Debug.Log(num);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("scene2");
        }
    }
    //numのゲッターを作成しておく
    public int GetNum()
    {
        return this.num;
    }
}
