namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_ALC_RETANN
    {
        public ALC_6 ALC;
        public List<DTM_14> DTM;
        public List<MOA_10> MOA;
    }
    public class Loop_CTA_RETANN
    {
        public CTA_9 CTA;
        public List<COM> COM;
    }
    public class Loop_DOC_RETANN
    {
        public DOC_3 DOC;
        public List<DTM_14> DTM;
    }
    public class Loop_LIN_RETANN
    {
        public LIN LIN;
        public List<PIA_4> PIA;
        public List<IMD_3> IMD;
        public List<MEA_15> MEA;
        public List<DTM_14> DTM;
        public List<PRI_4> PRI;
        public List<LOC_3> LOC;
        public List<MOA_10> MOA;
        public List<Loop_QTY_RETANN> QTYLoop;
        public List<Loop_DOC_RETANN> DOCLoop;
        public List<Loop_RFF_RETANN> RFFLoop;
        public List<Loop_PAC_RETANN> PACLoop;
        public List<Loop_ALC_RETANN> ALCLoop;
    }
    public class Loop_NAD_RETANN
    {
        public NAD_41 NAD;
        public List<LOC_3> LOC;
        public List<Loop_RFF_RETANN_2> RFFLoop;
        public List<Loop_CTA_RETANN> CTALoop;
    }
    public class Loop_PAC_RETANN
    {
        public PAC_12 PAC;
        public List<Loop_PCI_RETANN> PCILoop;
    }
    public class Loop_PCI_RETANN
    {
        public PCI_9 PCI;
        public List<DTM_14> DTM;
        public List<GIN_7> GIN;
    }
    public class Loop_QTY_RETANN
    {
        public QTY_23 QTY;
        public List<CDI> CDI;
    }
    public class Loop_RFF_RETANN
    {
        public RFF_37 RFF;
        public List<DTM_14> DTM;
    }
    public class Loop_RFF_RETANN_2
    {
        public RFF_37 RFF;
    }
    public class Loop_TDT_RETANN
    {
        public TDT_2 TDT;
    }
    public class TSRETANN 
    {
        public UNH UNH;
        public BGM_42 BGM;
        public List<DTM_14> DTM;
        public List<Loop_DOC_RETANN> DOCLoop;
        public List<Loop_RFF_RETANN> RFFLoop;
        public List<Loop_NAD_RETANN> NADLoop;
        public List<Loop_TDT_RETANN> TDTLoop;
        public List<Loop_ALC_RETANN> ALCLoop;
        public List<Loop_LIN_RETANN> LINLoop;
        public UNS UNS;
        public List<CNT_8> CNT;
        public List<MOA_10> MOA;
        public UNT UNT;
    }
}
