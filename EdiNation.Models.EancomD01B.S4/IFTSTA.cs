namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CNI_IFTSTA
    {
        public CNI CNI;
        public List<Loop_STS_IFTSTA> STSLoop;
    }
    public class Loop_DIM_IFTSTA
    {
        public DIM_3 DIM;
    }
    public class Loop_GID_IFTSTA
    {
        public GID_2 GID;
        public List<Loop_MEA_IFTSTA> MEALoop;
        public List<Loop_DIM_IFTSTA> DIMLoop;
        public List<Loop_PCI_IFTSTA> PCILoop;
    }
    public class Loop_LOC_IFTSTA
    {
        public LOC_6 LOC;
        public List<DTM_44> DTM;
    }
    public class Loop_MEA_IFTSTA
    {
        public MEA_16 MEA;
    }
    public class Loop_NAD_IFTSTA
    {
        public NAD_17 NAD;
    }
    public class Loop_PCI_IFTSTA
    {
        public PCI_5 PCI;
        public List<GIN_2> GIN;
    }
    public class Loop_RFF_IFTSTA
    {
        public RFF_41 RFF;
    }
    public class Loop_STS_IFTSTA
    {
        public STS_3 STS;
        public List<RFF_41> RFF;
        public List<DTM_44> DTM;
        public List<FTX_24> FTX;
        public List<Loop_NAD_IFTSTA> NADLoop;
        public LOC_6 LOC;
        public List<Loop_TDT_IFTSTA> TDTLoop;
        public List<Loop_GID_IFTSTA> GIDLoop;
    }
    public class Loop_TDT_IFTSTA
    {
        public TDT_10 TDT;
        public List<Loop_LOC_IFTSTA> LOCLoop;
    }
    public class TSIFTSTA 
    {
        public UNH UNH;
        public BGM_21 BGM;
        public List<DTM_44> DTM;
        public List<Loop_NAD_IFTSTA> NADLoop;
        public List<Loop_RFF_IFTSTA> RFFLoop;
        public List<FTX_24> FTX;
        public List<Loop_CNI_IFTSTA> CNILoop;
        public UNT UNT;
    }
}
