using OpenTK;
using Avril_FSD.ServerAssembly.Graphics.Cameras;
using Avril_FSD.ServerAssembly.Graphics.GameObjects;
using Avril_FSD.ServerAssembly.Graphics.Renderables;

namespace Avril_FSD.ServerAssembly.GameInstance
{
    public class Player : AGameObject
    {
        private bool _isFirstMove;
        private bool _isFirstMouseMove;
        private float[] _mousePos;
        private FirstPersonCamera _cameraFP;
        private ThirdPersonCamera _cameraTP;
        private float cameraSpeed;
        private float sensitivity;

        public Player(ARenderable model, Vector3 position, Vector3 direction, Vector3 rotation, float velocity)
            : base(model, position, direction, rotation, velocity)
        {
            _isFirstMove = true;
            _isFirstMouseMove = true;
            _mousePos = new float[2];
            _cameraFP = null;
            _cameraTP = null;
            cameraSpeed = 1.5f;
            sensitivity = 1f;
        }
        public void Create_Cameras()
        {
            _cameraFP = new FirstPersonCamera(
                this
            );
            while (_cameraFP == null) { }

            _cameraTP = new ThirdPersonCamera(
                this
            );
            while (_cameraTP == null) { }
        }
        public FirstPersonCamera Get_CameraFP()
        {
            return _cameraFP;
        }
        public ThirdPersonCamera Get_CameraTP()
        {
            return _cameraTP;
        }

        public bool Get_isFirstMove()
        {
            return _isFirstMove;
        }
        public bool Get_isFirstMouseMove()
        {
            return _isFirstMouseMove;
        }
        public float[] Get_MousePos()
        {
            return _mousePos;
        }

        public float Get_cameraSpeed()
        {
            return cameraSpeed;
        }

        public float Get_sensitivity()
        {
            return sensitivity;
        }



        public void Get_isFirstMove(bool value)
        {
            _isFirstMove = value;
        }
        public void Get_isFirstMouseMove(bool value)
        {
            _isFirstMouseMove = value;
        }

        public bool Set_isFirstMouseMove(bool value)
        {
            return _isFirstMouseMove = value;
        }
        public void Set_MousePos(float[] pos)
        {
            _mousePos = pos;
        }


    }
}

