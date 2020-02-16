namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CNI_IFCSUM
    {
        public CNI CNI;
        public List<DTM_5> DTM;
        public List<CNT> CNT;
        public List<TSR> TSR;
        public List<MOA_6> MOA;
        public List<FTX_2> FTX;
        public List<Loop_TOD_IFCSUM> TODLoop;
        public List<Loop_RFF_IFCSUM> RFFLoop;
        public List<Loop_NAD_IFCSUM_2> NADLoop;
        public List<Loop_GID_IFCSUM> GIDLoop;
        public List<Loop_EQD_IFCSUM_2> EQDLoop;
    }
    public class Loop_CTA_IFCSUM
    {
        public CTA_2 CTA;
        public List<COM> COM;
    }
    public class Loop_DGS_IFCSUM
    {
        public DGS DGS;
        public List<FTX_2> FTX;
        public List<Loop_CTA_IFCSUM> CTALoop;
        public List<Loop_MEA_IFCSUM> MEALoop;
    }
    public class Loop_DIM_IFCSUM
    {
        public DIM_2 DIM;
        public EQN_2 EQN;
    }
    public class Loop_DOC_IFCSUM
    {
        public DOC DOC;
        public DTM_5 DTM;
    }
    public class Loop_DOC_IFCSUM_2
    {
        public DOC DOC;
        public List<DTM_5> DTM;
    }
    public class Loop_EQD_IFCSUM
    {
        public EQD EQD;
        public EQN_2 EQN;
        public List<SEL> SEL;
        public List<NAD_2> NAD;
    }
    public class Loop_EQD_IFCSUM_2
    {
        public EQD EQD;
        public EQN_2 EQN;
        public List<MEA_5> MEA;
        public List<DIM_2> DIM;
        public List<SEL> SEL;
        public List<Loop_NAD_IFCSUM_4> NADLoop;
    }
    public class Loop_GID_IFCSUM
    {
        public GID GID;
        public HAN_4 HAN;
        public TMP TMP;
        public RNG_4 RNG;
        public List<MOA_6> MOA;
        public List<PIA_3> PIA;
        public List<FTX_2> FTX;
        public List<Loop_NAD_IFCSUM_3> NADLoop;
        public List<Loop_MEA_IFCSUM> MEALoop;
        public List<Loop_DIM_IFCSUM> DIMLoop;
        public List<Loop_RFF_IFCSUM> RFFLoop;
        public List<Loop_PCI_IFCSUM> PCILoop;
        public List<Loop_DOC_IFCSUM_2> DOCLoop;
        public List<Loop_SGP_IFCSUM> SGPLoop;
        public List<Loop_DGS_IFCSUM> DGSLoop;
    }
    public class Loop_MEA_IFCSUM
    {
        public MEA_5 MEA;
        public EQN_2 EQN;
    }
    public class Loop_NAD_IFCSUM
    {
        public NAD_2 NAD;
        public List<LOC_10> LOC;
        public List<Loop_CTA_IFCSUM> CTALoop;
        public List<Loop_DOC_IFCSUM> DOCLoop;
    }
    public class Loop_NAD_IFCSUM_2
    {
        public NAD_2 NAD;
        public List<LOC_10> LOC;
        public List<Loop_CTA_IFCSUM> CTALoop;
        public List<Loop_DOC_IFCSUM> DOCLoop;
        public List<Loop_RFF_IFCSUM_2> RFFLoop;
    }
    public class Loop_NAD_IFCSUM_3
    {
        public NAD_2 NAD;
        public DTM_5 DTM;
    }
    public class Loop_NAD_IFCSUM_4
    {
        public NAD_2 NAD;
    }
    public class Loop_PCI_IFCSUM
    {
        public PCI_4 PCI;
        public List<GIN_2> GIN;
    }
    public class Loop_RFF_IFCSUM
    {
        public RFF_16 RFF;
        public List<DTM_5> DTM;
    }
    public class Loop_RFF_IFCSUM_2
    {
        public RFF_16 RFF;
    }
    public class Loop_SGP_IFCSUM
    {
        public SGP SGP;
    }
    public class Loop_TDT_IFCSUM
    {
        public TDT_5 TDT;
        public List<TSR> TSR;
        public List<LOC_10> LOC;
        public List<DTM_5> DTM;
        public List<Loop_NAD_IFCSUM> NADLoop;
    }
    public class Loop_TOD_IFCSUM
    {
        public TOD_4 TOD;
        public List<LOC_10> LOC;
    }
    public class TSIFCSUM 
    {
        public UNH UNH;
        public BGM_14 BGM;
        public List<DTM_5> DTM;
        public List<FTX_2> FTX;
        public List<CNT> CNT;
        public List<Loop_RFF_IFCSUM> RFFLoop;
        public List<Loop_TDT_IFCSUM> TDTLoop;
        public List<Loop_EQD_IFCSUM> EQDLoop;
        public List<Loop_CNI_IFCSUM> CNILoop;
        public UNT UNT;
    }
}
