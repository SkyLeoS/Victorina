using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int Level = 0;
    public int levelQuestions = 0;
    public int Count = 0;

    public List<string> Questions = new List<string>() {"Тебе есть 18?","ты смотришь скиби-туалеты?", "скиби-туалеты снимаются в 3д программе или в гарис моде?", "кто правы?", "ты смотришь разборы по скибиди-туалетам?", "как хорошо ты знаешь английский?", "Из какой игры пришёл G-man туалет?" , "Из какой страны Автор скибиди-туалетов", "Ютуб или тикток?" , "квадратный корень из 144?", "0" };
    public List<string> Answeres = new List<string>() {"нет","да","да", "нет","3д программа","гарис мод","скибиди-туаеты","камера мены","да","нет","0-50%","50-100%","Fortnite","Half-life","нигерия","Россия","Ютуб","Тикток","12","11.5", "0", "0"};
}

