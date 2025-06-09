using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    // Start is called before the first frame update
    class Character // 캐릭터 클래스 정의
    {
        public string name; // 캐릭터 이름
        public string rarity; // 캐릭터 등급

        public Character(string name, string rarity)
        {
            this.name = name; 
            this.rarity = rarity; 
        }
    }

    List<Character> characterPool = new List<Character>(); 

    void Start()
    {
        // 캐릭터 풀 리스트
        characterPool.Add(new Character("슬라임", "Common"));
        characterPool.Add(new Character("고블린", "Common"));
        characterPool.Add(new Character("엘프", "Rare"));
        characterPool.Add(new Character("드래곤", "Epic"));
        characterPool.Add(new Character("전설의 영웅", "Legendary"));
    }

    // 버튼과 연결할 함수
    public void DoTenDraw()
    {
        for (int i = 0; i < 10; i++)  // 10번 반복해서
        {
            Character c = Draw();    // 캐릭터 한 명 뽑기

            if (c != null)
            {
                Debug.Log($"{i + 1}번째 뽑기 결과: {c.name} ({c.rarity})");  // 콘솔에 보여주기
            }
            else
            {
                Debug.Log("해당 등급의 캐릭터가 없어요.");
            }
        }
    }

    Character Draw() // 캐릭터 뽑기 함수
    {
        float roll = Random.Range(0f, 100f);// 0부터 100 사이의 랜덤 숫자 생성
        string targetRarity = "";// 뽑을 캐릭터 등급 초기화

        if (roll < 50f) targetRarity = "Common"; 
        else if (roll < 80f) targetRarity = "Rare"; // 50% 확률로 Common, 30% 확률로 Rare
        else if (roll < 95f) targetRarity = "Epic"; // 15% 확률로 Epic
        else targetRarity = "Legendary"; // 5% 확률로 Legendary

        
        for (int i = 0; i < characterPool.Count; i++) // 캐릭터 풀을 순회하면서
        {
            if (characterPool[i].rarity == targetRarity) // 뽑고자 하는 등급과 일치하는 캐릭터가 있는지 확인
            {
                return characterPool[i];  // 찾으면 바로 리턴
            }
        }

        return null;
    }
}