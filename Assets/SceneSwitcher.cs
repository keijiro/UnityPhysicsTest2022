using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

sealed class SceneSwitcher : MonoBehaviour
{
    [SerializeField] float _delay = 5;
    [SerializeField] int _sceneIndex = 0;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(_delay);
        SceneManager.LoadScene(_sceneIndex);
    }
}
