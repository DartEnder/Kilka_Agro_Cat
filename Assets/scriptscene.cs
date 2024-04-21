using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // ����� ��� ����������� �������� ����� �� �����
    public void LoadSceneByName(string sceneName)
    {
        StartCoroutine(LoadSceneAsync(sceneName));
    }

    // �������� ��� ����������� �������� �����
    private IEnumerator LoadSceneAsync(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // ����, ���� ����� ���������� ���������
        while (!asyncLoad.isDone)
        {
            // ����� ����� ��������� �������� ��� ��� ������ �������� ����������
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            Debug.Log($"Loading progress: {progress * 100}%");
            yield return null;
        }
    }
}