namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CTA_IFTMAN
    {
        public CTA_2 CTA;
        public List<COM> COM;
    }
    public class Loop_DGS_IFTMAN
    {
        public DGS DGS;
        public List<FTX_3> FTX;
        public List<Loop_CTA_IFTMAN> CTALoop;
        public List<Loop_MEA_IFTMAN> MEALoop;
    }
    public class Loop_DIM_IFTMAN
    {
        public DIM DIM;
        public EQN EQN;
    }
    public class Loop_EQD_IFTMAN
    {
        public EQD EQD;
        public List<MEA_6> MEA;
        public List<DIM> DIM;
        public List<SEL> SEL;
        public List<Loop_NAD_IFTMAN_3> NADLoop;
    }
    public class Loop_GID_IFTMAN
    {
        public GID GID;
        public TMP_2 TMP;
        public RNG_4 RNG;
        public List<FTX_3> FTX;
        public List<Loop_NAD_IFTMAN_2> NADLoop;
        public List<Loop_MEA_IFTMAN> MEALoop;
        public List<Loop_DIM_IFTMAN> DIMLoop;
        public List<Loop_RFF_IFTMAN_2> RFFLoop;
        public List<Loop_PCI_IFTMAN> PCILoop;
        public List<Loop_SGP_IFTMAN> SGPLoop;
        public List<Loop_DGS_IFTMAN> DGSLoop;
    }
    public class Loop_LOC_IFTMAN
    {
        public LOC_9 LOC;
    }
    public class Loop_MEA_IFTMAN
    {
        public MEA_6 MEA;
        public EQN EQN;
    }
    public class Loop_NAD_IFTMAN
    {
        public NAD_12 NAD;
        public List<Loop_CTA_IFTMAN> CTALoop;
        public List<Loop_RFF_IFTMAN_2> RFFLoop;
    }
    public class Loop_NAD_IFTMAN_2
    {
        public NAD_12 NAD;
        public DTM_26 DTM;
    }
    public class Loop_NAD_IFTMAN_3
    {
        public NAD_12 NAD;
    }
    public class Loop_PCI_IFTMAN
    {
        public PCI_5 PCI;
        public List<GIN_2> GIN;
    }
    public class Loop_RFF_IFTMAN
    {
        public RFF_17 RFF;
        public List<DTM_26> DTM;
    }
    public class Loop_RFF_IFTMAN_2
    {
        public RFF_17 RFF;
    }
    public class Loop_SGP_IFTMAN
    {
        public SGP SGP;
    }
    public class Loop_TDT_IFTMAN
    {
        public TDT_5 TDT;
        public List<DTM_26> DTM;
        public List<Loop_LOC_IFTMAN> LOCLoop;
    }
    public class TSIFTMAN 
    {
        public UNH UNH;
        public BGM_15 BGM;
        public List<DTM_26> DTM;
        public List<TSR_2> TSR;
        public List<MOA_24> MOA;
        public List<FTX_3> FTX;
        public List<CNT_7> CNT;
        public List<Loop_LOC_IFTMAN> LOCLoop;
        public List<Loop_RFF_IFTMAN> RFFLoop;
        public List<Loop_TDT_IFTMAN> TDTLoop;
        public List<Loop_NAD_IFTMAN> NADLoop;
        public List<Loop_GID_IFTMAN> GIDLoop;
        public List<Loop_EQD_IFTMAN> EQDLoop;
        public UNT UNT;
    }
}
