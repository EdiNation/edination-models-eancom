namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CTA_OSTENQ
    {
        public CTA_9 CTA;
        public List<COM_5> COM;
    }
    public class Loop_DOC_OSTENQ
    {
        public DOC_9 DOC;
        public List<DTM_9> DTM;
        public List<Loop_LIN_OSTENQ> LINLoop;
    }
    public class Loop_LIN_OSTENQ
    {
        public LIN_6 LIN;
        public List<PIA_3> PIA;
        public List<IMD_12> IMD;
        public List<Loop_RFF_OSTENQ> RFFLoop;
        public List<Loop_QTY_OSTENQ> QTYLoop;
    }
    public class Loop_NAD_OSTENQ
    {
        public NAD_38 NAD;
        public List<Loop_CTA_OSTENQ> CTALoop;
    }
    public class Loop_QTY_OSTENQ
    {
        public QTY_19 QTY;
        public List<DTM_9> DTM;
        public LOC_20 LOC;
    }
    public class Loop_RFF_OSTENQ
    {
        public RFF_40 RFF;
        public List<DTM_9> DTM;
    }
    public class TSOSTENQ 
    {
        public UNH UNH;
        public BGM_27 BGM;
        public List<DTM_9> DTM;
        public List<FTX_29> FTX;
        public List<Loop_NAD_OSTENQ> NADLoop;
        public List<Loop_DOC_OSTENQ> DOCLoop;
        public UNT UNT;
    }
}
