using UnityEngine;

namespace TDShooter.Managers.GameManager
{
    public class GameManager : MonoBehaviour
    {
        //������� ���������� - ��������. � ���������� �������� �������� DI
        public static GameManager Instance { get; private set; }
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
                return;
            }
            Instance = this;
        }
    }
}