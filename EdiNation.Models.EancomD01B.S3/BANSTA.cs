namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_AUT_BANSTA
    {
        public AUT AUT;
        public DTM_22 DTM;
    }
    public class Loop_FII_BANSTA
    {
        public FII FII;
    }
    public class Loop_LIN_BANSTA
    {
        public LIN LIN;
        public List<Loop_RFF_BANSTA> RFFLoop;
        public List<Loop_SEQ_BANSTA> SEQLoop;
    }
    public class Loop_NAD_BANSTA
    {
        public NAD_6 NAD;
    }
    public class Loop_RFF_BANSTA
    {
        public RFF_41 RFF;
        public DTM_22 DTM;
    }
    public class Loop_SEQ_BANSTA
    {
        public SEQ SEQ;
        public GIS_3 GIS;
        public List<DTM_22> DTM;
        public MOA_25 MOA;
        public CUX CUX;
        public FTX_27 FTX;
        public Loop_FII_BANSTA FIILoop;
        public Loop_NAD_BANSTA NADLoop;
    }
    public class TSBANSTA 
    {
        public UNH UNH;
        public BGM_2 BGM;
        public DTM_22 DTM;
        public List<Loop_FII_BANSTA> FIILoop;
        public List<Loop_NAD_BANSTA> NADLoop;
        public List<Loop_LIN_BANSTA> LINLoop;
        public List<CNT_3> CNT;
        public List<Loop_AUT_BANSTA> AUTLoop;
        public UNT UNT;
    }
}
