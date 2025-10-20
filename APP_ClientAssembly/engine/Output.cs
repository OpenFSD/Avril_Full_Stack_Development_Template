namespace Avril_FSD.ClientAssembly.Outputs
{
    public class Output
    {
        private Avril_FSD.ClientAssembly.Outputs.Output_Control _output_Control;
        private Object _praiseOutputBuffer_Subset;
        private byte _praiseEventId;
        private byte _playerId;

        private static float[] _vertices = {
            -0.5f, -0.5f, -0.5f,  0.0f, 0.0f,
            0.5f, -0.5f, -0.5f,  1.0f, 0.0f,
            0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
            0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
            -0.5f,  0.5f, -0.5f,  0.0f, 1.0f,
            -0.5f, -0.5f, -0.5f,  0.0f, 0.0f,

            -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
            0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
            0.5f,  0.5f,  0.5f,  1.0f, 1.0f,
            0.5f,  0.5f,  0.5f,  1.0f, 1.0f,
            -0.5f,  0.5f,  0.5f,  0.0f, 1.0f,
            -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,

            -0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
            -0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
            -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
            -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
            -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
            -0.5f,  0.5f,  0.5f,  1.0f, 0.0f,

            0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
            0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
            0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
            0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
            0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
            0.5f,  0.5f,  0.5f,  1.0f, 0.0f,

            -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
            0.5f, -0.5f, -0.5f,  1.0f, 1.0f,
            0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
            0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
            -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
            -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,

            -0.5f,  0.5f, -0.5f,  0.0f, 1.0f,
            0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
            0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
            0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
            -0.5f,  0.5f,  0.5f,  0.0f, 0.0f,
            -0.5f,  0.5f, -0.5f,  0.0f, 1.0f
        };
        private static uint[] _indices = {  // note that we start from 0!
            0, 1, 3,   // first triangle
            1, 2, 3    // second triangle
        };
        private static float[] _texCoords = {
            0.0f, 0.0f,  // lower-left corner  
            1.0f, 0.0f,  // lower-right corner
            0.5f, 1.0f   // top-center corner
        };

        public Output()
        {
            _praiseOutputBuffer_Subset = null;
            _praiseEventId = 255;
            _playerId = 255;
            System.Console.WriteLine("Avril_FSD.ClientAssembly: Output");
        }

        public void Initialise_Control()
        {
            Set_output_Control(new Avril_FSD.ClientAssembly.Outputs.Output_Control());
            while (Get_output_Control() == null) { /* Wait while is created */ }
        }

        public Avril_FSD.ClientAssembly.Outputs.Output_Control Get_output_Control()
        {
            return _output_Control;
        }
        public Object Get_praiseOutputBuffer_Subset()
        {
            return _praiseOutputBuffer_Subset;
        }
        public byte Get_praiseEventId()
        { 
            return _praiseEventId; 
        }
        public byte Get_playerId()
        {
            return _playerId;    
        }

        public void Set_output_Control(Avril_FSD.ClientAssembly.Outputs.Output_Control output_Control)
        {
            _output_Control = output_Control;
        }
        public void Set_praiseOutputBuffer_Subset(Object outputSubset)
        {
            _praiseOutputBuffer_Subset = outputSubset ;
        }
        public void Set_praiseEventId(byte praiseEventId)
        {
            _praiseEventId = praiseEventId;
        }
        public void Set_playerId(byte playerIdalue)
        {
            _playerId = playerIdalue;
        }


        public uint[] Get_Indices()
        {
            return _indices;
        }
        public float[] Get_Vertices()
        {
            return _vertices;
        }
     }
}