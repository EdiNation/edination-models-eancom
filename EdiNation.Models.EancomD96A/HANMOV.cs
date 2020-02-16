namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_LIN_HANMOV
    {
        public LIN_6 LIN;
        public List<PIA_3> PIA;
        public List<IMD_4> IMD;
        public List<HAN_2> HAN;
        public List<Loop_NAD_HANMOV_2> NADLoop;
        public List<QTY_7> QTY;
        public List<DTM_25> DTM;
        public List<FTX_10> FTX;
        public List<Loop_RFF_HANMOV_2> RFFLoop;
        public List<Loop_PAC_HANMOV> PACLoop;
    }
    public class Loop_NAD_HANMOV
    {
        public NAD_11 NAD;
        public List<LOC_17> LOC;
        public List<Loop_RFF_HANMOV_2> RFFLoop;
    }
    public class Loop_NAD_HANMOV_2
    {
        public NAD_11 NAD;
    }
    public class Loop_PAC_HANMOV
    {
        public PAC_6 PAC;
        public List<MEA_15> MEA;
        public List<QTY_7> QTY;
        public List<Loop_PCI_HANMOV> PCILoop;
    }
    public class Loop_PCI_HANMOV
    {
        public PCI_3 PCI;
        public List<GIN_5> GIN;
    }
    public class Loop_RFF_HANMOV
    {
        public RFF_15 RFF;
        public List<DTM_25> DTM;
    }
    public class Loop_RFF_HANMOV_2
    {
        public RFF_15 RFF;
    }
    public class TSHANMOV 
    {
        public UNH UNH;
        public BGM_13 BGM;
        public List<DTM_25> DTM;
        public List<HAN_2> HAN;
        public List<FTX_10> FTX;
        public List<Loop_RFF_HANMOV> RFFLoop;
        public List<Loop_NAD_HANMOV> NADLoop;
        public List<Loop_LIN_HANMOV> LINLoop;
        public UNT UNT;
    }
}
