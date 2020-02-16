namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_ALC_PRICAT
    {
        public ALC_4 ALC;
        public List<ALI_3> ALI;
        public Loop_QTY_PRICAT QTYLoop;
        public Loop_PCD_PRICAT PCDLoop;
        public List<Loop_MOA_PRICAT> MOALoop;
        public Loop_RTE_PRICAT RTELoop;
        public List<Loop_TAX_PRICAT> TAXLoop;
    }
    public class Loop_ALC_PRICAT_2
    {
        public ALC_4 ALC;
        public List<ALI_3> ALI;
        public Loop_QTY_PRICAT QTYLoop;
        public Loop_PCD_PRICAT PCDLoop;
        public List<Loop_MOA_PRICAT> MOALoop;
        public Loop_RTE_PRICAT RTELoop;
        public List<Loop_TAX_PRICAT> TAXLoop;
    }
    public class Loop_ALC_PRICAT_3
    {
        public ALC_4 ALC;
        public List<ALI_6> ALI;
        public Loop_QTY_PRICAT_2 QTYLoop;
        public Loop_PCD_PRICAT_2 PCDLoop;
        public List<Loop_MOA_PRICAT_2> MOALoop;
        public Loop_RTE_PRICAT_2 RTELoop;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
    }
    public class Loop_CTA_PRICAT
    {
        public CTA_7 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_PRICAT
    {
        public CUX_8 CUX;
        public List<DTM_4> DTM;
    }
    public class Loop_CUX_PRICAT_2
    {
        public CUX_2 CUX;
        public List<DTM_4> DTM;
    }
    public class Loop_MOA_PRICAT
    {
        public MOA_6 MOA;
        public RNG RNG;
    }
    public class Loop_MOA_PRICAT_2
    {
        public MOA MOA;
        public RNG_2 RNG;
    }
    public class Loop_NAD_PRICAT
    {
        public NAD_14 NAD;
        public List<LOC_6> LOC;
        public List<Loop_RFF_PRICAT> RFFLoop;
        public List<Loop_CTA_PRICAT> CTALoop;
    }
    public class Loop_NAD_PRICAT_2
    {
        public NAD_14 NAD;
        public List<LOC_6> LOC;
        public List<Loop_RFF_PRICAT> RFFLoop;
        public List<Loop_CTA_PRICAT> CTALoop;
    }
    public class Loop_PAC_PRICAT
    {
        public PAC_15 PAC;
        public List<MEA_19> MEA;
        public List<HAN> HAN;
    }
    public class Loop_PAC_PRICAT_2
    {
        public PAC_6 PAC;
        public List<MEA_9> MEA;
        public List<HAN_4> HAN;
    }
    public class Loop_PAT_PRICAT
    {
        public PAT PAT;
        public List<DTM_4> DTM;
        public PCD_5 PCD;
        public MOA_6 MOA;
    }
    public class Loop_PCD_PRICAT
    {
        public PCD_5 PCD;
        public RNG RNG;
    }
    public class Loop_PCD_PRICAT_2
    {
        public PCD_5 PCD;
        public RNG_2 RNG;
    }
    public class Loop_PGI_PRICAT
    {
        public PGI_3 PGI;
        public List<DTM_4> DTM;
        public List<QTY_10> QTY;
        public List<ALI_3> ALI;
        public List<FTX_11> FTX;
        public List<Loop_PRI_PRICAT> PRILoop;
        public List<Loop_TAX_PRICAT> TAXLoop;
        public List<Loop_ALC_PRICAT_2> ALCLoop;
        public List<Loop_NAD_PRICAT_2> NADLoop;
        public List<Loop_CUX_PRICAT_2> CUXLoop;
        public List<Loop_PAT_PRICAT> PATLoop;
        public List<Loop_TDT_PRICAT> TDTLoop;
        public List<Loop_TOD_PRICAT> TODLoop;
        public List<Loop_PAC_PRICAT> PACLoop;
        public List<Loop_PIT_PRICAT> PITLoop;
    }
    public class Loop_PIT_PRICAT
    {
        public PIT PIT;
        public List<PIA_11> PIA;
        public List<IMD_13> IMD;
        public List<MEA_9> MEA;
        public List<QTY_20> QTY;
        public List<HAN_4> HAN;
        public List<ALI_6> ALI;
        public List<DTM_4> DTM;
        public List<FTX_15> FTX;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
        public List<Loop_PRI_PRICAT_2> PRILoop;
        public List<Loop_ALC_PRICAT_3> ALCLoop;
        public List<Loop_CUX_PRICAT_2> CUXLoop;
        public List<Loop_PAC_PRICAT_2> PACLoop;
        public List<Loop_PAT_PRICAT> PATLoop;
        public List<Loop_TDT_PRICAT> TDTLoop;
        public List<Loop_TOD_PRICAT> TODLoop;
    }
    public class Loop_PRI_PRICAT
    {
        public PRI_11 PRI;
        public API_4 API;
        public RNG RNG;
        public List<DTM_4> DTM;
    }
    public class Loop_PRI_PRICAT_2
    {
        public PRI_2 PRI;
        public API_4 API;
        public RNG RNG;
        public List<DTM_4> DTM;
    }
    public class Loop_QTY_PRICAT
    {
        public QTY_10 QTY;
        public RNG RNG;
    }
    public class Loop_QTY_PRICAT_2
    {
        public QTY_20 QTY;
        public RNG_2 RNG;
    }
    public class Loop_RFF_PRICAT
    {
        public RFF_19 RFF;
        public List<DTM_4> DTM;
    }
    public class Loop_RTE_PRICAT
    {
        public RTE_3 RTE;
        public RNG RNG;
    }
    public class Loop_RTE_PRICAT_2
    {
        public RTE_2 RTE;
        public RNG_2 RNG;
    }
    public class Loop_TAX_PRICAT
    {
        public TAX_3 TAX;
        public MOA_6 MOA;
    }
    public class Loop_TAX_PRICAT_2
    {
        public TAX TAX;
        public MOA_6 MOA;
    }
    public class Loop_TDT_PRICAT
    {
        public TDT_5 TDT;
        public List<LOC_6> LOC;
    }
    public class Loop_TOD_PRICAT
    {
        public TOD TOD;
        public List<LOC_6> LOC;
    }
    public class TSPRICAT 
    {
        public UNH UNH;
        public BGM_17 BGM;
        public List<DTM_4> DTM;
        public List<ALI_3> ALI;
        public List<FTX_29> FTX;
        public List<Loop_RFF_PRICAT> RFFLoop;
        public List<Loop_NAD_PRICAT> NADLoop;
        public List<Loop_TAX_PRICAT> TAXLoop;
        public List<Loop_CUX_PRICAT> CUXLoop;
        public List<Loop_PAT_PRICAT> PATLoop;
        public List<Loop_TDT_PRICAT> TDTLoop;
        public List<Loop_TOD_PRICAT> TODLoop;
        public List<Loop_ALC_PRICAT> ALCLoop;
        public List<Loop_PGI_PRICAT> PGILoop;
        public UNT UNT;
    }
}
