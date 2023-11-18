using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    public GameObject inputField;
    public GameObject outputField;
    int randomNumber;

    void Start()
    {
        // 1から9までの数字を重複なしでランダムに4つ選ぶ
        int[] numbers = Enumerable.Range(1, 9).OrderBy(x => Guid.NewGuid()).Take(4).ToArray();
        // 選択した数字を4桁の整数に変換
        randomNumber = numbers[0] * 1000 + numbers[1] * 100 + numbers[2] * 10 + numbers[3];

        // 生成したランダムな整数を表示
        Debug.Log("生成したランダムな整数: " + randomNumber);
    }

    void Update()
    {
        
    }

    public void AnswerNumber()
    {
        int inputNumber = int.Parse(inputField.GetComponent<InputField>().text);
        if (inputNumber < randomNumber)
        {
            outputField.GetComponent<Text>().text = inputNumber + "は小さい";
        }
        else if (inputNumber > randomNumber)
        {
            outputField.GetComponent<Text>().text = inputNumber + "は大きい";
        }
        else
        {
            outputField.GetComponent<Text>().text = inputNumber + "は正解";
        }
        inputField.GetComponent<InputField>().text = "";


        //// 文字列を1桁ずつリストに格納
        //string input = inputField.GetComponent<InputField>().text);
        //List<int> digitList = new List<int>();
        //foreach (char digitChar in input)
        //{
        //    int digit = int.Parse(digitChar.ToString());
        //    digitList.Add(digit);
        //}
    }
}
