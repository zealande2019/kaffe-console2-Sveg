using kaffe;

namespace KaffeConsoleAppNetCore
{
    public class FlatWhite : Kaffe, Imælk
    {
        public FlatWhite(int rabat): base(rabat)
        {
              
        }
        public override int Pris()
        {
            return 45;
        }

        public int MlMælk()
        {
            return 160;
        }

        public override string Styrke()
        {
            return "mild";
        }

  
    }
}