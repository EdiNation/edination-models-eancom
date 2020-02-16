namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_ERC_APERAK
    {
        public ERC ERC;
        public FTX_22 FTX;
    }
    public class Loop_NAD_APERAK
    {
        public NAD_29 NAD;
    }
    public class Loop_RFF_APERAK
    {
        public RFF_38 RFF;
        public List<DTM_8> DTM;
    }
    public class TSAPERAK 
    {
        public UNH UNH;
        public BGM BGM;
        public List<DTM_8> DTM;
        public List<Loop_RFF_APERAK> RFFLoop;
        public List<Loop_NAD_APERAK> NADLoop;
        public List<Loop_ERC_APERAK> ERCLoop;
        public UNT UNT;
    }
}
