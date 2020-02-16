namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_ALC_CNTCND
    {
        public ALC ALC;
        public List<DTM_23> DTM;
        public List<Loop_PCD_CNTCND> PCDLoop;
        public List<Loop_MOA_CNTCND> MOALoop;
    }
    public class Loop_ALC_CNTCND_2
    {
        public ALC ALC;
        public List<DTM_23> DTM;
        public List<Loop_PCD_CNTCND> PCDLoop;
        public List<Loop_MOA_CNTCND> MOALoop;
    }
    public class Loop_CTA_CNTCND
    {
        public CTA_9 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_CNTCND
    {
        public CUX CUX;
    }
    public class Loop_LIN_CNTCND
    {
        public LIN LIN;
        public List<PIA_4> PIA;
        public List<IMD_2> IMD;
        public List<Loop_RFF_CNTCND> RFFLoop;
        public List<Loop_TAX_CNTCND> TAXLoop;
        public List<Loop_QTY_CNTCND> QTYLoop;
        public List<Loop_ALC_CNTCND_2> ALCLoop;
        public List<Loop_PRI_CNTCND_2> PRILoop;
        public List<Loop_TOD_CNTCND> TODLoop;
        public List<Loop_PAC_CNTCND> PACLoop;
        public List<Loop_NAD_CNTCND> NADLoop;
    }
    public class Loop_MOA_CNTCND
    {
        public MOA_14 MOA;
        public List<RNG_2> RNG;
    }
    public class Loop_NAD_CNTCND
    {
        public NAD_5 NAD;
    }
    public class Loop_PAC_CNTCND
    {
        public PAC PAC;
    }
    public class Loop_PAT_CNTCND
    {
        public PAT_4 PAT;
        public List<DTM_23> DTM;
        public List<PCD_2> PCD;
    }
    public class Loop_PCD_CNTCND
    {
        public PCD_2 PCD;
        public List<RNG_2> RNG;
    }
    public class Loop_PRI_CNTCND
    {
        public PRI PRI;
        public List<RNG_2> RNG;
    }
    public class Loop_PRI_CNTCND_2
    {
        public PRI PRI;
        public List<RNG_2> RNG;
        public List<DTM_23> DTM;
    }
    public class Loop_QTY_CNTCND
    {
        public QTY_12 QTY;
        public List<DTM_23> DTM;
    }
    public class Loop_RFF_CNTCND
    {
        public RFF_9 RFF;
        public List<DTM_23> DTM;
    }
    public class Loop_SEQ_CNTCND
    {
        public SEQ SEQ;
        public NAD_5 NAD;
        public List<Loop_CTA_CNTCND> CTALoop;
    }
    public class Loop_TAX_CNTCND
    {
        public TAX_2 TAX;
    }
    public class Loop_TOD_CNTCND
    {
        public TOD TOD;
    }
    public class TSCNTCND 
    {
        public UNH UNH;
        public BGM_3 BGM;
        public List<DTM_23> DTM;
        public List<PAI_8> PAI;
        public List<TOD> TOD;
        public List<Loop_RFF_CNTCND> RFFLoop;
        public List<Loop_PRI_CNTCND> PRILoop;
        public List<Loop_QTY_CNTCND> QTYLoop;
        public List<Loop_CUX_CNTCND> CUXLoop;
        public List<Loop_TAX_CNTCND> TAXLoop;
        public List<Loop_PAT_CNTCND> PATLoop;
        public List<Loop_SEQ_CNTCND> SEQLoop;
        public List<Loop_ALC_CNTCND> ALCLoop;
        public List<Loop_LIN_CNTCND> LINLoop;
        public UNT UNT;
    }
}
