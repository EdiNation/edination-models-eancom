namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CPS_RECADV
    {
        public CPS CPS;
        public List<Loop_PAC_RECADV> PACLoop;
        public List<Loop_LIN_RECADV> LINLoop;
    }
    public class Loop_CTA_RECADV
    {
        public CTA_13 CTA;
        public List<COM> COM;
    }
    public class Loop_GIN_RECADV
    {
        public GIN GIN;
    }
    public class Loop_LIN_RECADV
    {
        public LIN LIN;
        public List<PIA_8> PIA;
        public List<QTY_9> QTY;
        public List<QVA> QVA;
        public List<DTM_18> DTM;
        public List<FTX_9> FTX;
        public List<Loop_RFF_RECADV> RFFLoop;
        public List<Loop_PCI_RECADV_2> PCILoop;
    }
    public class Loop_NAD_RECADV
    {
        public NAD_20 NAD;
        public List<Loop_RFF_RECADV_2> RFFLoop;
        public List<Loop_CTA_RECADV> CTALoop;
    }
    public class Loop_PAC_RECADV
    {
        public PAC_18 PAC;
        public List<Loop_PCI_RECADV> PCILoop;
    }
    public class Loop_PCI_RECADV
    {
        public PCI_5 PCI;
        public List<Loop_GIN_RECADV> GINLoop;
    }
    public class Loop_PCI_RECADV_2
    {
        public PCI_5 PCI;
        public QTY_9 QTY;
        public QVA QVA;
        public List<Loop_GIN_RECADV> GINLoop;
    }
    public class Loop_RFF_RECADV
    {
        public RFF_21 RFF;
        public DTM_18 DTM;
    }
    public class Loop_RFF_RECADV_2
    {
        public RFF_21 RFF;
    }
    public class Loop_TDT_RECADV
    {
        public TDT_8 TDT;
    }
    public class TSRECADV 
    {
        public UNH UNH;
        public BGM_21 BGM;
        public List<DTM_18> DTM;
        public List<FTX_9> FTX;
        public List<Loop_RFF_RECADV> RFFLoop;
        public List<Loop_NAD_RECADV> NADLoop;
        public List<Loop_TDT_RECADV> TDTLoop;
        public List<Loop_CPS_RECADV> CPSLoop;
        public CNT_7 CNT;
        public UNT UNT;
    }
}
