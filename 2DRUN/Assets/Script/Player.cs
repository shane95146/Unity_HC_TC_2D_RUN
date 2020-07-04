using UnityEngine;

public class Player : MonoBehaviour
{
    /*
         //2020.7.4 taichung add單行註解

         //多行註解1
         //多行註解2
         //多行註解3
         
         // 命名規則
         // 1.用有意義的名稱
         // 2.不要使用數字開頭
         // 3.不要使用特殊符號
         // 4.可以使用中文

        // 欄位語法
        // 修飾詞 類型 欄位名稱 = 值;
        // 沒有 = 值
        // 整數、浮點數 預設值 0
        // 字串 預設值""
        // 布林值 false

        // 私人 private - 僅限於此類別使用
        // 公開 public - 所有類別皆可使用

        // 欄位屬性[屬性名稱()]
        // 標題 Heater
        // 提示 Tooltip
        // 範圍 range

      */


    #region 區域
    [Header("速度")]
        public int speed = 50;
        [Tooltip("這是角色血量")]
        public float HP = 999.9f;
    [Header("金幣數量")]
    public int coin;
    [Header("跳躍高度")]
    public int height = 500;
    [Header("音效區域")]
    public AudioClip soundJump;
        public AudioClip soundSlide;
        public AudioClip sounHit;
    [Header("角色是否死亡"),Tooltip("True 代表死亡，False 代表尚未死亡")]
    public bool dead;



        #endregion


    }

