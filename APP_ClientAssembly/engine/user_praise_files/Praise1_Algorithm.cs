
namespace Avril_FSD.ClientAssembly.Praise_Files
{
    public class Praise1_Algorithm
    {
        public Praise1_Algorithm()
        {

        }
        public void Do_Praise(Avril_FSD.ClientAssembly.Game_Instance gameInstance, byte playerId, Avril_FSD.ClientAssembly.Praise_Files.Praise1_Output in_SubSet)
        {
            gameInstance.Get_gameObjectFactory().Get_player().Get_CameraFP().Set_fowards(in_SubSet.Get_fowards());
            gameInstance.Get_gameObjectFactory().Get_player().Get_CameraFP().Set_right(in_SubSet.Get_right());
            gameInstance.Get_gameObjectFactory().Get_player().Get_CameraFP().Set_up(in_SubSet.Get_fowards());
        }
    }
}