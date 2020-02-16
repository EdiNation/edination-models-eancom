namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CTA_OSTENQ
    {
        public CTA_10 CTA;
        public List<COM_2> COM;
    }
    public class Loop_LIN_OSTENQ
    {
        public LIN LIN;
        public List<PIA_8> PIA;
        public List<IMD_10> IMD;
        public List<Loop_RFF_OSTENQ_2> RFFLoop;
        public List<Loop_QTY_OSTENQ> QTYLoop;
    }
    public class Loop_NAD_OSTENQ
    {
        public NAD_22 NAD;
        public List<Loop_CTA_OSTENQ> CTALoop;
    }
    public class Loop_QTY_OSTENQ
    {
        public QTY_25 QTY;
        public List<DTM_14> DTM;
        public LOC_12 LOC;
    }
    public class Loop_RFF_OSTENQ
    {
        public RFF_17 RFF;
        public List<DTM_14> DTM;
        public List<Loop_LIN_OSTENQ> LINLoop;
    }
    public class Loop_RFF_OSTENQ_2
    {
        public RFF_17 RFF;
        public List<DTM_14> DTM;
    }
    public class TSOSTENQ 
    {
        public UNH UNH;
        public BGM_14 BGM;
        public List<DTM_14> DTM;
        public List<FTX_27> FTX;
        public List<Loop_NAD_OSTENQ> NADLoop;
        public List<Loop_RFF_OSTENQ> RFFLoop;
        public UNT UNT;
    }
}
