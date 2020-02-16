namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CPS_INVRPT
    {
        public CPS CPS;
        public List<Loop_PAC_INVRPT> PACLoop;
    }
    public class Loop_CTA_INVRPT
    {
        public CTA_9 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_INVRPT
    {
        public CUX_3 CUX;
        public DTM_33 DTM;
    }
    public class Loop_INV_INVRPT
    {
        public INV INV;
        public QTY_17 QTY;
        public List<GIN_5> GIN;
        public List<LOC_15> LOC;
        public List<DTM_33> DTM;
        public List<STS_2> STS;
        public List<Loop_PRI_INVRPT> PRILoop;
        public List<Loop_RFF_INVRPT> RFFLoop;
        public List<Loop_CPS_INVRPT> CPSLoop;
    }
    public class Loop_LIN_INVRPT
    {
        public LIN LIN;
        public List<PIA_8> PIA;
        public List<IMD_6> IMD;
        public List<ALI> ALI;
        public List<Loop_INV_INVRPT> INVLoop;
    }
    public class Loop_NAD_INVRPT
    {
        public NAD_37 NAD;
        public List<Loop_RFF_INVRPT_2> RFFLoop;
        public List<Loop_CTA_INVRPT> CTALoop;
    }
    public class Loop_PAC_INVRPT
    {
        public PAC_8 PAC;
        public List<Loop_PCI_INVRPT> PCILoop;
    }
    public class Loop_PCI_INVRPT
    {
        public PCI_7 PCI;
        public List<DTM_33> DTM;
        public List<GIN_5> GIN;
    }
    public class Loop_PRI_INVRPT
    {
        public PRI_7 PRI;
    }
    public class Loop_RFF_INVRPT
    {
        public RFF_25 RFF;
        public DTM_33 DTM;
    }
    public class Loop_RFF_INVRPT_2
    {
        public RFF_25 RFF;
    }
    public class TSINVRPT 
    {
        public UNH UNH;
        public BGM_24 BGM;
        public List<DTM_33> DTM;
        public List<Loop_RFF_INVRPT> RFFLoop;
        public List<Loop_NAD_INVRPT> NADLoop;
        public List<Loop_CUX_INVRPT> CUXLoop;
        public List<Loop_LIN_INVRPT> LINLoop;
        public UNT UNT;
    }
}
