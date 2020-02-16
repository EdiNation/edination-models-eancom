namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CPS_INVRPT
    {
        public CPS CPS;
        public List<Loop_PAC_INVRPT> PACLoop;
    }
    public class Loop_CPS_INVRPT_2
    {
        public CPS CPS;
        public List<Loop_PAC_INVRPT_2> PACLoop;
    }
    public class Loop_CTA_INVRPT
    {
        public CTA_10 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_INVRPT
    {
        public CUX_11 CUX;
        public DTM_8 DTM;
    }
    public class Loop_LIN_INVRPT
    {
        public LIN_3 LIN;
        public List<IMD_2> IMD;
        public List<MEA_6> MEA;
        public List<LOC> LOC;
        public List<DTM_8> DTM;
        public List<Loop_RFF_INVRPT> RFFLoop;
        public List<Loop_QTY_INVRPT_2> QTYLoop;
    }
    public class Loop_NAD_INVRPT
    {
        public NAD_21 NAD;
        public List<LOC> LOC;
        public List<Loop_RFF_INVRPT> RFFLoop;
        public List<Loop_CTA_INVRPT> CTALoop;
    }
    public class Loop_PAC_INVRPT
    {
        public PAC_12 PAC;
        public List<PCI_2> PCI;
        public List<Loop_QTY_INVRPT> QTYLoop;
    }
    public class Loop_PAC_INVRPT_2
    {
        public PAC_3 PAC;
        public List<GIN_3> GIN;
        public List<DTM_8> DTM;
    }
    public class Loop_PRI_INVRPT
    {
        public PRI_9 PRI;
        public CUX_6 CUX;
        public DTM_8 DTM;
    }
    public class Loop_QTY_INVRPT
    {
        public QTY_23 QTY;
        public List<GIN_3> GIN;
        public List<DTM_8> DTM;
    }
    public class Loop_QTY_INVRPT_2
    {
        public QTY_12 QTY;
        public List<GIN_3> GIN;
        public List<LOC> LOC;
        public List<DTM_8> DTM;
        public List<Loop_PRI_INVRPT> PRILoop;
        public List<Loop_RFF_INVRPT> RFFLoop;
        public List<Loop_CPS_INVRPT_2> CPSLoop;
    }
    public class Loop_RFF_INVRPT
    {
        public RFF_15 RFF;
        public DTM_8 DTM;
    }
    public class TSINVRPT 
    {
        public UNH UNH;
        public BGM_9 BGM;
        public List<DTM_8> DTM;
        public List<Loop_RFF_INVRPT> RFFLoop;
        public List<Loop_NAD_INVRPT> NADLoop;
        public List<Loop_CUX_INVRPT> CUXLoop;
        public List<Loop_CPS_INVRPT> CPSLoop;
        public List<Loop_LIN_INVRPT> LINLoop;
        public UNT UNT;
    }
}
