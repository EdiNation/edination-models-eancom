namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CNI_IFTSTA
    {
        public CNI CNI;
        public List<Loop_STS_IFTSTA> STSLoop;
    }
    public class Loop_DIM_IFTSTA
    {
        public DIM DIM;
        public EQN_2 EQN;
    }
    public class Loop_EQA_IFTSTA
    {
        public EQA_2 EQA;
        public List<SEL> SEL;
    }
    public class Loop_EQD_IFTSTA
    {
        public EQD EQD;
        public List<MEA_6> MEA;
        public List<DIM> DIM;
        public List<SEL> SEL;
        public List<Loop_EQA_IFTSTA> EQALoop;
    }
    public class Loop_GID_IFTSTA
    {
        public GID_2 GID;
        public List<HAN> HAN;
        public List<PCI> PCI;
        public List<Loop_MEA_IFTSTA> MEALoop;
        public List<Loop_DIM_IFTSTA> DIMLoop;
    }
    public class Loop_MEA_IFTSTA
    {
        public MEA_6 MEA;
        public EQN_2 EQN;
    }
    public class Loop_STS_IFTSTA
    {
        public STS_2 STS;
        public List<RFF_22> RFF;
        public DTM_23 DTM;
        public List<FTX_13> FTX;
        public List<NAD_18> NAD;
        public LOC_3 LOC;
        public List<PCI> PCI;
        public List<Loop_TDT_IFTSTA> TDTLoop;
        public List<Loop_EQD_IFTSTA> EQDLoop;
        public List<Loop_GID_IFTSTA> GIDLoop;
    }
    public class Loop_TDT_IFTSTA
    {
        public TDT_9 TDT;
        public List<RFF_22> RFF;
        public List<LOC_3> LOC;
        public List<DTM_23> DTM;
    }
    public class TSIFTSTA 
    {
        public UNH UNH;
        public BGM_7 BGM;
        public List<DTM_23> DTM;
        public TSR_2 TSR;
        public List<NAD_18> NAD;
        public List<RFF_22> RFF;
        public List<LOC_3> LOC;
        public List<FTX_25> FTX;
        public List<CNT_4> CNT;
        public List<Loop_CNI_IFTSTA> CNILoop;
        public UNT UNT;
    }
}
