namespace EdiNation.Edifact.EAND01B.S4
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
    public class Loop_EQD_RECADV
    {
        public EQD_4 EQD;
        public List<Loop_SEL_RECADV> SELLoop;
    }
    public class Loop_GIN_RECADV
    {
        public GIN_2 GIN;
    }
    public class Loop_LIN_RECADV
    {
        public LIN LIN;
        public List<PIA_4> PIA;
        public List<QTY_10> QTY;
        public List<QVR> QVR;
        public List<DTM_39> DTM;
        public List<Loop_RFF_RECADV> RFFLoop;
        public List<Loop_PCI_RECADV_2> PCILoop;
    }
    public class Loop_NAD_RECADV
    {
        public NAD_40 NAD;
        public List<Loop_RFF_RECADV_2> RFFLoop;
        public List<Loop_CTA_RECADV> CTALoop;
    }
    public class Loop_PAC_RECADV
    {
        public PAC_11 PAC;
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
        public QTY_10 QTY;
        public QVR QVR;
        public List<Loop_GIN_RECADV> GINLoop;
    }
    public class Loop_RFF_RECADV
    {
        public RFF_35 RFF;
        public DTM_39 DTM;
    }
    public class Loop_RFF_RECADV_2
    {
        public RFF_35 RFF;
    }
    public class Loop_SEL_RECADV
    {
        public SEL_3 SEL;
        public List<CDI_2> CDI;
    }
    public class Loop_TDT_RECADV
    {
        public TDT_7 TDT;
    }
    public class TSRECADV 
    {
        public UNH UNH;
        public BGM_39 BGM;
        public List<DTM_39> DTM;
        public List<Loop_RFF_RECADV> RFFLoop;
        public List<Loop_NAD_RECADV> NADLoop;
        public List<Loop_TDT_RECADV> TDTLoop;
        public List<Loop_EQD_RECADV> EQDLoop;
        public List<Loop_CPS_RECADV> CPSLoop;
        public CNT_5 CNT;
        public UNT UNT;
    }
}
