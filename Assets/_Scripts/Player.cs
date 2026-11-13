using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private ScriptableObjects scriptableObject;

    private void Start()
    {
        print(scriptableObject.Name + scriptableObject.Class);
    }
}
