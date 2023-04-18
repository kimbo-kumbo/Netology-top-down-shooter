using System;
using UnityEngine;

namespace TDShooter.Level
{
    /// <summary>
    /// �������� �� ����� ������
    /// </summary>
    public class Tile_Marker : MonoBehaviour
    {
        [SerializeField]
        public byte number;

        public Action<Tile_Marker> Callback;
        /// <summary>
        /// ���� ����� ��������� �� ����, ��������� �� ���� TilesManager
        /// </summary>
        /// <param name="collision"></param>
        private void OnCollisionEnter(Collision collision)
        {
            Callback.Invoke(this);
        }
    }
}