namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CTA_SLSFCT
    {
        public CTA_15 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_SLSFCT
    {
        public CUX_14 CUX;
        public List<DTM_20> DTM;
    }
    public class Loop_LIN_SLSFCT
    {
        public LIN_9 LIN;
        public List<PIA_14> PIA;
        public List<IMD_12> IMD;
        public List<RFF_5> RFF;
        public List<ALI_5> ALI;
        public List<MOA_18> MOA;
        public List<PRI_6> PRI;
        public List<QTY_21> QTY;
    }
    public class Loop_LOC_SLSFCT
    {
        public LOC_9 LOC;
        public List<DTM_20> DTM;
        public List<Loop_LIN_SLSFCT> LINLoop;
    }
    public class Loop_NAD_SLSFCT
    {
        public NAD_26 NAD;
        public List<Loop_CTA_SLSFCT> CTALoop;
    }
    public class Loop_RFF_SLSFCT
    {
        public RFF_5 RFF;
        public List<DTM_20> DTM;
    }
    public class TSSLSFCT 
    {
        public UNH UNH;
        public BGM_24 BGM;
        public List<DTM_20> DTM;
        public List<Loop_NAD_SLSFCT> NADLoop;
        public List<Loop_RFF_SLSFCT> RFFLoop;
        public List<Loop_CUX_SLSFCT> CUXLoop;
        public List<Loop_LOC_SLSFCT> LOCLoop;
        public UNT UNT;
    }
}
