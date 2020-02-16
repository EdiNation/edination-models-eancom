namespace EdiNation.Edifact.EAND96A
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
        public CUX_8 CUX;
        public DTM_32 DTM;
    }
    public class Loop_LIN_INVRPT
    {
        public LIN_6 LIN;
        public List<PIA_7> PIA;
        public List<IMD_7> IMD;
        public List<Loop_QTY_INVRPT> QTYLoop;
    }
    public class Loop_NAD_INVRPT
    {
        public NAD_37 NAD;
        public List<Loop_RFF_INVRPT_2> RFFLoop;
        public List<Loop_CTA_INVRPT> CTALoop;
    }
    public class Loop_PAC_INVRPT
    {
        public PAC_7 PAC;
        public List<Loop_PCI_INVRPT> PCILoop;
    }
    public class Loop_PCI_INVRPT
    {
        public PCI_4 PCI;
        public List<DTM_32> DTM;
        public List<GIN_3> GIN;
    }
    public class Loop_PRI_INVRPT
    {
        public PRI_9 PRI;
    }
    public class Loop_QTY_INVRPT
    {
        public QTY_17 QTY;
        public INV INV;
        public List<GIN_3> GIN;
        public List<LOC_19> LOC;
        public List<DTM_32> DTM;
        public List<STS_2> STS;
        public List<Loop_PRI_INVRPT> PRILoop;
        public List<Loop_RFF_INVRPT> RFFLoop;
        public List<Loop_CPS_INVRPT> CPSLoop;
    }
    public class Loop_RFF_INVRPT
    {
        public RFF_23 RFF;
        public DTM_32 DTM;
    }
    public class Loop_RFF_INVRPT_2
    {
        public RFF_23 RFF;
    }
    public class TSINVRPT 
    {
        public UNH UNH;
        public BGM_22 BGM;
        public List<DTM_32> DTM;
        public List<Loop_RFF_INVRPT> RFFLoop;
        public List<Loop_NAD_INVRPT> NADLoop;
        public List<Loop_CUX_INVRPT> CUXLoop;
        public List<Loop_LIN_INVRPT> LINLoop;
        public UNT UNT;
    }
}
