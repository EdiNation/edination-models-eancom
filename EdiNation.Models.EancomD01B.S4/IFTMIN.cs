namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CTA_IFTMIN
    {
        public CTA_3 CTA;
        public List<COM> COM;
    }
    public class Loop_DGS_IFTMIN
    {
        public DGS_2 DGS;
        public List<FTX_8> FTX;
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
        public DTM_5 DTM;
    }
    public class Loop_DOC_IFTMIN_2
    {
        public DOC_2 DOC;
        public List<DTM_5> DTM;
    }
    public class Loop_EQD_IFTMIN
    {
        public EQD EQD;
        public EQN EQN;
        public List<MEA_8> MEA;
        public List<DIM_2> DIM;
        public List<SEL> SEL;
        public List<Loop_NAD_IFTMIN_2> NADLoop;
    }
    public class Loop_GID_IFTMIN
    {
        public GID GID;
        public List<HAN_6> HAN;
        public TMP TMP;
        public RNG_5 RNG;
        public List<LOC_2> LOC;
        public List<MOA_16> MOA;
        public List<PIA_4> PIA;
        public List<FTX_8> FTX;
        public List<Loop_NAD_IFTMIN_2> NADLoop;
        public List<GDS_2> GDS;
        public List<Loop_MEA_IFTMIN> MEALoop;
        public List<Loop_DIM_IFTMIN> DIMLoop;
        public List<Loop_RFF_IFTMIN> RFFLoop;
        public List<Loop_PCI_IFTMIN> PCILoop;
        public List<Loop_DOC_IFTMIN_2> DOCLoop;
        public List<Loop_SGP_IFTMIN> SGPLoop;
        public List<Loop_DGS_IFTMIN> DGSLoop;
    }
    public class Loop_GOR_IFTMIN
    {
        public GOR GOR;
        public List<DTM_5> DTM;
        public List<LOC_2> LOC;
        public List<SEL> SEL;
        public List<FTX_8> FTX;
        public List<Loop_DOC_IFTMIN> DOCLoop;
    }
    public class Loop_LOC_IFTMIN
    {
        public LOC_2 LOC;
        public List<DTM_5> DTM;
    }
    public class Loop_MEA_IFTMIN
    {
        public MEA_8 MEA;
        public EQN EQN;
    }
    public class Loop_NAD_IFTMIN
    {
        public NAD_16 NAD;
        public List<LOC_2> LOC;
        public List<MOA_16> MOA;
        public List<Loop_CTA_IFTMIN> CTALoop;
        public List<Loop_DOC_IFTMIN> DOCLoop;
        public List<Loop_RFF_IFTMIN> RFFLoop;
    }
    public class Loop_NAD_IFTMIN_2
    {
        public NAD_16 NAD;
        public DTM_5 DTM;
    }
    public class Loop_PCI_IFTMIN
    {
        public PCI_7 PCI;
        public List<GIN_2> GIN;
    }
    public class Loop_RFF_IFTMIN
    {
        public RFF_22 RFF;
        public List<DTM_5> DTM;
    }
    public class Loop_RFF_IFTMIN_2
    {
        public RFF_22 RFF;
        public DTM_5 DTM;
    }
    public class Loop_SGP_IFTMIN
    {
        public SGP SGP;
    }
    public class Loop_TDT_IFTMIN
    {
        public TDT_2 TDT;
        public List<DTM_5> DTM;
        public List<Loop_LOC_IFTMIN> LOCLoop;
        public List<Loop_RFF_IFTMIN_2> RFFLoop;
    }
    public class Loop_TOD_IFTMIN
    {
        public TOD_5 TOD;
        public List<LOC_2> LOC;
    }
    public class TSIFTMIN 
    {
        public UNH UNH;
        public BGM_20 BGM;
        public List<DTM_5> DTM;
        public List<TSR_4> TSR;
        public List<MOA_16> MOA;
        public List<FTX_8> FTX;
        public List<CNT_6> CNT;
        public List<Loop_TOD_IFTMIN> TODLoop;
        public List<Loop_RFF_IFTMIN> RFFLoop;
        public List<Loop_GOR_IFTMIN> GORLoop;
        public List<Loop_TDT_IFTMIN> TDTLoop;
        public List<Loop_NAD_IFTMIN> NADLoop;
        public List<Loop_GID_IFTMIN> GIDLoop;
        public List<Loop_EQD_IFTMIN> EQDLoop;
        public UNT UNT;
    }
}
