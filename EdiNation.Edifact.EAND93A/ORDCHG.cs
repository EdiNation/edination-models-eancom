namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_ALC_ORDCHG
    {
        public ALC_2 ALC;
        public List<ALI> ALI;
        public List<DTM> DTM;
        public Loop_QTY_ORDCHG_2 QTYLoop;
        public Loop_PCD_ORDCHG PCDLoop;
        public List<Loop_MOA_ORDCHG> MOALoop;
        public Loop_RTE_ORDCHG RTELoop;
        public List<Loop_TAX_ORDCHG_2> TAXLoop;
    }
    public class Loop_ALC_ORDCHG_2
    {
        public ALC_2 ALC;
        public List<ALI_5> ALI;
        public List<DTM> DTM;
        public Loop_QTY_ORDCHG_3 QTYLoop;
        public Loop_PCD_ORDCHG_2 PCDLoop;
        public List<Loop_MOA_ORDCHG_2> MOALoop;
        public Loop_RTE_ORDCHG_2 RTELoop;
        public List<Loop_TAX_ORDCHG_3> TAXLoop;
    }
    public class Loop_ALC_ORDCHG_3
    {
        public ALC_2 ALC;
        public ALI ALI;
        public List<MOA_4> MOA;
    }
    public class Loop_API_ORDCHG
    {
        public API API;
        public List<DTM> DTM;
        public RNG RNG;
    }
    public class Loop_CTA_ORDCHG
    {
        public CTA_5 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_ORDCHG
    {
        public CUX_7 CUX;
        public List<PCD> PCD;
        public List<DTM> DTM;
    }
    public class Loop_DOC_ORDCHG
    {
        public DOC_5 DOC;
        public List<DTM> DTM;
    }
    public class Loop_EQD_ORDCHG
    {
        public EQD EQD;
        public List<HAN> HAN;
        public List<MEA_3> MEA;
        public List<FTX> FTX;
    }
    public class Loop_LIN_ORDCHG
    {
        public LIN_4 LIN;
        public List<PIA_9> PIA;
        public List<IMD_2> IMD;
        public List<MEA_10> MEA;
        public List<QTY_17> QTY;
        public List<PCD> PCD;
        public List<ALI> ALI;
        public List<DTM> DTM;
        public List<MOA_4> MOA;
        public List<GIN_2> GIN;
        public List<GIR_2> GIR;
        public QVA_4 QVA;
        public List<DOC_5> DOC;
        public PAI PAI;
        public List<FTX_18> FTX;
        public List<Loop_PAT_ORDCHG> PATLoop;
        public List<Loop_PRI_ORDCHG> PRILoop;
        public List<Loop_RFF_ORDCHG> RFFLoop;
        public List<Loop_PAC_ORDCHG_2> PACLoop;
        public List<Loop_LOC_ORDCHG_2> LOCLoop;
        public List<Loop_TAX_ORDCHG> TAXLoop;
        public List<Loop_NAD_ORDCHG_2> NADLoop;
        public List<Loop_ALC_ORDCHG_2> ALCLoop;
        public List<Loop_TDT_ORDCHG> TDTLoop;
        public List<Loop_TOD_ORDCHG_2> TODLoop;
        public List<Loop_EQD_ORDCHG> EQDLoop;
        public List<Loop_SCC_ORDCHG> SCCLoop;
        public List<Loop_RCS_ORDCHG> RCSLoop;
    }
    public class Loop_LOC_ORDCHG
    {
        public LOC_5 LOC;
        public List<DTM> DTM;
    }
    public class Loop_LOC_ORDCHG_2
    {
        public LOC_5 LOC;
        public QTY_17 QTY;
        public List<DTM> DTM;
    }
    public class Loop_MOA_ORDCHG
    {
        public MOA_4 MOA;
        public RNG RNG;
    }
    public class Loop_MOA_ORDCHG_2
    {
        public MOA_15 MOA;
        public RNG_2 RNG;
    }
    public class Loop_NAD_ORDCHG
    {
        public NAD_11 NAD;
        public List<LOC_5> LOC;
        public List<FII_4> FII;
        public List<Loop_RFF_ORDCHG> RFFLoop;
        public List<Loop_DOC_ORDCHG> DOCLoop;
        public List<Loop_CTA_ORDCHG> CTALoop;
    }
    public class Loop_NAD_ORDCHG_2
    {
        public NAD_11 NAD;
        public List<LOC_5> LOC;
        public List<Loop_RFF_ORDCHG> RFFLoop;
        public List<Loop_DOC_ORDCHG> DOCLoop;
        public List<Loop_CTA_ORDCHG> CTALoop;
    }
    public class Loop_PAC_ORDCHG
    {
        public PAC_13 PAC;
        public List<MEA_3> MEA;
        public List<Loop_PCI_ORDCHG> PCILoop;
    }
    public class Loop_PAC_ORDCHG_2
    {
        public PAC_4 PAC;
        public List<MEA_3> MEA;
        public List<QTY_13> QTY;
        public List<DTM> DTM;
        public Loop_RFF_ORDCHG RFFLoop;
        public List<Loop_PCI_ORDCHG> PCILoop;
    }
    public class Loop_PAT_ORDCHG
    {
        public PAT PAT;
        public List<DTM> DTM;
        public PCD PCD;
        public MOA_4 MOA;
    }
    public class Loop_PCD_ORDCHG
    {
        public PCD PCD;
        public RNG RNG;
    }
    public class Loop_PCD_ORDCHG_2
    {
        public PCD PCD;
        public RNG_2 RNG;
    }
    public class Loop_PCI_ORDCHG
    {
        public PCI_4 PCI;
        public RFF_2 RFF;
        public List<DTM> DTM;
        public List<GIN_2> GIN;
    }
    public class Loop_PRI_ORDCHG
    {
        public PRI_10 PRI;
        public CUX_7 CUX;
        public API API;
        public RNG RNG;
        public List<DTM> DTM;
    }
    public class Loop_QTY_ORDCHG
    {
        public QTY_13 QTY;
        public List<DTM> DTM;
    }
    public class Loop_QTY_ORDCHG_2
    {
        public QTY_13 QTY;
        public RNG RNG;
    }
    public class Loop_QTY_ORDCHG_3
    {
        public QTY_17 QTY;
        public RNG_2 RNG;
    }
    public class Loop_RCS_ORDCHG
    {
        public RCS_2 RCS;
        public List<RFF_2> RFF;
        public List<DTM> DTM;
        public List<FTX> FTX;
    }
    public class Loop_RFF_ORDCHG
    {
        public RFF_2 RFF;
        public List<DTM> DTM;
    }
    public class Loop_RTE_ORDCHG
    {
        public RTE_3 RTE;
        public RNG RNG;
    }
    public class Loop_RTE_ORDCHG_2
    {
        public RTE_2 RTE;
        public RNG_2 RNG;
    }
    public class Loop_SCC_ORDCHG
    {
        public SCC_2 SCC;
        public List<FTX> FTX;
        public List<RFF_2> RFF;
        public List<Loop_QTY_ORDCHG> QTYLoop;
    }
    public class Loop_TAX_ORDCHG
    {
        public TAX_6 TAX;
        public MOA_4 MOA;
        public List<LOC_5> LOC;
    }
    public class Loop_TAX_ORDCHG_2
    {
        public TAX_2 TAX;
        public MOA_4 MOA;
    }
    public class Loop_TAX_ORDCHG_3
    {
        public TAX_6 TAX;
        public MOA_4 MOA;
    }
    public class Loop_TDT_ORDCHG
    {
        public TDT_3 TDT;
        public List<Loop_LOC_ORDCHG> LOCLoop;
    }
    public class Loop_TOD_ORDCHG
    {
        public TOD_8 TOD;
        public List<LOC_5> LOC;
    }
    public class Loop_TOD_ORDCHG_2
    {
        public TOD_2 TOD;
        public List<LOC_5> LOC;
    }
    public class TSORDCHG 
    {
        public UNH UNH;
        public BGM_11 BGM;
        public List<DTM> DTM;
        public PAI PAI;
        public List<ALI> ALI;
        public IMD_15 IMD;
        public List<FTX_18> FTX;
        public List<Loop_RFF_ORDCHG> RFFLoop;
        public List<Loop_NAD_ORDCHG> NADLoop;
        public List<Loop_TAX_ORDCHG> TAXLoop;
        public List<Loop_CUX_ORDCHG> CUXLoop;
        public List<Loop_PAT_ORDCHG> PATLoop;
        public List<Loop_TDT_ORDCHG> TDTLoop;
        public List<Loop_TOD_ORDCHG> TODLoop;
        public List<Loop_PAC_ORDCHG> PACLoop;
        public List<Loop_EQD_ORDCHG> EQDLoop;
        public List<Loop_SCC_ORDCHG> SCCLoop;
        public List<Loop_API_ORDCHG> APILoop;
        public List<Loop_ALC_ORDCHG> ALCLoop;
        public List<Loop_RCS_ORDCHG> RCSLoop;
        public List<Loop_LIN_ORDCHG> LINLoop;
        public UNS UNS;
        public List<MOA_4> MOA;
        public List<CNT_2> CNT;
        public List<Loop_ALC_ORDCHG_3> ALCLoop2;
        public UNT UNT;
    }
}
