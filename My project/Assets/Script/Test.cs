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
    private string occupation = "백수";
    private int weight = 75;
    private string favoriteMovie = "마블시리즈";

    void Start()
    {
        SelfIntroduction(name, age, height, mbti, favoriteMovie, favoriteColor, hobby, occupation, weight);
    }

    public void SelfIntroduction(string name, int age, int height, string mbti,
                                 string favoriteMovie, string favoriteColor,
                                 string hobby, string occupation, int weight)
    {
        Debug.Log("내 이름은: " + name);
        Debug.Log("나이: " + age);
        Debug.Log("키: " + height + " cm");
        Debug.Log("몸무게: " + weight + " kg");
        Debug.Log("MBTI: " + mbti);
        Debug.Log("좋아하는 색상: " + favoriteColor);
        Debug.Log("취미: " + hobby);
        Debug.Log("직업은: " + occupation);
        Debug.Log("좋아하는 영화는: " + favoriteMovie);
    }
}