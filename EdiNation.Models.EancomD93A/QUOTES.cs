namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_ALC_QUOTES
    {
        public ALC_5 ALC;
        public List<ALI_3> ALI;
        public List<DTM_2> DTM;
        public Loop_QTY_QUOTES_2 QTYLoop;
        public Loop_PCD_QUOTES PCDLoop;
        public Loop_MOA_QUOTES MOALoop;
        public Loop_RTE_QUOTES RTELoop;
        public List<Loop_TAX_QUOTES_2> TAXLoop;
    }
    public class Loop_ALC_QUOTES_2
    {
        public ALC_5 ALC;
        public List<ALI_3> ALI;
        public List<Loop_QTY_QUOTES_3> QTYLoop;
        public List<Loop_PCD_QUOTES_2> PCDLoop;
        public List<Loop_MOA_QUOTES_3> MOALoop;
        public List<Loop_RTE_QUOTES_2> RTELoop;
        public List<Loop_TAX_QUOTES_4> TAXLoop;
    }
    public class Loop_ALC_QUOTES_3
    {
        public ALC_5 ALC;
        public MOA_2 MOA;
        public ALI_3 ALI;
    }
    public class Loop_API_QUOTES
    {
        public API_4 API;
        public PRI_4 PRI;
        public List<QTY> QTY;
        public DTM_2 DTM;
        public List<MOA_2> MOA;
        public List<RNG_6> RNG;
    }
    public class Loop_CTA_QUOTES
    {
        public CTA_5 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_QUOTES
    {
        public CUX_12 CUX;
        public List<PCD_3> PCD;
        public List<DTM_2> DTM;
    }
    public class Loop_DLM_QUOTES
    {
        public DLM_2 DLM;
        public MOA_2 MOA;
        public DTM_2 DTM;
    }
    public class Loop_DOC_QUOTES
    {
        public DOC_4 DOC;
        public DTM_2 DTM;
    }
    public class Loop_DOC_QUOTES_2
    {
        public DOC_4 DOC;
        public List<DTM_2> DTM;
    }
    public class Loop_EQD_QUOTES
    {
        public EQD EQD;
        public List<HAN> HAN;
        public List<MEA_8> MEA;
        public List<FTX_3> FTX;
    }
    public class Loop_LIN_QUOTES
    {
        public LIN LIN;
        public List<PIA_12> PIA;
        public List<IMD_4> IMD;
        public List<MEA_12> MEA;
        public List<QTY_2> QTY;
        public PCD_3 PCD;
        public List<ALI_6> ALI;
        public List<DTM_2> DTM;
        public List<GIN_2> GIN;
        public List<GIR_2> GIR;
        public QVA_7 QVA;
        public List<FTX_20> FTX;
        public List<Loop_MOA_QUOTES_2> MOALoop;
        public List<Loop_PRI_QUOTES> PRILoop;
        public List<Loop_RFF_QUOTES> RFFLoop;
        public List<Loop_LOC_QUOTES_2> LOCLoop;
        public List<Loop_TAX_QUOTES_3> TAXLoop;
        public List<Loop_TOD_QUOTES_2> TODLoop;
        public List<Loop_EQD_QUOTES> EQDLoop;
        public List<Loop_RCS_QUOTES> RCSLoop;
        public List<Loop_PAT_QUOTES> PATLoop;
        public List<Loop_PAC_QUOTES_2> PACLoop;
        public List<Loop_NAD_QUOTES_2> NADLoop;
        public List<Loop_ALC_QUOTES_2> ALCLoop;
        public List<Loop_TDT_QUOTES_2> TDTLoop;
        public List<Loop_SCC_QUOTES_2> SCCLoop;
    }
    public class Loop_LOC_QUOTES
    {
        public LOC_6 LOC;
        public DTM_2 DTM;
    }
    public class Loop_LOC_QUOTES_2
    {
        public LOC_6 LOC;
        public QTY QTY;
        public List<DTM_2> DTM;
    }
    public class Loop_LOC_QUOTES_3
    {
        public LOC_6 LOC;
        public List<DTM_2> DTM;
    }
    public class Loop_MOA_QUOTES
    {
        public MOA_2 MOA;
        public RNG_6 RNG;
    }
    public class Loop_MOA_QUOTES_2
    {
        public MOA_2 MOA;
        public QTY QTY;
        public IMD_6 IMD;
        public CUX_5 CUX;
        public List<DTM_2> DTM;
    }
    public class Loop_MOA_QUOTES_3
    {
        public MOA_2 MOA;
        public RNG_3 RNG;
    }
    public class Loop_NAD_QUOTES
    {
        public NAD_23 NAD;
        public List<LOC_6> LOC;
        public List<FII_6> FII;
        public List<Loop_RFF_QUOTES_2> RFFLoop;
        public List<Loop_DOC_QUOTES> DOCLoop;
        public List<Loop_CTA_QUOTES> CTALoop;
    }
    public class Loop_NAD_QUOTES_2
    {
        public NAD_16 NAD;
        public List<LOC_6> LOC;
        public List<Loop_RFF_QUOTES> RFFLoop;
        public List<Loop_DOC_QUOTES_2> DOCLoop;
        public List<Loop_CTA_QUOTES> CTALoop;
    }
    public class Loop_PAC_QUOTES
    {
        public PAC_17 PAC;
        public List<MEA_8> MEA;
        public List<Loop_PCI_QUOTES> PCILoop;
    }
    public class Loop_PAC_QUOTES_2
    {
        public PAC_7 PAC;
        public List<MEA_8> MEA;
        public List<DTM_2> DTM;
        public List<QTY> QTY;
        public List<Loop_PCI_QUOTES_2> PCILoop;
    }
    public class Loop_PAT_QUOTES
    {
        public PAT PAT;
        public List<DTM_2> DTM;
        public PCD_3 PCD;
        public MOA_2 MOA;
    }
    public class Loop_PCD_QUOTES
    {
        public PCD_3 PCD;
        public RNG_6 RNG;
    }
    public class Loop_PCD_QUOTES_2
    {
        public PCD_3 PCD;
        public RNG_3 RNG;
    }
    public class Loop_PCI_QUOTES
    {
        public PCI_2 PCI;
        public RFF_7 RFF;
        public DTM_2 DTM;
        public List<GIN_2> GIN;
    }
    public class Loop_PCI_QUOTES_2
    {
        public PCI_2 PCI;
        public RFF_7 RFF;
        public List<DTM_2> DTM;
        public List<GIN_2> GIN;
    }
    public class Loop_PRI_QUOTES
    {
        public PRI PRI;
        public API_4 API;
        public RNG_6 RNG;
        public List<CUX_5> CUX;
        public List<DTM_2> DTM;
    }
    public class Loop_QTY_QUOTES
    {
        public QTY QTY;
        public List<DTM_2> DTM;
    }
    public class Loop_QTY_QUOTES_2
    {
        public QTY QTY;
        public RNG_6 RNG;
    }
    public class Loop_QTY_QUOTES_3
    {
        public QTY_2 QTY;
        public RNG_3 RNG;
    }
    public class Loop_QTY_QUOTES_4
    {
        public QTY_2 QTY;
        public List<DTM_2> DTM;
    }
    public class Loop_RCS_QUOTES
    {
        public RCS RCS;
        public List<RFF_7> RFF;
        public List<DTM_2> DTM;
        public List<FTX_3> FTX;
    }
    public class Loop_RFF_QUOTES
    {
        public RFF_7 RFF;
        public List<DTM_2> DTM;
    }
    public class Loop_RFF_QUOTES_2
    {
        public RFF_7 RFF;
        public List<DTM_2> DTM;
    }
    public class Loop_RTE_QUOTES
    {
        public RTE_3 RTE;
        public RNG_6 RNG;
    }
    public class Loop_RTE_QUOTES_2
    {
        public RTE_2 RTE;
        public RNG_3 RNG;
    }
    public class Loop_SCC_QUOTES
    {
        public SCC_3 SCC;
        public List<FTX_3> FTX;
        public List<Loop_QTY_QUOTES> QTYLoop;
    }
    public class Loop_SCC_QUOTES_2
    {
        public SCC_3 SCC;
        public List<FTX_3> FTX;
        public List<Loop_QTY_QUOTES_4> QTYLoop;
    }
    public class Loop_TAX_QUOTES
    {
        public TAX_4 TAX;
        public MOA_2 MOA;
        public List<LOC_6> LOC;
    }
    public class Loop_TAX_QUOTES_2
    {
        public TAX_4 TAX;
        public MOA_2 MOA;
    }
    public class Loop_TAX_QUOTES_3
    {
        public TAX_7 TAX;
        public MOA_2 MOA;
        public List<LOC_6> LOC;
    }
    public class Loop_TAX_QUOTES_4
    {
        public TAX_7 TAX;
        public MOA_2 MOA;
    }
    public class Loop_TDT_QUOTES
    {
        public TDT_10 TDT;
        public List<QTY> QTY;
        public List<Loop_LOC_QUOTES> LOCLoop;
    }
    public class Loop_TDT_QUOTES_2
    {
        public TDT_6 TDT;
        public List<QTY> QTY;
        public List<Loop_LOC_QUOTES_3> LOCLoop;
    }
    public class Loop_TOD_QUOTES
    {
        public TOD_9 TOD;
        public List<LOC_6> LOC;
    }
    public class Loop_TOD_QUOTES_2
    {
        public TOD_4 TOD;
        public List<LOC_6> LOC;
    }
    public class TSQUOTES 
    {
        public UNH UNH;
        public BGM_20 BGM;
        public List<DTM_2> DTM;
        public PAI PAI;
        public List<ALI_3> ALI;
        public IMD_6 IMD;
        public List<FTX_20> FTX;
        public List<Loop_RFF_QUOTES> RFFLoop;
        public List<Loop_TAX_QUOTES> TAXLoop;
        public List<Loop_CUX_QUOTES> CUXLoop;
        public List<Loop_PAT_QUOTES> PATLoop;
        public List<Loop_TOD_QUOTES> TODLoop;
        public List<Loop_EQD_QUOTES> EQDLoop;
        public List<Loop_RCS_QUOTES> RCSLoop;
        public List<Loop_API_QUOTES> APILoop;
        public Loop_DLM_QUOTES DLMLoop;
        public List<Loop_NAD_QUOTES> NADLoop;
        public List<Loop_TDT_QUOTES> TDTLoop;
        public List<Loop_PAC_QUOTES> PACLoop;
        public List<Loop_SCC_QUOTES> SCCLoop;
        public List<Loop_ALC_QUOTES> ALCLoop;
        public List<Loop_LIN_QUOTES> LINLoop;
        public UNS UNS;
        public List<MOA_2> MOA;
        public List<CNT_2> CNT;
        public List<Loop_ALC_QUOTES_3> ALCLoop2;
        public UNT UNT;
    }
}
