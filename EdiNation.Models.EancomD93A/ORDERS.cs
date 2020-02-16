namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_ALC_ORDERS
    {
        public ALC_2 ALC;
        public List<ALI_2> ALI;
        public List<DTM> DTM;
        public Loop_QTY_ORDERS_2 QTYLoop;
        public Loop_PCD_ORDERS PCDLoop;
        public List<Loop_MOA_ORDERS> MOALoop;
        public Loop_RTE_ORDERS RTELoop;
        public List<Loop_TAX_ORDERS_2> TAXLoop;
    }
    public class Loop_ALC_ORDERS_2
    {
        public ALC_2 ALC;
        public List<ALI_7> ALI;
        public List<DTM> DTM;
        public Loop_QTY_ORDERS_3 QTYLoop;
        public Loop_PCD_ORDERS_2 PCDLoop;
        public List<Loop_MOA_ORDERS_2> MOALoop;
        public Loop_RTE_ORDERS_2 RTELoop;
        public List<Loop_TAX_ORDERS_3> TAXLoop;
    }
    public class Loop_ALC_ORDERS_3
    {
        public ALC_2 ALC;
        public ALI_2 ALI;
        public List<MOA_5> MOA;
    }
    public class Loop_API_ORDERS
    {
        public API_2 API;
        public List<DTM> DTM;
        public RNG RNG;
    }
    public class Loop_CTA_ORDERS
    {
        public CTA_5 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_ORDERS
    {
        public CUX_8 CUX;
        public List<PCD_2> PCD;
        public List<DTM> DTM;
    }
    public class Loop_DOC_ORDERS
    {
        public DOC_6 DOC;
        public List<DTM> DTM;
    }
    public class Loop_EQD_ORDERS
    {
        public EQD EQD;
        public List<HAN> HAN;
        public List<MEA_4> MEA;
        public List<FTX> FTX;
    }
    public class Loop_LIN_ORDERS
    {
        public LIN LIN;
        public List<PIA> PIA;
        public List<IMD_3> IMD;
        public List<MEA_11> MEA;
        public List<QTY_18> QTY;
        public List<PCD_2> PCD;
        public List<ALI_2> ALI;
        public List<DTM> DTM;
        public List<MOA_5> MOA;
        public List<GIN_2> GIN;
        public List<GIR_2> GIR;
        public QVA_5 QVA;
        public DOC_6 DOC;
        public PAI PAI;
        public List<FTX_18> FTX;
        public List<Loop_PAT_ORDERS> PATLoop;
        public List<Loop_PRI_ORDERS> PRILoop;
        public List<Loop_RFF_ORDERS> RFFLoop;
        public List<Loop_PAC_ORDERS_2> PACLoop;
        public List<Loop_LOC_ORDERS_2> LOCLoop;
        public List<Loop_TAX_ORDERS> TAXLoop;
        public List<Loop_NAD_ORDERS_2> NADLoop;
        public List<Loop_ALC_ORDERS_2> ALCLoop;
        public List<Loop_TDT_ORDERS> TDTLoop;
        public List<Loop_TOD_ORDERS> TODLoop;
        public List<Loop_EQD_ORDERS> EQDLoop;
        public List<Loop_SCC_ORDERS> SCCLoop;
        public List<Loop_RCS_ORDERS> RCSLoop;
    }
    public class Loop_LOC_ORDERS
    {
        public LOC_5 LOC;
        public List<DTM> DTM;
    }
    public class Loop_LOC_ORDERS_2
    {
        public LOC_5 LOC;
        public QTY_18 QTY;
        public List<DTM> DTM;
    }
    public class Loop_MOA_ORDERS
    {
        public MOA_5 MOA;
        public RNG RNG;
    }
    public class Loop_MOA_ORDERS_2
    {
        public MOA_16 MOA;
        public RNG_2 RNG;
    }
    public class Loop_NAD_ORDERS
    {
        public NAD_12 NAD;
        public List<LOC_5> LOC;
        public List<FII_5> FII;
        public List<Loop_RFF_ORDERS> RFFLoop;
        public List<Loop_DOC_ORDERS> DOCLoop;
        public List<Loop_CTA_ORDERS> CTALoop;
    }
    public class Loop_NAD_ORDERS_2
    {
        public NAD_12 NAD;
        public List<LOC_5> LOC;
        public List<Loop_RFF_ORDERS> RFFLoop;
        public List<Loop_DOC_ORDERS> DOCLoop;
        public List<Loop_CTA_ORDERS> CTALoop;
    }
    public class Loop_PAC_ORDERS
    {
        public PAC_14 PAC;
        public List<MEA_4> MEA;
        public List<Loop_PCI_ORDERS> PCILoop;
    }
    public class Loop_PAC_ORDERS_2
    {
        public PAC_5 PAC;
        public List<MEA_4> MEA;
        public List<QTY_14> QTY;
        public List<DTM> DTM;
        public Loop_RFF_ORDERS RFFLoop;
        public List<Loop_PCI_ORDERS> PCILoop;
    }
    public class Loop_PAT_ORDERS
    {
        public PAT PAT;
        public List<DTM> DTM;
        public PCD_2 PCD;
        public MOA_5 MOA;
    }
    public class Loop_PCD_ORDERS
    {
        public PCD_2 PCD;
        public RNG RNG;
    }
    public class Loop_PCD_ORDERS_2
    {
        public PCD_2 PCD;
        public RNG_2 RNG;
    }
    public class Loop_PCI_ORDERS
    {
        public PCI_4 PCI;
        public RFF_3 RFF;
        public List<DTM> DTM;
        public List<GIN_2> GIN;
    }
    public class Loop_PRI_ORDERS
    {
        public PRI_10 PRI;
        public CUX_8 CUX;
        public API_2 API;
        public RNG RNG;
        public List<DTM> DTM;
    }
    public class Loop_QTY_ORDERS
    {
        public QTY_14 QTY;
        public List<DTM> DTM;
    }
    public class Loop_QTY_ORDERS_2
    {
        public QTY_14 QTY;
        public RNG RNG;
    }
    public class Loop_QTY_ORDERS_3
    {
        public QTY_18 QTY;
        public RNG_2 RNG;
    }
    public class Loop_RCS_ORDERS
    {
        public RCS RCS;
        public List<RFF_3> RFF;
        public List<DTM> DTM;
        public List<FTX> FTX;
    }
    public class Loop_RFF_ORDERS
    {
        public RFF_3 RFF;
        public List<DTM> DTM;
    }
    public class Loop_RTE_ORDERS
    {
        public RTE_3 RTE;
        public RNG RNG;
    }
    public class Loop_RTE_ORDERS_2
    {
        public RTE_2 RTE;
        public RNG_2 RNG;
    }
    public class Loop_SCC_ORDERS
    {
        public SCC_2 SCC;
        public List<FTX> FTX;
        public List<RFF_3> RFF;
        public List<Loop_QTY_ORDERS> QTYLoop;
    }
    public class Loop_TAX_ORDERS
    {
        public TAX_6 TAX;
        public MOA_5 MOA;
        public List<LOC_5> LOC;
    }
    public class Loop_TAX_ORDERS_2
    {
        public TAX_2 TAX;
        public MOA_5 MOA;
    }
    public class Loop_TAX_ORDERS_3
    {
        public TAX_6 TAX;
        public MOA_5 MOA;
    }
    public class Loop_TDT_ORDERS
    {
        public TDT_3 TDT;
        public List<Loop_LOC_ORDERS> LOCLoop;
    }
    public class Loop_TOD_ORDERS
    {
        public TOD_3 TOD;
        public List<LOC_5> LOC;
    }
    public class TSORDERS 
    {
        public UNH UNH;
        public BGM_12 BGM;
        public List<DTM> DTM;
        public PAI PAI;
        public List<ALI_2> ALI;
        public IMD_16 IMD;
        public List<FTX_18> FTX;
        public List<Loop_RFF_ORDERS> RFFLoop;
        public List<Loop_NAD_ORDERS> NADLoop;
        public List<Loop_TAX_ORDERS> TAXLoop;
        public List<Loop_CUX_ORDERS> CUXLoop;
        public List<Loop_PAT_ORDERS> PATLoop;
        public List<Loop_TDT_ORDERS> TDTLoop;
        public List<Loop_TOD_ORDERS> TODLoop;
        public List<Loop_PAC_ORDERS> PACLoop;
        public List<Loop_EQD_ORDERS> EQDLoop;
        public List<Loop_SCC_ORDERS> SCCLoop;
        public List<Loop_API_ORDERS> APILoop;
        public List<Loop_ALC_ORDERS> ALCLoop;
        public List<Loop_RCS_ORDERS> RCSLoop;
        public List<Loop_LIN_ORDERS> LINLoop;
        public UNS UNS;
        public List<MOA_5> MOA;
        public List<CNT_2> CNT;
        public List<Loop_ALC_ORDERS_3> ALCLoop2;
        public UNT UNT;
    }
}
