namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CTA_IFTMBF
    {
        public CTA_9 CTA;
        public List<COM_2> COM;
    }
    public class Loop_DGS_IFTMBF
    {
        public DGS_2 DGS;
        public List<FTX_5> FTX;
    }
    public class Loop_DIM_IFTMBF
    {
        public DIM_2 DIM;
        public EQN EQN;
    }
    public class Loop_DOC_IFTMBF
    {
        public DOC_10 DOC;
    }
    public class Loop_EQD_IFTMBF
    {
        public EQD EQD;
        public EQN EQN;
        public List<Loop_NAD_IFTMBF_3> NADLoop;
    }
    public class Loop_GID_IFTMBF
    {
        public GID GID;
        public HAN_5 HAN;
        public TMP_2 TMP;
        public RNG_5 RNG;
        public List<MOA_22> MOA;
        public List<PIA_4> PIA;
        public List<FTX_5> FTX;
        public List<Loop_NAD_IFTMBF_2> NADLoop;
        public List<Loop_MEA_IFTMBF> MEALoop;
        public List<Loop_DIM_IFTMBF> DIMLoop;
        public List<Loop_RFF_IFTMBF_2> RFFLoop;
        public List<Loop_DOC_IFTMBF> DOCLoop;
        public List<Loop_DGS_IFTMBF> DGSLoop;
    }
    public class Loop_LOC_IFTMBF
    {
        public LOC_5 LOC;
    }
    public class Loop_MEA_IFTMBF
    {
        public MEA_6 MEA;
        public EQN EQN;
    }
    public class Loop_NAD_IFTMBF
    {
        public NAD_15 NAD;
        public List<LOC_5> LOC;
        public List<Loop_CTA_IFTMBF> CTALoop;
    }
    public class Loop_NAD_IFTMBF_2
    {
        public NAD_15 NAD;
        public DTM_31 DTM;
    }
    public class Loop_NAD_IFTMBF_3
    {
        public NAD_15 NAD;
    }
    public class Loop_RFF_IFTMBF
    {
        public RFF_21 RFF;
        public List<DTM_31> DTM;
    }
    public class Loop_RFF_IFTMBF_2
    {
        public RFF_21 RFF;
    }
    public class Loop_TDT_IFTMBF
    {
        public TDT_2 TDT;
        public List<DTM_31> DTM;
        public List<Loop_LOC_IFTMBF> LOCLoop;
    }
    public class Loop_TOD_IFTMBF
    {
        public TOD_5 TOD;
        public List<LOC_5> LOC;
    }
    public class TSIFTMBF 
    {
        public UNH UNH;
        public BGM_19 BGM;
        public List<DTM_31> DTM;
        public List<TSR_3> TSR;
        public List<FTX_5> FTX;
        public List<CNT_7> CNT;
        public List<Loop_TOD_IFTMBF> TODLoop;
        public List<Loop_RFF_IFTMBF> RFFLoop;
        public List<Loop_TDT_IFTMBF> TDTLoop;
        public List<Loop_NAD_IFTMBF> NADLoop;
        public List<Loop_GID_IFTMBF> GIDLoop;
        public List<Loop_EQD_IFTMBF> EQDLoop;
        public UNT UNT;
    }
}
