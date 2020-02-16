namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CCI_MSCONS
    {
        public CCI CCI;
        public List<MEA> MEA;
        public List<DTM_33> DTM;
    }
    public class Loop_CCI_MSCONS_2
    {
        public CCI CCI;
        public List<MEA> MEA;
        public List<DTM_33> DTM;
    }
    public class Loop_CTA_MSCONS
    {
        public CTA_9 CTA;
        public List<COM_5> COM;
    }
    public class Loop_LIN_MSCONS
    {
        public LIN_6 LIN;
        public List<PIA_3> PIA;
        public List<IMD_8> IMD;
        public List<PRI_3> PRI;
        public List<NAD_17> NAD;
        public List<MOA_20> MOA;
        public List<Loop_QTY_MSCONS> QTYLoop;
        public List<Loop_CCI_MSCONS_2> CCILoop;
    }
    public class Loop_LOC_MSCONS
    {
        public LOC_14 LOC;
        public List<DTM_33> DTM;
        public List<Loop_RFF_MSCONS> RFFLoop;
        public List<Loop_CCI_MSCONS> CCILoop;
        public List<Loop_LIN_MSCONS> LINLoop;
    }
    public class Loop_NAD_MSCONS
    {
        public NAD_17 NAD;
        public List<Loop_RFF_MSCONS_2> RFFLoop;
        public List<Loop_CTA_MSCONS> CTALoop;
    }
    public class Loop_NAD_MSCONS_2
    {
        public NAD_17 NAD;
        public List<Loop_LOC_MSCONS> LOCLoop;
    }
    public class Loop_QTY_MSCONS
    {
        public QTY_18 QTY;
        public List<DTM_33> DTM;
    }
    public class Loop_RFF_MSCONS
    {
        public RFF_24 RFF;
        public List<DTM_33> DTM;
    }
    public class Loop_RFF_MSCONS_2
    {
        public RFF_24 RFF;
    }
    public class TSMSCONS 
    {
        public UNH UNH;
        public BGM_23 BGM;
        public List<DTM_33> DTM;
        public List<Loop_RFF_MSCONS> RFFLoop;
        public List<Loop_NAD_MSCONS> NADLoop;
        public UNS UNS;
        public List<Loop_NAD_MSCONS_2> NADLoop2;
        public List<CNT_10> CNT;
        public UNT UNT;
    }
}
