using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button2 : MonoBehaviour
{
    [SerializeField] Counter counter;
    public button1 Button1;
    public Text question;

    public void OnClick()
    {
        question.text = counter.Questions[counter.levelQuestions];
        GetComponentInChildren<Text>().text = counter.Answeres[counter.Level];
        Button1.GetComponentInChildren<Text>().text = (counter.Answeres[counter.Level + 1]);

        if (counter.Level == 20)
        {
            SceneManager.LoadScene("Win");
        }

        counter.levelQuestions++;
        counter.Level += 2;
    }
}
