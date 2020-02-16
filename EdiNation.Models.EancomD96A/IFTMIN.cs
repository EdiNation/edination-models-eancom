namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CTA_IFTMIN
    {
        public CTA_3 CTA;
        public List<COM> COM;
    }
    public class Loop_DGS_IFTMIN
    {
        public DGS_3 DGS;
        public List<FTX_6> FTX;
        public List<Loop_CTA_IFTMIN> CTALoop;
        public List<Loop_MEA_IFTMIN> MEALoop;
    }
    public class Loop_DIM_IFTMIN
    {
        public DIM_2 DIM;
        public EQN EQN;
    }
    public class Loop_DOC_IFTMIN
    {
        public DOC_2 DOC;
        public DTM_29 DTM;
    }
    public class Loop_DOC_IFTMIN_2
    {
        public DOC_2 DOC;
        public List<DTM_29> DTM;
    }
    public class Loop_EQD_IFTMIN
    {
        public EQD EQD;
        public List<MEA_7> MEA;
        public List<DIM_2> DIM;
        public List<SEL> SEL;
        public List<Loop_NAD_IFTMIN_2> NADLoop;
    }
    public class Loop_GID_IFTMIN
    {
        public GID GID;
        public HAN_6 HAN;
        public TMP TMP;
        public RNG_4 RNG;
        public List<LOC_6> LOC;
        public List<MOA_6> MOA;
        public List<PIA_3> PIA;
        public List<FTX_6> FTX;
        public List<Loop_NAD_IFTMIN_2> NADLoop;
        public List<Loop_MEA_IFTMIN> MEALoop;
        public List<Loop_DIM_IFTMIN> DIMLoop;
        public List<Loop_RFF_IFTMIN> RFFLoop;
        public List<Loop_PCI_IFTMIN> PCILoop;
        public List<Loop_DOC_IFTMIN_2> DOCLoop;
        public List<Loop_SGP_IFTMIN> SGPLoop;
        public List<Loop_DGS_IFTMIN> DGSLoop;
    }
    public class Loop_LOC_IFTMIN
    {
        public LOC_6 LOC;
    }
    public class Loop_MEA_IFTMIN
    {
        public MEA_7 MEA;
        public EQN EQN;
    }
    public class Loop_NAD_IFTMIN
    {
        public NAD_14 NAD;
        public List<Loop_CTA_IFTMIN> CTALoop;
        public List<Loop_DOC_IFTMIN> DOCLoop;
        public List<Loop_RFF_IFTMIN> RFFLoop;
    }
    public class Loop_NAD_IFTMIN_2
    {
        public NAD_14 NAD;
        public DTM_29 DTM;
    }
    public class Loop_PCI_IFTMIN
    {
        public PCI_4 PCI;
        public List<GIN_2> GIN;
    }
    public class Loop_RFF_IFTMIN
    {
        public RFF_20 RFF;
        public List<DTM_29> DTM;
    }
    public class Loop_SGP_IFTMIN
    {
        public SGP SGP;
    }
    public class Loop_TDT_IFTMIN
    {
        public TDT_10 TDT;
        public List<DTM_29> DTM;
        public List<Loop_LOC_IFTMIN> LOCLoop;
    }
    public class Loop_TOD_IFTMIN
    {
        public TOD_4 TOD;
        public List<LOC_6> LOC;
    }
    public class TSIFTMIN 
    {
        public UNH UNH;
        public BGM_18 BGM;
        public List<DTM_29> DTM;
        public List<TSR_3> TSR;
        public List<MOA_6> MOA;
        public List<FTX_6> FTX;
        public List<CNT_7> CNT;
        public List<Loop_TOD_IFTMIN> TODLoop;
        public List<Loop_RFF_IFTMIN> RFFLoop;
        public List<Loop_TDT_IFTMIN> TDTLoop;
        public List<Loop_NAD_IFTMIN> NADLoop;
        public List<Loop_GID_IFTMIN> GIDLoop;
        public List<Loop_EQD_IFTMIN> EQDLoop;
        public UNT UNT;
    }
}
