namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CCI_MSCONS
    {
        public CCI CCI;
        public List<DTM_34> DTM;
    }
    public class Loop_CCI_MSCONS_2
    {
        public CCI CCI;
        public List<MEA_11> MEA;
        public List<DTM_34> DTM;
    }
    public class Loop_CTA_MSCONS
    {
        public CTA_9 CTA;
        public List<COM_4> COM;
    }
    public class Loop_LIN_MSCONS
    {
        public LIN LIN;
        public List<PIA_4> PIA;
        public List<IMD_7> IMD;
        public List<PRI_3> PRI;
        public List<NAD_20> NAD;
        public List<MOA_23> MOA;
        public List<Loop_QTY_MSCONS> QTYLoop;
        public List<Loop_CCI_MSCONS_2> CCILoop;
    }
    public class Loop_LOC_MSCONS
    {
        public LOC_17 LOC;
        public List<DTM_34> DTM;
        public List<Loop_RFF_MSCONS> RFFLoop;
        public List<Loop_CCI_MSCONS> CCILoop;
        public List<Loop_LIN_MSCONS> LINLoop;
    }
    public class Loop_NAD_MSCONS
    {
        public NAD_20 NAD;
        public List<Loop_RFF_MSCONS_2> RFFLoop;
        public List<Loop_CTA_MSCONS> CTALoop;
    }
    public class Loop_NAD_MSCONS_2
    {
        public NAD_20 NAD;
        public List<Loop_LOC_MSCONS> LOCLoop;
    }
    public class Loop_QTY_MSCONS
    {
        public QTY_22 QTY;
        public List<DTM_34> DTM;
    }
    public class Loop_RFF_MSCONS
    {
        public RFF_26 RFF;
        public List<DTM_34> DTM;
    }
    public class Loop_RFF_MSCONS_2
    {
        public RFF_26 RFF;
    }
    public class TSMSCONS 
    {
        public UNH UNH;
        public BGM_25 BGM;
        public List<DTM_34> DTM;
        public List<Loop_RFF_MSCONS> RFFLoop;
        public List<Loop_NAD_MSCONS> NADLoop;
        public UNS UNS;
        public List<Loop_NAD_MSCONS_2> NADLoop2;
        public List<CNT_10> CNT;
        public UNT UNT;
    }
}
