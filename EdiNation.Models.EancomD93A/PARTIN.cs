namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CTA_PARTIN
    {
        public CTA_6 CTA;
        public List<COM> COM;
    }
    public class Loop_LOC_PARTIN
    {
        public LOC_2 LOC;
        public List<DTM_16> DTM;
    }
    public class Loop_NAD_PARTIN
    {
        public NAD_13 NAD;
        public List<Loop_CTA_PARTIN> CTALoop;
    }
    public class Loop_NAD_PARTIN_2
    {
        public NAD_13 NAD;
        public List<DTM_16> DTM;
        public List<FII> FII;
        public List<Loop_LOC_PARTIN> LOCLoop;
        public List<Loop_RFF_PARTIN> RFFLoop;
        public List<Loop_CTA_PARTIN> CTALoop;
        public List<Loop_SCC_PARTIN> SCCLoop;
    }
    public class Loop_RFF_PARTIN
    {
        public RFF_18 RFF;
        public DTM_16 DTM;
    }
    public class Loop_SCC_PARTIN
    {
        public SCC_4 SCC;
        public List<DTM_16> DTM;
    }
    public class TSPARTIN 
    {
        public UNH UNH;
        public BGM_16 BGM;
        public List<DTM_16> DTM;
        public List<FII> FII;
        public List<FTX_28> FTX;
        public List<Loop_RFF_PARTIN> RFFLoop;
        public List<Loop_NAD_PARTIN> NADLoop;
        public UNS UNS;
        public List<Loop_NAD_PARTIN_2> NADLoop2;
        public UNT UNT;
    }
}
