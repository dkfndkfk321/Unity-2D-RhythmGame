using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //게임 매니저를 싱글톤으로 생성
    public static GameManager instance { get; set; }

    private void Awake()
    {
       if(instance == null)
        {
            instance = this;
        }
       else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    public float noteSpeed;

    /*판정 변수 참조
     * BAD : 1
     * GOOD : 2
     * PERFECT : 3
     * MISS : 4
     * */

        public enum judges { NONE = 0, BAD ,GOOD, PERFECT, MISS};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
