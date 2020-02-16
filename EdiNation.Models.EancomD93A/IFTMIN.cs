namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CPI_IFTMIN
    {
        public CPI CPI;
        public CUX CUX;
        public List<LOC_7> LOC;
        public List<MOA_8> MOA;
    }
    public class Loop_CTA_IFTMIN
    {
        public CTA CTA;
        public List<COM> COM;
    }
    public class Loop_DGS_IFTMIN
    {
        public DGS_2 DGS;
        public List<FTX_16> FTX;
        public List<Loop_CTA_IFTMIN> CTALoop;
        public List<Loop_MEA_IFTMIN_3> MEALoop;
        public List<Loop_SGP_IFTMIN> SGPLoop;
    }
    public class Loop_DIM_IFTMIN
    {
        public DIM_2 DIM;
        public EQN EQN;
    }
    public class Loop_DOC_IFTMIN
    {
        public DOC_9 DOC;
        public DTM_7 DTM;
    }
    public class Loop_DOC_IFTMIN_2
    {
        public DOC_2 DOC;
        public DTM_7 DTM;
    }
    public class Loop_DOC_IFTMIN_3
    {
        public DOC_2 DOC;
        public List<DTM_7> DTM;
    }
    public class Loop_EQA_IFTMIN
    {
        public EQA EQA;
        public EQN EQN;
    }
    public class Loop_EQD_IFTMIN
    {
        public EQD_3 EQD;
        public EQN EQN;
        public TMD TMD;
        public List<MEA_13> MEA;
        public List<DIM_2> DIM;
        public List<SEL_2> SEL;
        public List<TPL> TPL;
        public HAN HAN;
        public TMP TMP;
        public List<FTX_4> FTX;
        public List<Loop_TCC_IFTMIN_2> TCCLoop;
        public List<Loop_NAD_IFTMIN_2> NADLoop;
        public List<Loop_EQA_IFTMIN> EQALoop;
    }
    public class Loop_GDS_IFTMIN
    {
        public GDS GDS;
        public FTX_4 FTX;
    }
    public class Loop_GID_IFTMIN
    {
        public GID GID;
        public HAN_5 HAN;
        public TMP_2 TMP;
        public RNG_7 RNG;
        public TMD TMD;
        public List<LOC_7> LOC;
        public List<MOA_14> MOA;
        public List<PIA_3> PIA;
        public List<FTX_16> FTX;
        public List<Loop_NAD_IFTMIN_2> NADLoop;
        public List<Loop_GDS_IFTMIN> GDSLoop;
        public List<Loop_MEA_IFTMIN> MEALoop;
        public List<Loop_DIM_IFTMIN> DIMLoop;
        public List<Loop_RFF_IFTMIN> RFFLoop;
        public List<Loop_PCI_IFTMIN> PCILoop;
        public List<Loop_DOC_IFTMIN_3> DOCLoop;
        public List<Loop_TPL_IFTMIN> TPLLoop;
        public List<Loop_SGP_IFTMIN> SGPLoop;
        public List<Loop_TCC_IFTMIN_3> TCCLoop;
        public List<Loop_DGS_IFTMIN> DGSLoop;
    }
    public class Loop_GOR_IFTMIN
    {
        public GOR GOR;
        public List<FTX_4> FTX;
        public List<Loop_DOC_IFTMIN> DOCLoop;
    }
    public class Loop_LOC_IFTMIN
    {
        public LOC_7 LOC;
        public List<DTM_7> DTM;
    }
    public class Loop_MEA_IFTMIN
    {
        public MEA_17 MEA;
        public EQN EQN;
    }
    public class Loop_MEA_IFTMIN_2
    {
        public MEA_7 MEA;
        public EQN EQN;
    }
    public class Loop_MEA_IFTMIN_3
    {
        public MEA_13 MEA;
        public EQN EQN;
    }
    public class Loop_NAD_IFTMIN
    {
        public NAD_8 NAD;
        public List<LOC_7> LOC;
        public List<MOA_8> MOA;
        public List<Loop_CTA_IFTMIN> CTALoop;
        public List<Loop_DOC_IFTMIN_2> DOCLoop;
        public List<Loop_TCC_IFTMIN_2> TCCLoop;
        public List<Loop_RFF_IFTMIN> RFFLoop;
        public List<Loop_CPI_IFTMIN> CPILoop;
    }
    public class Loop_NAD_IFTMIN_2
    {
        public NAD_8 NAD;
        public DTM_7 DTM;
    }
    public class Loop_PCI_IFTMIN
    {
        public PCI_8 PCI;
        public RFF_14 RFF;
        public DTM_7 DTM;
    }
    public class Loop_RFF_IFTMIN
    {
        public RFF_14 RFF;
        public List<DTM_7> DTM;
    }
    public class Loop_RFF_IFTMIN_2
    {
        public RFF_14 RFF;
        public DTM_7 DTM;
    }
    public class Loop_SGP_IFTMIN
    {
        public SGP SGP;
        public List<Loop_MEA_IFTMIN_2> MEALoop;
    }
    public class Loop_TCC_IFTMIN
    {
        public TCC TCC;
        public LOC_7 LOC;
        public FTX_4 FTX;
        public CUX CUX;
        public PRI_3 PRI;
        public EQN EQN;
        public PCD_7 PCD;
        public List<MOA_8> MOA;
        public List<QTY_15> QTY;
    }
    public class Loop_TCC_IFTMIN_2
    {
        public TCC TCC;
        public PRI_3 PRI;
        public EQN EQN;
        public PCD_7 PCD;
        public List<MOA_8> MOA;
        public List<QTY_15> QTY;
    }
    public class Loop_TCC_IFTMIN_3
    {
        public TCC TCC;
        public PRI_3 PRI;
        public EQN EQN;
        public PCD_7 PCD;
        public List<MOA_8> MOA;
        public List<QTY_15> QTY;
        public List<LOC_7> LOC;
    }
    public class Loop_TDT_IFTMIN
    {
        public TDT_9 TDT;
        public List<DTM_7> DTM;
        public List<TSR> TSR;
        public List<LOC_7> LOC;
        public List<Loop_RFF_IFTMIN_2> RFFLoop;
    }
    public class Loop_TOD_IFTMIN
    {
        public TOD_6 TOD;
        public List<LOC_7> LOC;
    }
    public class Loop_TPL_IFTMIN
    {
        public TPL TPL;
        public List<Loop_MEA_IFTMIN_2> MEALoop;
    }
    public class TSIFTMIN 
    {
        public UNH UNH;
        public BGM_6 BGM;
        public CTA CTA;
        public List<COM> COM;
        public List<DTM_7> DTM;
        public List<TSR> TSR;
        public List<CUX> CUX;
        public List<MOA_14> MOA;
        public List<FTX_16> FTX;
        public List<CNT_3> CNT;
        public List<Loop_LOC_IFTMIN> LOCLoop;
        public Loop_TOD_IFTMIN TODLoop;
        public List<Loop_RFF_IFTMIN> RFFLoop;
        public List<Loop_GOR_IFTMIN> GORLoop;
        public List<Loop_CPI_IFTMIN> CPILoop;
        public List<Loop_TCC_IFTMIN> TCCLoop;
        public List<Loop_TDT_IFTMIN> TDTLoop;
        public List<Loop_NAD_IFTMIN> NADLoop;
        public List<Loop_GID_IFTMIN> GIDLoop;
        public List<Loop_EQD_IFTMIN> EQDLoop;
        public UNT UNT;
    }
}
