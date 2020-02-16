namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_ALC_PRICAT
    {
        public ALC_6 ALC;
        public List<ALI> ALI;
        public List<DTM_6> DTM;
        public Loop_QTY_PRICAT QTYLoop;
        public Loop_PCD_PRICAT PCDLoop;
        public List<Loop_MOA_PRICAT> MOALoop;
        public Loop_RTE_PRICAT RTELoop;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
    }
    public class Loop_ALC_PRICAT_2
    {
        public ALC_6 ALC;
        public List<ALI> ALI;
        public Loop_QTY_PRICAT QTYLoop;
        public Loop_PCD_PRICAT PCDLoop;
        public List<Loop_MOA_PRICAT> MOALoop;
        public Loop_RTE_PRICAT RTELoop;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
    }
    public class Loop_ALC_PRICAT_3
    {
        public ALC_6 ALC;
        public List<ALI> ALI;
        public List<DTM_6> DTM;
        public Loop_QTY_PRICAT QTYLoop;
        public Loop_PCD_PRICAT PCDLoop;
        public List<Loop_MOA_PRICAT> MOALoop;
        public Loop_RTE_PRICAT RTELoop;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
    }
    public class Loop_CTA_PRICAT
    {
        public CTA_8 CTA;
        public List<COM_2> COM;
    }
    public class Loop_CUX_PRICAT
    {
        public CUX_3 CUX;
        public List<DTM_6> DTM;
    }
    public class Loop_LIN_PRICAT
    {
        public LIN_10 LIN;
        public List<PIA_10> PIA;
        public List<IMD_13> IMD;
        public List<MEA_2> MEA;
        public List<QTY_9> QTY;
        public List<HAN_3> HAN;
        public List<ALI> ALI;
        public List<DTM_6> DTM;
        public RFF_28 RFF;
        public LOC_11 LOC;
        public List<FTX_20> FTX;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
        public List<Loop_PRI_PRICAT_2> PRILoop;
        public List<Loop_ALC_PRICAT_3> ALCLoop;
        public List<Loop_PAC_PRICAT_2> PACLoop;
        public List<Loop_PAT_PRICAT_2> PATLoop;
    }
    public class Loop_MOA_PRICAT
    {
        public MOA_17 MOA;
        public RNG RNG;
    }
    public class Loop_NAD_PRICAT
    {
        public NAD_23 NAD;
        public List<Loop_RFF_PRICAT_2> RFFLoop;
        public List<Loop_CTA_PRICAT> CTALoop;
    }
    public class Loop_NAD_PRICAT_2
    {
        public NAD_23 NAD;
        public List<LOC_11> LOC;
        public List<Loop_RFF_PRICAT> RFFLoop;
        public List<Loop_CTA_PRICAT> CTALoop;
    }
    public class Loop_PAC_PRICAT
    {
        public PAC_3 PAC;
        public List<MEA_2> MEA;
    }
    public class Loop_PAC_PRICAT_2
    {
        public PAC_3 PAC;
        public List<MEA_2> MEA;
        public List<HAN_3> HAN;
    }
    public class Loop_PAT_PRICAT
    {
        public PAT_2 PAT;
        public PCD_6 PCD;
    }
    public class Loop_PAT_PRICAT_2
    {
        public PAT_2 PAT;
        public List<DTM_6> DTM;
        public PCD_6 PCD;
        public MOA_17 MOA;
    }
    public class Loop_PCD_PRICAT
    {
        public PCD_6 PCD;
        public RNG RNG;
    }
    public class Loop_PGI_PRICAT
    {
        public PGI_3 PGI;
        public List<DTM_6> DTM;
        public List<QTY_9> QTY;
        public List<ALI> ALI;
        public List<FTX_20> FTX;
        public List<Loop_CUX_PRICAT> CUXLoop;
        public List<Loop_PRI_PRICAT> PRILoop;
        public List<Loop_TAX_PRICAT_2> TAXLoop;
        public List<Loop_ALC_PRICAT_2> ALCLoop;
        public List<Loop_NAD_PRICAT_2> NADLoop;
        public List<Loop_PAT_PRICAT> PATLoop;
        public List<Loop_TDT_PRICAT> TDTLoop;
        public List<Loop_TOD_PRICAT> TODLoop;
        public List<Loop_PAC_PRICAT> PACLoop;
        public List<Loop_LIN_PRICAT> LINLoop;
    }
    public class Loop_PRI_PRICAT
    {
        public PRI_2 PRI;
        public RNG RNG;
        public List<DTM_6> DTM;
    }
    public class Loop_PRI_PRICAT_2
    {
        public PRI_2 PRI;
        public CUX_3 CUX;
        public APR APR;
        public RNG RNG;
        public List<DTM_6> DTM;
    }
    public class Loop_QTY_PRICAT
    {
        public QTY_9 QTY;
        public RNG RNG;
    }
    public class Loop_RFF_PRICAT
    {
        public RFF_28 RFF;
        public List<DTM_6> DTM;
    }
    public class Loop_RFF_PRICAT_2
    {
        public RFF_28 RFF;
    }
    public class Loop_RTE_PRICAT
    {
        public RTE RTE;
        public RNG RNG;
    }
    public class Loop_TAX_PRICAT
    {
        public TAX_5 TAX;
    }
    public class Loop_TAX_PRICAT_2
    {
        public TAX_5 TAX;
        public MOA_17 MOA;
    }
    public class Loop_TDT_PRICAT
    {
        public TDT_5 TDT;
    }
    public class Loop_TOD_PRICAT
    {
        public TOD_2 TOD;
        public List<LOC_11> LOC;
    }
    public class TSPRICAT 
    {
        public UNH UNH;
        public BGM_32 BGM;
        public List<DTM_6> DTM;
        public List<FTX_20> FTX;
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
