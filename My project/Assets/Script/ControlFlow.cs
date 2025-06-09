using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    // Start is called before the first frame update
    class Character // ĳ���� Ŭ���� ����
    {
        public string name; // ĳ���� �̸�
        public string rarity; // ĳ���� ���

        public Character(string name, string rarity)
        {
            this.name = name; 
            this.rarity = rarity; 
        }
    }

    List<Character> characterPool = new List<Character>(); 

    void Start()
    {
        // ĳ���� Ǯ ����Ʈ
        characterPool.Add(new Character("������", "Common"));
        characterPool.Add(new Character("���", "Common"));
        characterPool.Add(new Character("����", "Rare"));
        characterPool.Add(new Character("�巡��", "Epic"));
        characterPool.Add(new Character("������ ����", "Legendary"));
    }

    // ��ư�� ������ �Լ�
    public void DoTenDraw()
    {
        for (int i = 0; i < 10; i++)  // 10�� �ݺ��ؼ�
        {
            Character c = Draw();    // ĳ���� �� �� �̱�

            if (c != null)
            {
                Debug.Log($"{i + 1}��° �̱� ���: {c.name} ({c.rarity})");  // �ֿܼ� �����ֱ�
            }
            else
            {
                Debug.Log("�ش� ����� ĳ���Ͱ� �����.");
            }
        }
    }

    Character Draw() // ĳ���� �̱� �Լ�
    {
        float roll = Random.Range(0f, 100f);// 0���� 100 ������ ���� ���� ����
        string targetRarity = "";// ���� ĳ���� ��� �ʱ�ȭ

        if (roll < 50f) targetRarity = "Common"; 
        else if (roll < 80f) targetRarity = "Rare"; // 50% Ȯ���� Common, 30% Ȯ���� Rare
        else if (roll < 95f) targetRarity = "Epic"; // 15% Ȯ���� Epic
        else targetRarity = "Legendary"; // 5% Ȯ���� Legendary

        
        for (int i = 0; i < characterPool.Count; i++) // ĳ���� Ǯ�� ��ȸ�ϸ鼭
        {
            if (characterPool[i].rarity == targetRarity) // �̰��� �ϴ� ��ް� ��ġ�ϴ� ĳ���Ͱ� �ִ��� Ȯ��
            {
                return characterPool[i];  // ã���� �ٷ� ����
            }
        }

        return null;
    }
}