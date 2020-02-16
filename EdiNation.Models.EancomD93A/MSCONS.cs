namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CCI_MSCONS
    {
        public CCI CCI;
        public List<DTM_13> DTM;
    }
    public class Loop_CCI_MSCONS_2
    {
        public CCI CCI;
        public List<MEA_14> MEA;
        public List<DTM_13> DTM;
    }
    public class Loop_CTA_MSCONS
    {
        public CTA_10 CTA;
        public List<COM_2> COM;
    }
    public class Loop_LIN_MSCONS
    {
        public LIN LIN;
        public List<PIA_8> PIA;
        public List<IMD_9> IMD;
        public List<PRI_5> PRI;
        public List<NAD_10> NAD;
        public List<MOA_17> MOA;
        public List<Loop_QTY_MSCONS> QTYLoop;
        public List<Loop_CCI_MSCONS_2> CCILoop;
    }
    public class Loop_LOC_MSCONS
    {
        public LOC_8 LOC;
        public List<DTM_13> DTM;
        public List<Loop_RFF_MSCONS> RFFLoop;
        public List<Loop_CCI_MSCONS> CCILoop;
        public List<Loop_LIN_MSCONS> LINLoop;
    }
    public class Loop_NAD_MSCONS
    {
        public NAD_10 NAD;
        public List<Loop_RFF_MSCONS_2> RFFLoop;
        public List<Loop_CTA_MSCONS> CTALoop;
    }
    public class Loop_NAD_MSCONS_2
    {
        public NAD_10 NAD;
        public List<Loop_LOC_MSCONS> LOCLoop;
    }
    public class Loop_QTY_MSCONS
    {
        public QTY_24 QTY;
        public List<DTM_13> DTM;
    }
    public class Loop_RFF_MSCONS
    {
        public RFF_16 RFF;
        public List<DTM_13> DTM;
    }
    public class Loop_RFF_MSCONS_2
    {
        public RFF_16 RFF;
    }
    public class TSMSCONS 
    {
        public UNH UNH;
        public BGM_10 BGM;
        public List<DTM_13> DTM;
        public List<Loop_RFF_MSCONS> RFFLoop;
        public List<Loop_NAD_MSCONS> NADLoop;
        public UNS UNS;
        public List<Loop_NAD_MSCONS_2> NADLoop2;
        public List<CNT_6> CNT;
        public UNT UNT;
    }
}
