namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_CTA_OSTRPT
    {
        public CTA_9 CTA;
        public List<COM_4> COM;
    }
    public class Loop_DOC_OSTRPT
    {
        public DOC_12 DOC;
        public List<DTM_13> DTM;
        public List<Loop_STS_OSTRPT> STSLoop;
        public List<Loop_LIN_OSTRPT> LINLoop;
    }
    public class Loop_LIN_OSTRPT
    {
        public LIN LIN;
        public List<PIA_7> PIA;
        public List<IMD_11> IMD;
        public List<Loop_RFF_OSTRPT> RFFLoop;
        public List<Loop_STS_OSTRPT_2> STSLoop;
        public List<Loop_SCC_OSTRPT> SCCLoop;
    }
    public class Loop_LOC_OSTRPT
    {
        public LOC_19 LOC;
        public List<DTM_13> DTM;
        public QTY_7 QTY;
    }
    public class Loop_NAD_OSTRPT
    {
        public NAD_23 NAD;
        public List<Loop_CTA_OSTRPT> CTALoop;
    }
    public class Loop_NAD_OSTRPT_2
    {
        public NAD_23 NAD;
    }
    public class Loop_RFF_OSTRPT
    {
        public RFF_7 RFF;
        public DTM_13 DTM;
    }
    public class Loop_SCC_OSTRPT
    {
        public SCC_2 SCC;
        public List<Loop_LOC_OSTRPT> LOCLoop;
    }
    public class Loop_STS_OSTRPT
    {
        public STS STS;
        public List<DTM_13> DTM;
        public PCD_6 PCD;
        public List<Loop_NAD_OSTRPT_2> NADLoop;
    }
    public class Loop_STS_OSTRPT_2
    {
        public STS STS;
        public List<DTM_13> DTM;
        public PCD_6 PCD;
        public QTY_7 QTY;
        public List<Loop_NAD_OSTRPT_2> NADLoop;
    }
    public class TSOSTRPT 
    {
        public UNH UNH;
        public BGM_30 BGM;
        public List<DTM_13> DTM;
        public RFF_7 RFF;
        public List<FTX_30> FTX;
        public List<Loop_NAD_OSTRPT> NADLoop;
        public List<Loop_DOC_OSTRPT> DOCLoop;
        public UNT UNT;
    }
}
