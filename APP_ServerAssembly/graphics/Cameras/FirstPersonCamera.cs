using OpenTK;
using Avril_FSD.ServerAssembly.Graphics.GameObjects;

namespace Avril_FSD.ServerAssembly.Graphics.Cameras
{
    public class FirstPersonCamera : ICamera
    {
        public Matrix4 LookAtMatrix { get; private set; }
        private readonly AGameObject _target;
        private readonly Vector3 _offset;
        private float _pitch;
        private float _yaw;
        private float _roll;
        private Vector3 _fowards;
        private Vector3 _up;
        private Vector3 _right;

        public FirstPersonCamera(AGameObject target)
            : this(target, Vector3.Zero)
        {}
        public FirstPersonCamera(AGameObject target, Vector3 offset)
        {
            _target = target;
            _offset = offset;
            _pitch = 0f;
            _yaw = 0f;
            _fowards = new Vector3(1f, 0f, 0f);
            _up = new Vector3(0f, 1f, 0f);
            _right = new Vector3(0f, 0f, 1f);
        }
       
        public void Update(double time, double delta)
        {
            LookAtMatrix = Matrix4.LookAt(
                new Vector3(_target.Position) + _offset,  
                new Vector3(_target.Position + _fowards) + _offset, 
                _up);
        }
        public void Update_Pitch(float deltaDegY)
        {
            Set_Pitch(Get_Pitch() + (float)((Math.PI / 180) * deltaDegY));
            if(Get_Pitch() > (float)(Math.PI / 180) * 85)
            {
                Set_Pitch((float)(Math.PI / 180) * 85);
            }
            if (Get_Pitch() <= (Math.PI / 180) * -85)
            {
                Set_Pitch((float)(Math.PI / 180) * -85);
            }
        }
        public void Update_Yaw(float deltaDegX)
        {
            Set_Yaw(Get_Yaw() + (float)((Math.PI / 180) * deltaDegX));
            if (Get_Yaw() > (float)(Math.PI / 180) * 180)
            {
                Set_Yaw(Get_Yaw() - (float)(Math.PI * 2));
            }
            if (Get_Yaw() <= (Math.PI / 180) * -180)
            {
                Set_Yaw(Get_Yaw() + (float)(Math.PI * 2));
            }
        }
        public void UpdateVectors(float pitch, float yaw)
        {
            _fowards = new Vector3(MathF.Cos(pitch) * MathF.Cos(yaw), MathF.Sin(pitch), MathF.Cos(pitch) * MathF.Sin(yaw));
            _fowards = Vector3.Normalize(_fowards);

            _up = Vector3.UnitY;

            _right = Vector3.Normalize(Vector3.Cross(_fowards, _up));
        }
        private static Vector3 RotateVector(Vector3 vector, float pitch, float yaw, float roll)
        {
            // Convert angles to radians
            float pitchRadians = MathHelper.DegreesToRadians(pitch);
            float yawRadians = MathHelper.DegreesToRadians(yaw);
            float rollRadians = MathHelper.DegreesToRadians(roll);

            // Create rotation matrices for pitch, yaw, and roll
            Matrix4 pitchMatrix = Matrix4.CreateRotationX(pitchRadians);
            Matrix4 yawMatrix = Matrix4.CreateRotationY(yawRadians);
            Matrix4 rollMatrix = Matrix4.CreateRotationZ(rollRadians);

            // Combine the rotations (apply in order: yaw, then pitch, then roll)
            Matrix4 rotationMatrix4 = yawMatrix * pitchMatrix * rollMatrix;
            Matrix3 rotationMatrix3 = new Matrix3();
            rotationMatrix3.M11 = rotationMatrix4.M11;
            rotationMatrix3.M12 = rotationMatrix4.M12;
            rotationMatrix3.M13 = rotationMatrix4.M13;
            rotationMatrix3.M21 = rotationMatrix4.M21;
            rotationMatrix3.M22 = rotationMatrix4.M22;
            rotationMatrix3.M23 = rotationMatrix4.M23;
            rotationMatrix3.M31 = rotationMatrix4.M31;
            rotationMatrix3.M32 = rotationMatrix4.M32;
            rotationMatrix3.M33 = rotationMatrix4.M33;
            // Apply the rotation to the vector
            return Vector3.Transform(vector, rotationMatrix3);
        }
        //get
        public float Get_Pitch()
        {
            return _pitch;
        }

        public float Get_Yaw()
        {
            return _yaw;
        }
        public Vector3 Get_fowards()
        {
            return _fowards;
        }
        public Vector3 Get_up()
        {
            return _up;
        }
        public Vector3 Get_right()
        {
            return _right;
        }
        //set
        public void Set_Pitch(float value)
        {
            _pitch = value;
        }
        public void Set_Yaw(float value)
        {
            _yaw = value;
        }
        public void Set_fowards(Vector3 value)
        {
            _fowards = value;
        }
        public void Set_up(Vector3 value)
        {
            _up = value;
        }
        public void Set_right(Vector3 value)
        {
            _right = value;
        }
    }
}