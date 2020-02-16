namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_AUT_FINSTA
    {
        public AUT AUT;
        public DTM_20 DTM;
    }
    public class Loop_FII_FINSTA
    {
        public FII_6 FII;
    }
    public class Loop_LIN_FINSTA
    {
        public LIN LIN;
        public FII_6 FII;
        public RFF_39 RFF;
        public List<Loop_MOA_FINSTA> MOALoop;
        public List<Loop_SEQ_FINSTA> SEQLoop;
    }
    public class Loop_MOA_FINSTA
    {
        public MOA_17 MOA;
        public DTM_20 DTM;
    }
    public class Loop_NAD_FINSTA
    {
        public NAD_34 NAD;
    }
    public class Loop_SEQ_FINSTA
    {
        public SEQ SEQ;
        public List<RFF_39> RFF;
        public List<DTM_20> DTM;
        public BUS_3 BUS;
        public MOA_17 MOA;
        public FTX_28 FTX;
    }
    public class TSFINSTA 
    {
        public UNH UNH;
        public BGM_13 BGM;
        public DTM_20 DTM;
        public List<Loop_FII_FINSTA> FIILoop;
        public List<Loop_NAD_FINSTA> NADLoop;
        public List<Loop_LIN_FINSTA> LINLoop;
        public List<CNT_3> CNT;
        public List<Loop_AUT_FINSTA> AUTLoop;
        public UNT UNT;
    }
}
