namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_LIN_HANMOV
    {
        public LIN LIN;
        public List<PIA_4> PIA;
        public List<IMD_4> IMD;
        public List<HAN_2> HAN;
        public List<Loop_NAD_HANMOV_2> NADLoop;
        public List<QTY_9> QTY;
        public List<DTM_28> DTM;
        public List<FTX_11> FTX;
        public List<Loop_RFF_HANMOV_2> RFFLoop;
        public List<Loop_PAC_HANMOV> PACLoop;
    }
    public class Loop_NAD_HANMOV
    {
        public NAD_13 NAD;
        public List<LOC_21> LOC;
        public List<Loop_RFF_HANMOV_2> RFFLoop;
    }
    public class Loop_NAD_HANMOV_2
    {
        public NAD_13 NAD;
    }
    public class Loop_PAC_HANMOV
    {
        public PAC_7 PAC;
        public List<MEA_17> MEA;
        public List<QTY_9> QTY;
        public List<Loop_PCI_HANMOV> PCILoop;
    }
    public class Loop_PCI_HANMOV
    {
        public PCI_6 PCI;
        public List<GIN_6> GIN;
    }
    public class Loop_RFF_HANMOV
    {
        public RFF_17 RFF;
        public List<DTM_28> DTM;
    }
    public class Loop_RFF_HANMOV_2
    {
        public RFF_17 RFF;
    }
    public class TSHANMOV 
    {
        public UNH UNH;
        public BGM_15 BGM;
        public List<DTM_28> DTM;
        public List<HAN_2> HAN;
        public List<FTX_11> FTX;
        public List<Loop_RFF_HANMOV> RFFLoop;
        public List<Loop_NAD_HANMOV> NADLoop;
        public List<Loop_LIN_HANMOV> LINLoop;
        public UNT UNT;
    }
}
