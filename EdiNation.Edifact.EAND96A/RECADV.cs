namespace EdiNation.Edifact.EAND96A
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
        public CTA_16 CTA;
        public List<COM_2> COM;
    }
    public class Loop_GIN_RECADV
    {
        public GIN_2 GIN;
    }
    public class Loop_LIN_RECADV
    {
        public LIN_6 LIN;
        public List<PIA_3> PIA;
        public List<QTY_8> QTY;
        public List<QVR> QVR;
        public List<DTM_38> DTM;
        public List<Loop_RFF_RECADV> RFFLoop;
        public List<Loop_PCI_RECADV_2> PCILoop;
    }
    public class Loop_NAD_RECADV
    {
        public NAD_32 NAD;
        public List<Loop_RFF_RECADV_2> RFFLoop;
        public List<Loop_CTA_RECADV> CTALoop;
    }
    public class Loop_PAC_RECADV
    {
        public PAC_12 PAC;
        public QVR QVR;
        public List<Loop_PCI_RECADV> PCILoop;
    }
    public class Loop_PCI_RECADV
    {
        public PCI PCI;
        public List<Loop_GIN_RECADV> GINLoop;
    }
    public class Loop_PCI_RECADV_2
    {
        public PCI PCI;
        public QTY_8 QTY;
        public QVR QVR;
        public List<Loop_GIN_RECADV> GINLoop;
    }
    public class Loop_RFF_RECADV
    {
        public RFF_32 RFF;
        public DTM_38 DTM;
    }
    public class Loop_RFF_RECADV_2
    {
        public RFF_32 RFF;
    }
    public class Loop_TDT_RECADV
    {
        public TDT_8 TDT;
    }
    public class TSRECADV 
    {
        public UNH UNH;
        public BGM_37 BGM;
        public List<DTM_38> DTM;
        public List<Loop_RFF_RECADV> RFFLoop;
        public List<Loop_NAD_RECADV> NADLoop;
        public List<Loop_TDT_RECADV> TDTLoop;
        public List<Loop_CPS_RECADV> CPSLoop;
        public CNT_6 CNT;
        public UNT UNT;
    }
}
