namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_AUT_FINCAN
    {
        public AUT AUT;
        public DTM_23 DTM;
    }
    public class Loop_FII_FINCAN
    {
        public FII_8 FII;
    }
    public class Loop_LIN_FINCAN
    {
        public LIN_5 LIN;
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
        public RFF_39 RFF;
        public DTM_23 DTM;
    }
    public class TSFINCAN 
    {
        public UNH UNH;
        public BGM_10 BGM;
        public DTM_23 DTM;
        public List<Loop_FII_FINCAN> FIILoop;
        public List<Loop_NAD_FINCAN> NADLoop;
        public List<Loop_LIN_FINCAN> LINLoop;
        public List<CNT_6> CNT;
        public List<Loop_AUT_FINCAN> AUTLoop;
        public UNT UNT;
    }
}
