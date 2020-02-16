namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_LIN_HANMOV
    {
        public LIN_2 LIN;
        public List<PIA_6> PIA;
        public List<IMD_8> IMD;
        public List<HAN_3> HAN;
        public List<Loop_NAD_HANMOV_2> NADLoop;
        public List<QTY_8> QTY;
        public List<DTM_12> DTM;
        public List<FTX_7> FTX;
        public List<Loop_RFF_HANMOV_2> RFFLoop;
        public List<Loop_PAC_HANMOV> PACLoop;
    }
    public class Loop_NAD_HANMOV
    {
        public NAD_7 NAD;
        public List<LOC_11> LOC;
        public List<Loop_RFF_HANMOV_2> RFFLoop;
    }
    public class Loop_NAD_HANMOV_2
    {
        public NAD_7 NAD;
    }
    public class Loop_PAC_HANMOV
    {
        public PAC_10 PAC;
        public List<MEA_18> MEA;
        public List<QTY_8> QTY;
        public List<Loop_PCI_HANMOV> PCILoop;
    }
    public class Loop_PCI_HANMOV
    {
        public PCI_7 PCI;
        public List<GIN_4> GIN;
    }
    public class Loop_RFF_HANMOV
    {
        public RFF_13 RFF;
        public DTM_12 DTM;
    }
    public class Loop_RFF_HANMOV_2
    {
        public RFF_13 RFF;
    }
    public class TSHANMOV 
    {
        public UNH UNH;
        public BGM_5 BGM;
        public List<DTM_12> DTM;
        public List<HAN_3> HAN;
        public List<FTX_24> FTX;
        public List<Loop_RFF_HANMOV> RFFLoop;
        public List<Loop_NAD_HANMOV> NADLoop;
        public List<Loop_LIN_HANMOV> LINLoop;
        public UNT UNT;
    }
}
