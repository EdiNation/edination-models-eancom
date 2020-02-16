namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CDI_RETINS
    {
        public CDI CDI;
        public List<DTM_12> DTM;
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
        public List<DTM_12> DTM;
    }
    public class Loop_LIN_RETINS
    {
        public LIN_6 LIN;
        public List<PIA_3> PIA;
        public List<IMD_3> IMD;
        public List<MEA_13> MEA;
        public List<DTM_12> DTM;
        public List<QTY_16> QTY;
        public List<LOC_3> LOC;
        public List<MOA_21> MOA;
        public List<Loop_DOC_RETINS> DOCLoop;
        public List<Loop_RFF_RETINS> RFFLoop;
        public List<Loop_PAC_RETINS> PACLoop;
        public List<Loop_CDI_RETINS> CDILoop;
    }
    public class Loop_NAD_RETINS
    {
        public NAD_41 NAD;
        public List<LOC_3> LOC;
        public List<Loop_RFF_RETINS_2> RFFLoop;
        public List<Loop_CTA_RETINS> CTALoop;
    }
    public class Loop_PAC_RETINS
    {
        public PAC_13 PAC;
        public List<Loop_PCI_RETINS> PCILoop;
    }
    public class Loop_PCI_RETINS
    {
        public List<PCI_11> PCI;
        public List<DTM_12> DTM;
        public List<GIN_6> GIN;
    }
    public class Loop_RFF_RETINS
    {
        public RFF_35 RFF;
        public List<DTM_12> DTM;
    }
    public class Loop_RFF_RETINS_2
    {
        public RFF_35 RFF;
    }
    public class Loop_TDT_RETINS
    {
        public TDT_9 TDT;
    }
    public class TSRETINS 
    {
        public UNH UNH;
        public BGM_41 BGM;
        public List<DTM_12> DTM;
        public List<Loop_DOC_RETINS> DOCLoop;
        public List<Loop_RFF_RETINS> RFFLoop;
        public List<Loop_NAD_RETINS> NADLoop;
        public List<Loop_CDI_RETINS> CDILoop;
        public List<Loop_TDT_RETINS> TDTLoop;
        public List<Loop_LIN_RETINS> LINLoop;
        public List<CNT_4> CNT;
        public UNT UNT;
    }
}
