namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_ERC_APERAK
    {
        public ERC ERC;
        public FTX_22 FTX;
        public List<Loop_RFF_APERAK_2> RFFLoop;
    }
    public class Loop_NAD_APERAK
    {
        public NAD_30 NAD;
    }
    public class Loop_RFF_APERAK
    {
        public RFF_8 RFF;
        public List<DTM_11> DTM;
    }
    public class Loop_RFF_APERAK_2
    {
        public RFF_8 RFF;
        public List<FTX_22> FTX;
    }
    public class TSAPERAK 
    {
        public UNH UNH;
        public BGM BGM;
        public List<DTM_11> DTM;
        public List<Loop_RFF_APERAK> RFFLoop;
        public List<Loop_NAD_APERAK> NADLoop;
        public List<Loop_ERC_APERAK> ERCLoop;
        public UNT UNT;
    }
}
