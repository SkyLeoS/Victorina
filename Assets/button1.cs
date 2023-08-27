using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button1 : MonoBehaviour
{
    [SerializeField] Counter counter;
    public button2 Button2;
    public Text question;
    public void OnClick()
    {
        question.text = counter.Questions[counter.levelQuestions];
        GetComponentInChildren<Text>().text = counter.Answeres[counter.Level];
        Button2.GetComponentInChildren<Text>().text = (counter.Answeres[counter.Level + 1]);

        if (counter.Level == 20)
        {
            SceneManager.LoadScene("Win");
        }

        counter.levelQuestions++;
        counter.Level += 2;
    }
}
