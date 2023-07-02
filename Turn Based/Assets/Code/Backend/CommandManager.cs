using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CommandManager : MonoBehaviourSingleton<CommandManager>
{
    public UnityEvent OnSettingsChanged;

    private void Start()
    {
        if(OnSettingsChanged ==null)
            OnSettingsChanged = new UnityEvent();
    }
}
