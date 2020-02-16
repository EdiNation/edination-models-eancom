namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CTA_OSTRPT
    {
        public CTA_9 CTA;
        public List<COM_5> COM;
    }
    public class Loop_DOC_OSTRPT
    {
        public DOC_10 DOC;
        public List<DTM_10> DTM;
        public List<Loop_STS_OSTRPT> STSLoop;
        public List<Loop_LIN_OSTRPT> LINLoop;
    }
    public class Loop_LIN_OSTRPT
    {
        public LIN_6 LIN;
        public List<PIA_3> PIA;
        public List<IMD_12> IMD;
        public List<Loop_RFF_OSTRPT> RFFLoop;
        public List<Loop_QTY_OSTRPT> QTYLoop;
    }
    public class Loop_NAD_OSTRPT
    {
        public NAD_28 NAD;
        public List<Loop_CTA_OSTRPT> CTALoop;
    }
    public class Loop_QTY_OSTRPT
    {
        public QTY_20 QTY;
        public List<DTM_10> DTM;
        public LOC_21 LOC;
        public List<Loop_STS_OSTRPT> STSLoop;
    }
    public class Loop_RFF_OSTRPT
    {
        public RFF_7 RFF;
        public List<DTM_10> DTM;
    }
    public class Loop_STS_OSTRPT
    {
        public STS STS;
        public List<DTM_10> DTM;
        public PCD_7 PCD;
        public NAD_28 NAD;
    }
    public class TSOSTRPT 
    {
        public UNH UNH;
        public BGM_28 BGM;
        public List<DTM_10> DTM;
        public RFF_7 RFF;
        public List<FTX_29> FTX;
        public List<Loop_NAD_OSTRPT> NADLoop;
        public List<Loop_DOC_OSTRPT> DOCLoop;
        public UNT UNT;
    }
}
