using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int Level = 0;
    public int levelQuestions = 0;
    public int Count = 0;

    public List<string> Questions = new List<string>() {"���� ���� 18?","�� �������� �����-�������?", "�����-������� ��������� � 3� ��������� ��� � ����� ����?", "��� �����?", "�� �������� ������� �� �������-��������?", "��� ������ �� ������ ����������?", "�� ����� ���� ������ G-man ������?" , "�� ����� ������ ����� �������-��������", "���� ��� ������?" , "���������� ������ �� 144?", "0" };
    public List<string> Answeres = new List<string>() {"���","��","��", "���","3� ���������","����� ���","�������-������","������ ����","��","���","0-50%","50-100%","Fortnite","Half-life","�������","������","����","������","12","11.5", "0", "0"};
}

