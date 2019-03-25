using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBehaviour : MonoBehaviour
{

    public int noteType;
    private GameManager.judges judge;
    private KeyCode keyCode;

    // Start is called before the first frame update
    void Start()
    {
        //노트가 몇번째 줄이냐에 따라 버튼을 설정
        if(noteType == 1)
        {
            keyCode = KeyCode.D;
        }
        else if (noteType == 2)
        {
            keyCode = KeyCode.F;
        }
        else if (noteType == 3)
        {
            keyCode = KeyCode.J;
        }
        else if (noteType == 4)
        {
            keyCode = KeyCode.K;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * GameManager.instance.noteSpeed);

        //사용자가 키를 입력한 경우
        if (Input.GetKey(keyCode))
        {
            Debug.Log(judge);

            //노트가 판정 선에 닿기 시작한 이후에 누른 것이라면 노트를 제거
            if(judge != GameManager.judges.NONE)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "BadLine")
        {
            judge = GameManager.judges.BAD;
        }
        else if (other.tag == "GoodLine")
        {
            judge = GameManager.judges.GOOD;
        }
        else if(other.tag == "PerfectLine")
        {
            judge = GameManager.judges.PERFECT;
        }
        else if(other.tag == "MissLine")
        {
            judge = GameManager.judges.MISS;
            Destroy(gameObject);
        }
    }

}
