namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_AUT_FINCAN
    {
        public AUT AUT;
        public DTM_26 DTM;
    }
    public class Loop_FII_FINCAN
    {
        public FII_10 FII;
    }
    public class Loop_LIN_FINCAN
    {
        public LIN LIN;
        public List<Loop_RFF_FINCAN> RFFLoop;
    }
    public class Loop_NAD_FINCAN
    {
        public NAD_33 NAD;
        public CTA_9 CTA;
        public List<COM> COM;
    }
    public class Loop_RFF_FINCAN
    {
        public RFF_41 RFF;
        public DTM_26 DTM;
    }
    public class TSFINCAN 
    {
        public UNH UNH;
        public BGM_12 BGM;
        public DTM_26 DTM;
        public List<Loop_FII_FINCAN> FIILoop;
        public List<Loop_NAD_FINCAN> NADLoop;
        public List<Loop_LIN_FINCAN> LINLoop;
        public List<CNT_5> CNT;
        public List<Loop_AUT_FINCAN> AUTLoop;
        public UNT UNT;
    }
}
