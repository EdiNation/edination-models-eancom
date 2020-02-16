namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_ALC_REQOTE
    {
        public ALC_9 ALC;
        public Loop_QTY_REQOTE QTYLoop;
        public Loop_PCD_REQOTE PCDLoop;
        public List<Loop_MOA_REQOTE_2> MOALoop;
        public Loop_RTE_REQOTE RTELoop;
        public List<Loop_TAX_REQOTE_2> TAXLoop;
    }
    public class Loop_CTA_REQOTE
    {
        public CTA_6 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_REQOTE
    {
        public CUX_9 CUX;
        public List<DTM_39> DTM;
    }
    public class Loop_LIN_REQOTE
    {
        public LIN_6 LIN;
        public List<PIA_12> PIA;
        public List<IMD_3> IMD;
        public List<MEA_9> MEA;
        public List<QTY_10> QTY;
        public List<ALI_3> ALI;
        public List<DTM_39> DTM;
        public List<FTX_18> FTX;
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
        public RNG_2 RNG;
    }
    public class Loop_NAD_REQOTE
    {
        public NAD_39 NAD;
        public List<Loop_RFF_REQOTE_2> RFFLoop;
        public List<Loop_CTA_REQOTE> CTALoop;
    }
    public class Loop_PAC_REQOTE
    {
        public PAC_11 PAC;
    }
    public class Loop_PAT_REQOTE
    {
        public PAT_2 PAT;
        public List<DTM_39> DTM;
    }
    public class Loop_PCD_REQOTE
    {
        public PCD PCD;
        public RNG_2 RNG;
    }
    public class Loop_PRI_REQOTE
    {
        public PRI_13 PRI;
    }
    public class Loop_QTY_REQOTE
    {
        public QTY_10 QTY;
        public RNG_2 RNG;
    }
    public class Loop_QTY_REQOTE_2
    {
        public QTY_10 QTY;
        public List<DTM_39> DTM;
    }
    public class Loop_RFF_REQOTE
    {
        public RFF_33 RFF;
        public List<DTM_39> DTM;
    }
    public class Loop_RFF_REQOTE_2
    {
        public RFF_33 RFF;
    }
    public class Loop_RTE_REQOTE
    {
        public RTE RTE;
        public RNG_2 RNG;
    }
    public class Loop_SCC_REQOTE
    {
        public SCC_3 SCC;
        public List<Loop_QTY_REQOTE_2> QTYLoop;
    }
    public class Loop_TAX_REQOTE
    {
        public TAX_6 TAX;
    }
    public class Loop_TAX_REQOTE_2
    {
        public TAX_6 TAX;
        public MOA_10 MOA;
    }
    public class Loop_TDT_REQOTE
    {
        public TDT_7 TDT;
    }
    public class Loop_TOD_REQOTE
    {
        public TOD_9 TOD;
        public List<LOC_23> LOC;
    }
    public class TSREQOTE 
    {
        public UNH UNH;
        public BGM_39 BGM;
        public List<DTM_39> DTM;
        public List<FTX_18> FTX;
        public List<Loop_RFF_REQOTE> RFFLoop;
        public List<Loop_CUX_REQOTE> CUXLoop;
        public List<Loop_PAT_REQOTE> PATLoop;
        public List<Loop_TOD_REQOTE> TODLoop;
        public List<Loop_NAD_REQOTE> NADLoop;
        public List<Loop_TDT_REQOTE> TDTLoop;
        public List<Loop_LIN_REQOTE> LINLoop;
        public UNS UNS;
        public List<MOA_10> MOA;
        public List<CNT_4> CNT;
        public UNT UNT;
    }
}
