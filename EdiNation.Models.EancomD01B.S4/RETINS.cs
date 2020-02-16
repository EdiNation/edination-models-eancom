namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CDI_RETINS
    {
        public CDI CDI;
        public List<DTM_15> DTM;
        public List<FTX> FTX;
    }
    public class Loop_CTA_RETINS
    {
        public CTA_9 CTA;
        public List<COM> COM;
    }
    public class Loop_DOC_RETINS
    {
        public DOC_4 DOC;
        public List<DTM_15> DTM;
    }
    public class Loop_LIN_RETINS
    {
        public LIN LIN;
        public List<PIA_4> PIA;
        public List<IMD_3> IMD;
        public List<MEA_15> MEA;
        public List<DTM_15> DTM;
        public List<QTY_20> QTY;
        public List<LOC_4> LOC;
        public List<MOA_24> MOA;
        public List<Loop_DOC_RETINS> DOCLoop;
        public List<Loop_RFF_RETINS> RFFLoop;
        public List<Loop_PAC_RETINS> PACLoop;
        public List<Loop_CDI_RETINS> CDILoop;
    }
    public class Loop_NAD_RETINS
    {
        public NAD_42 NAD;
        public List<LOC_4> LOC;
        public List<Loop_RFF_RETINS_2> RFFLoop;
        public List<Loop_CTA_RETINS> CTALoop;
    }
    public class Loop_PAC_RETINS
    {
        public PAC_12 PAC;
        public List<Loop_PCI_RETINS> PCILoop;
    }
    public class Loop_PCI_RETINS
    {
        public PCI_9 PCI;
        public List<DTM_15> DTM;
        public List<GIN_7> GIN;
    }
    public class Loop_RFF_RETINS
    {
        public RFF_38 RFF;
        public List<DTM_15> DTM;
    }
    public class Loop_RFF_RETINS_2
    {
        public RFF_38 RFF;
    }
    public class Loop_TDT_RETINS
    {
        public TDT_2 TDT;
    }
    public class TSRETINS 
    {
        public UNH UNH;
        public BGM_43 BGM;
        public List<DTM_15> DTM;
        public List<Loop_DOC_RETINS> DOCLoop;
        public List<Loop_RFF_RETINS> RFFLoop;
        public List<Loop_NAD_RETINS> NADLoop;
        public List<Loop_CDI_RETINS> CDILoop;
        public List<Loop_TDT_RETINS> TDTLoop;
        public List<Loop_LIN_RETINS> LINLoop;
        public List<CNT_8> CNT;
        public UNT UNT;
    }
}
