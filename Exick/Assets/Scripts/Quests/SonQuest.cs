using UnityEngine;
using UnityEngine.SceneManagement;

public class SonQuest : QuestSetup
{
    protected override void Process()
    {
        SceneManager.LoadScene("End");
    }
}
