namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CTA_PARTIN
    {
        public CTA_7 CTA;
        public List<COM> COM;
    }
    public class Loop_NAD_PARTIN
    {
        public NAD_20 NAD;
        public List<Loop_CTA_PARTIN> CTALoop;
    }
    public class Loop_NAD_PARTIN_2
    {
        public NAD_20 NAD;
        public List<DTM_17> DTM;
        public List<FII_6> FII;
        public List<Loop_RFF_PARTIN> RFFLoop;
        public List<Loop_CTA_PARTIN> CTALoop;
        public List<Loop_SCC_PARTIN> SCCLoop;
    }
    public class Loop_RFF_PARTIN
    {
        public RFF_41 RFF;
        public DTM_17 DTM;
    }
    public class Loop_SCC_PARTIN
    {
        public SCC_2 SCC;
        public List<DTM_17> DTM;
    }
    public class TSPARTIN 
    {
        public UNH UNH;
        public BGM_29 BGM;
        public List<DTM_17> DTM;
        public List<FII_6> FII;
        public List<FTX_30> FTX;
        public List<Loop_NAD_PARTIN> NADLoop;
        public UNS UNS;
        public List<Loop_NAD_PARTIN_2> NADLoop2;
        public UNT UNT;
    }
}
