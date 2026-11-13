using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Characters player;

    private void Start()
    {
        print(player.Class);
    }
}
