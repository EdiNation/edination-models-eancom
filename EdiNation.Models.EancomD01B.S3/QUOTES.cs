namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_ALC_QUOTES
    {
        public ALC_7 ALC;
        public List<Loop_QTY_QUOTES> QTYLoop;
        public List<Loop_PCD_QUOTES> PCDLoop;
        public List<Loop_MOA_QUOTES_2> MOALoop;
        public List<Loop_RTE_QUOTES> RTELoop;
        public List<Loop_TAX_QUOTES_2> TAXLoop;
    }
    public class Loop_CTA_QUOTES
    {
        public CTA_6 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_QUOTES
    {
        public CUX CUX;
        public List<DTM_6> DTM;
    }
    public class Loop_LIN_QUOTES
    {
        public LIN LIN;
        public List<PIA_5> PIA;
        public List<IMD_3> IMD;
        public List<MEA_9> MEA;
        public List<QTY_8> QTY;
        public List<ALI> ALI;
        public List<DTM_6> DTM;
        public List<FTX_19> FTX;
        public List<Loop_MOA_QUOTES> MOALoop;
        public List<Loop_PRI_QUOTES> PRILoop;
        public List<Loop_RFF_QUOTES> RFFLoop;
        public List<Loop_LOC_QUOTES> LOCLoop;
        public List<Loop_TAX_QUOTES> TAXLoop;
        public List<Loop_PAC_QUOTES> PACLoop;
        public List<Loop_ALC_QUOTES> ALCLoop;
        public List<Loop_TDT_QUOTES> TDTLoop;
        public List<Loop_SCC_QUOTES> SCCLoop;
    }
    public class Loop_LOC_QUOTES
    {
        public LOC_9 LOC;
        public QTY_8 QTY;
        public List<DTM_6> DTM;
    }
    public class Loop_MOA_QUOTES
    {
        public MOA_15 MOA;
    }
    public class Loop_MOA_QUOTES_2
    {
        public MOA_15 MOA;
        public RNG_4 RNG;
    }
    public class Loop_NAD_QUOTES
    {
        public NAD_38 NAD;
        public List<Loop_RFF_QUOTES_2> RFFLoop;
        public List<Loop_CTA_QUOTES> CTALoop;
    }
    public class Loop_PAC_QUOTES
    {
        public PAC_10 PAC;
        public List<QTY_8> QTY;
    }
    public class Loop_PAT_QUOTES
    {
        public PAT_2 PAT;
        public List<DTM_6> DTM;
    }
    public class Loop_PCD_QUOTES
    {
        public PCD PCD;
        public RNG_4 RNG;
    }
    public class Loop_PRI_QUOTES
    {
        public PRI_10 PRI;
        public RNG_4 RNG;
        public List<CUX> CUX;
        public List<DTM_6> DTM;
    }
    public class Loop_QTY_QUOTES
    {
        public QTY_8 QTY;
        public RNG_4 RNG;
    }
    public class Loop_QTY_QUOTES_2
    {
        public QTY_8 QTY;
        public List<DTM_6> DTM;
    }
    public class Loop_RCS_QUOTES
    {
        public RCS_2 RCS;
        public List<DTM_6> DTM;
    }
    public class Loop_RFF_QUOTES
    {
        public RFF_33 RFF;
        public List<DTM_6> DTM;
    }
    public class Loop_RFF_QUOTES_2
    {
        public RFF_33 RFF;
    }
    public class Loop_RTE_QUOTES
    {
        public RTE RTE;
        public RNG_4 RNG;
    }
    public class Loop_SCC_QUOTES
    {
        public SCC_3 SCC;
        public List<Loop_QTY_QUOTES_2> QTYLoop;
    }
    public class Loop_TAX_QUOTES
    {
        public TAX_6 TAX;
    }
    public class Loop_TAX_QUOTES_2
    {
        public TAX_6 TAX;
        public MOA_15 MOA;
    }
    public class Loop_TDT_QUOTES
    {
        public TDT_8 TDT;
    }
    public class Loop_TOD_QUOTES
    {
        public TOD_9 TOD;
        public List<LOC_9> LOC;
    }
    public class TSQUOTES 
    {
        public UNH UNH;
        public BGM_37 BGM;
        public List<DTM_6> DTM;
        public List<ALI> ALI;
        public List<FTX_19> FTX;
        public List<Loop_RFF_QUOTES> RFFLoop;
        public List<Loop_CUX_QUOTES> CUXLoop;
        public List<Loop_PAT_QUOTES> PATLoop;
        public List<Loop_TOD_QUOTES> TODLoop;
        public List<Loop_RCS_QUOTES> RCSLoop;
        public List<Loop_NAD_QUOTES> NADLoop;
        public List<Loop_TDT_QUOTES> TDTLoop;
        public List<Loop_LIN_QUOTES> LINLoop;
        public UNS UNS;
        public List<MOA_15> MOA;
        public List<CNT_8> CNT;
        public UNT UNT;
    }
}
