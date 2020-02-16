namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class TSCONTRL 
    {
        public UNH UNH;
        public UCI UCI;
        public List<TSCONTRL_UCMLoop> UCMLoop;
        public List<TSCONTRL_UCFLoop> UCFLoop;
        public UNT UNT;
    }
    public class TSCONTRL_UCFLoop
    {
        public UCF UCF;
        public List<TSCONTRL_UCMLoop> UCMLoop;
    }
    public class TSCONTRL_UCMLoop
    {
        public UCM UCM;
        public List<TSCONTRL_UCSLoop> UCSLoop;
    }
    public class TSCONTRL_UCSLoop
    {
        public UCS UCS;
        public List<UCD> UCD;
    }    
}
