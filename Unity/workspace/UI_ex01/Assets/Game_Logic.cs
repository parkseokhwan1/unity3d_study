using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Logic : MonoBehaviour {
    public Text stage_val;
    public Text money_val;

    public Image stg1;
    public Image stg2;
    public Image stg3;
    public Image stg4;

    int stage;
    int money;

    int building;
    int count;
    int assist;
    int ability;

    // Use this for initialization
    void Start() {
        stage = 1;
        money = 100;
        money_val.text = "￦ " + money.ToString();
        stage_val.text = "스테이지 " + stage.ToString();

        building = 0;
        count = 0;
        assist = 0;
        ability = 0;
        stg1.gameObject.SetActive(true);
        // 객체 내부속성의 활성화
        stg2.gameObject.SetActive(false);
        stg3.gameObject.SetActive(false);
        stg4.gameObject.SetActive(false);
    }

    public void Click_btn()
    {
        money = money + (building + assist + ability + 1);
        print(money);
    }

    public void add_building()
    {
        if (money >= 20000 * (count+1))
        {
            count += 1;
            money -= 20000 * count;
            building += 2000;
        }
        switch (count / 3)
        {
            case 0:
                break;
            case 1:
                stg2.gameObject.SetActive(true);
                break;
            case 2:
                stg3.gameObject.SetActive(true);
                break;
            default:
                stg4.gameObject.SetActive(true);
                break;
        }
    }

    public void add_ability()
    {
        if (money >= 200)
        {
            money = money - 200;
            ability += 10;
        }
    }

    public void add_assist()
    {
        if (money >= 1000)
        {
            money = money - 1000;
            assist += 100;
        }
    }

    public void showmethemoney()
    {
        money += 5000;
    }

    // Update is called once per frame
    void Update () {
        money_val.text = "￦ " + money.ToString();

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Click_btn();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            add_building();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            add_ability();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            add_assist();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            showmethemoney();
        }
    }
    // 버튼을 클릭하면 돈이 올라간다.
    // 올라간 돈을 화면에 표시한다. (UI 객체를 어떻게 접근할 것인가)
    // using Unityengine UI (영역을 참조)
    // Text moneyval; <- 숫자
    // 계산 후 결과값을 문자로
    // Text moneyval = money.toString();

}
