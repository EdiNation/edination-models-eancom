namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CTA_OSTENQ
    {
        public CTA_9 CTA;
        public List<COM_4> COM;
    }
    public class Loop_DOC_OSTENQ
    {
        public DOC_11 DOC;
        public List<DTM_12> DTM;
        public List<Loop_LIN_OSTENQ> LINLoop;
    }
    public class Loop_LIN_OSTENQ
    {
        public LIN LIN;
        public List<PIA_4> PIA;
        public List<IMD_11> IMD;
        public List<Loop_RFF_OSTENQ> RFFLoop;
        public List<Loop_LOC_OSTENQ> LOCLoop;
    }
    public class Loop_LOC_OSTENQ
    {
        public LOC_18 LOC;
        public List<DTM_12> DTM;
        public QTY_21 QTY;
    }
    public class Loop_NAD_OSTENQ
    {
        public NAD_38 NAD;
        public List<Loop_CTA_OSTENQ> CTALoop;
    }
    public class Loop_RFF_OSTENQ
    {
        public RFF_43 RFF;
        public DTM_12 DTM;
    }
    public class TSOSTENQ 
    {
        public UNH UNH;
        public BGM_29 BGM;
        public List<DTM_12> DTM;
        public List<FTX_31> FTX;
        public List<Loop_NAD_OSTENQ> NADLoop;
        public List<Loop_DOC_OSTENQ> DOCLoop;
        public UNT UNT;
    }
}
