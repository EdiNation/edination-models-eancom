namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_AUT_FINSTA
    {
        public AUT AUT;
        public DTM_16 DTM;
    }
    public class Loop_FII_FINSTA
    {
        public FII_5 FII;
    }
    public class Loop_LIN_FINSTA
    {
        public LIN_5 LIN;
        public FII_5 FII;
        public RFF_36 RFF;
        public List<Loop_MOA_FINSTA> MOALoop;
        public List<Loop_SEQ_FINSTA> SEQLoop;
    }
    public class Loop_MOA_FINSTA
    {
        public MOA_14 MOA;
        public DTM_16 DTM;
    }
    public class Loop_NAD_FINSTA
    {
        public NAD_34 NAD;
    }
    public class Loop_SEQ_FINSTA
    {
        public SEQ_4 SEQ;
        public List<RFF_36> RFF;
        public List<DTM_16> DTM;
        public BUS_5 BUS;
        public MOA_14 MOA;
        public FTX_26 FTX;
    }
    public class TSFINSTA 
    {
        public UNH UNH;
        public BGM_11 BGM;
        public DTM_16 DTM;
        public List<Loop_FII_FINSTA> FIILoop;
        public List<Loop_NAD_FINSTA> NADLoop;
        public List<Loop_LIN_FINSTA> LINLoop;
        public List<CNT_3> CNT;
        public List<Loop_AUT_FINSTA> AUTLoop;
        public UNT UNT;
    }
}
