using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KGAI : MonoBehaviour
{
    private string name = "GunTae";
    private int age = 30;
    private int height = 168;
    private string mbti = "ISFP";
    private string favoriteColor = "White";
    private string hobby = "Computergame";
    private string occupation = "���";
    private int weight = 75;
    private string favoriteMovie = "����ø���";

    void Start()
    {
        SelfIntroduction(name, age, height, mbti, favoriteMovie, favoriteColor, hobby, occupation, weight);
    }

    public void SelfIntroduction(string name, int age, int height, string mbti,
                                 string favoriteMovie, string favoriteColor,
                                 string hobby, string occupation, int weight)
    {
        Debug.Log("�� �̸���: " + name);
        Debug.Log("����: " + age);
        Debug.Log("Ű: " + height + " cm");
        Debug.Log("������: " + weight + " kg");
        Debug.Log("MBTI: " + mbti);
        Debug.Log("�����ϴ� ����: " + favoriteColor);
        Debug.Log("���: " + hobby);
        Debug.Log("������: " + occupation);
        Debug.Log("�����ϴ� ��ȭ��: " + favoriteMovie);
    }
}