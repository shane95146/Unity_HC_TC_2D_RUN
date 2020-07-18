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
    public int jump = 500;
    [Header("音效區域")]
    public AudioClip soundJump;
    public AudioClip soundSlide;
    public AudioClip sounHit;
    public AudioClip soundCoin;
    [Header("角色是否死亡"), Tooltip("True 代表死亡，False 代表尚未死亡")]
    public bool dead;

    [Header("動畫控制器")]
    public Animator ani;
    [Header("膠囊碰撞器")]
    public CapsuleCollider2D cc2d;
    [Header("剛體")]
    public Rigidbody2D rig;

    /// <summary>
    /// 是否在地板上
    /// </summary>
    public bool isGround;
    #endregion

    #region 方法區域
    // C#括號符號都是成對出現的:() [] {} "" ''
    // 摘要: 方法的說明
    // 在方法上方添加三條/
    //自訂方法 - 不會執行的，需要呼叫
    //API - 功能倉庫
    //輸出功能 print("字串")

        /// <summary>
        /// 移動
        /// </summary>
    private void Move()
    {
        //如果 剛體.加速度.大小 小於 10
        if(rig.velocity.magnitude < 10)
        {
            //剛體.添加推力(二維推量)
            rig.AddForce(new Vector2(speed, 0));
        }
        
    }

    /// <summary>
    /// 角色的跳躍功能:跳躍動畫、撥放音效與往上跳
    /// </summary>
    private void Jump()
    {
        bool key = Input.GetKey(KeyCode.Space);

        //顛倒運算子 !
        //作用:將布林值變成相反
        //true ----- false

        ani.SetBool("跳躍", key);

        //搬家 ALT +上 or 下
        //格式化 Ctrl + K D

        //如果在地板上才能
        if(isGround)
        {
            if (key)
            {
                isGround = false;                  //不在地板上
                rig.AddForce(new Vector2(0, jump));   // 剛體
            }

        }

       

    }

    /// <summary>
    /// 角色的滑行功能:滑行動畫、播放音效、縮小碰撞範圍
    /// </summary>
    private void Slide()
    {
        //布林值 = 輸入,取得按鍵(按鍵代碼列舉,Z)
        bool key = Input.GetKey(KeyCode.Z);

        //動畫控制器代號
        ani.SetBool("滑行", key);

        if (key)    //如果 玩家 按下 Z 就縮小
        {

            cc2d.offset = new Vector2(0f, -0.1f);   //調整位移
            cc2d.size = new Vector2(1.5f, 2f);      //調整尺寸
        }
        else  //否則 恢復
        {
            cc2d.offset = new Vector2(0f, 0f);   //調整位移
            cc2d.size = new Vector2(1.5f, 4f);      //調整尺寸

        }
    }

    /// <summary>
    /// 碰到障礙物時受傷:扣血
    /// </summary>
    private void Hit()
    {

    }

    /// <summary>
    /// 吃金幣:金幣數量增加，更新介面，金幣特效
    /// </summary>
    private void EatCoin()
    {

    }

    /// <summary>
    /// 角色死亡:動畫、遊戲結束
    /// </summary>
    private void Dead()
    {

    }

    #endregion

    #region 事件區域
    // 開始 start
    //開始遊戲時執行一次
    //初始化:

    private void Start()
    {

    }


    // 更新 Update
    //撥放遊戲後一秒執行約60次。60FPS
    //移動、監聽玩家鍵盤、滑鼠與觸控
    private void Update()
    {
        Slide();
        
    }

    /// <summary>
    /// 固定更新事件:一秒固定執行50次。只要是剛體就想在這
    /// </summary>
    private void FixedUpdate()
    {
        Jump();
        Move();
    }

    /// <summary>
    /// 碰撞事件 : 碰到物件開始執行一次
    /// </summary>
    /// <param name="collision">碰到物件的碰撞資訊</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "地板") ;
        {
            //是否在地板上 = 是
            isGround = true;
        }
    }
}

        #endregion
    

