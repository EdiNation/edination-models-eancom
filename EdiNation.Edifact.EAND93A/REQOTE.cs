namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_ALC_REQOTE
    {
        public ALC_6 ALC;
        public Loop_QTY_REQOTE QTYLoop;
        public Loop_PCD_REQOTE PCDLoop;
        public Loop_MOA_REQOTE_2 MOALoop;
        public Loop_RTE_REQOTE RTELoop;
        public List<Loop_TAX_REQOTE_2> TAXLoop;
    }
    public class Loop_CTA_REQOTE
    {
        public CTA_5 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_REQOTE
    {
        public CUX_13 CUX;
        public List<DTM_19> DTM;
    }
    public class Loop_LIN_REQOTE
    {
        public LIN_8 LIN;
        public List<PIA_13> PIA;
        public List<IMD_11> IMD;
        public List<MEA_16> MEA;
        public List<QTY_11> QTY;
        public List<ALI_9> ALI;
        public List<DTM_19> DTM;
        public List<FTX_10> FTX;
        public List<Loop_MOA_REQOTE> MOALoop;
        public List<Loop_PRI_REQOTE> PRILoop;
        public List<Loop_RFF_REQOTE> RFFLoop;
        public List<Loop_TAX_REQOTE> TAXLoop;
        public List<Loop_PAC_REQOTE> PACLoop;
        public List<Loop_ALC_REQOTE> ALCLoop;
        public List<Loop_TDT_REQOTE> TDTLoop;
        public List<Loop_SCC_REQOTE> SCCLoop;
    }
    public class Loop_MOA_REQOTE
    {
        public MOA_10 MOA;
    }
    public class Loop_MOA_REQOTE_2
    {
        public MOA_10 MOA;
        public RNG_5 RNG;
    }
    public class Loop_NAD_REQOTE
    {
        public NAD_25 NAD;
        public List<Loop_RFF_REQOTE_2> RFFLoop;
        public List<Loop_CTA_REQOTE> CTALoop;
    }
    public class Loop_PAC_REQOTE
    {
        public PAC_19 PAC;
    }
    public class Loop_PAT_REQOTE
    {
        public PAT_3 PAT;
        public List<DTM_19> DTM;
    }
    public class Loop_PCD_REQOTE
    {
        public PCD_9 PCD;
        public RNG_5 RNG;
    }
    public class Loop_PRI_REQOTE
    {
        public PRI_13 PRI;
    }
    public class Loop_QTY_REQOTE
    {
        public QTY_11 QTY;
        public RNG_5 RNG;
    }
    public class Loop_QTY_REQOTE_2
    {
        public QTY_11 QTY;
        public List<DTM_19> DTM;
    }
    public class Loop_RFF_REQOTE
    {
        public RFF_7 RFF;
        public List<DTM_19> DTM;
    }
    public class Loop_RFF_REQOTE_2
    {
        public RFF_7 RFF;
    }
    public class Loop_RTE_REQOTE
    {
        public RTE_4 RTE;
        public RNG_5 RNG;
    }
    public class Loop_SCC_REQOTE
    {
        public SCC_5 SCC;
        public List<Loop_QTY_REQOTE_2> QTYLoop;
    }
    public class Loop_TAX_REQOTE
    {
        public TAX_5 TAX;
    }
    public class Loop_TAX_REQOTE_2
    {
        public TAX_5 TAX;
        public MOA_10 MOA;
    }
    public class Loop_TDT_REQOTE
    {
        public TDT_11 TDT;
    }
    public class Loop_TOD_REQOTE
    {
        public TOD_10 TOD;
        public List<LOC_14> LOC;
    }
    public class TSREQOTE 
    {
        public UNH UNH;
        public BGM_23 BGM;
        public List<DTM_19> DTM;
        public List<FTX_10> FTX;
        public List<Loop_RFF_REQOTE> RFFLoop;
        public List<Loop_CUX_REQOTE> CUXLoop;
        public List<Loop_PAT_REQOTE> PATLoop;
        public List<Loop_TOD_REQOTE> TODLoop;
        public List<Loop_NAD_REQOTE> NADLoop;
        public List<Loop_LIN_REQOTE> LINLoop;
        public UNS UNS;
        public List<MOA_10> MOA;
        public List<CNT_8> CNT;
        public UNT UNT;
    }
}
