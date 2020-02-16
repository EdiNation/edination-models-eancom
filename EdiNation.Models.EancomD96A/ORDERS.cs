namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_ALC_ORDERS
    {
        public ALC_4 ALC;
        public List<ALI> ALI;
        public List<DTM_2> DTM;
        public Loop_QTY_ORDERS QTYLoop;
        public Loop_PCD_ORDERS PCDLoop;
        public List<Loop_MOA_ORDERS> MOALoop;
        public Loop_RTE_ORDERS RTELoop;
        public List<Loop_TAX_ORDERS> TAXLoop;
    }
    public class Loop_ALC_ORDERS_2
    {
        public ALC_4 ALC;
        public List<ALI> ALI;
        public List<DTM_2> DTM;
        public Loop_QTY_ORDERS QTYLoop;
        public Loop_PCD_ORDERS PCDLoop;
        public List<Loop_MOA_ORDERS> MOALoop;
        public Loop_RTE_ORDERS RTELoop;
        public List<Loop_TAX_ORDERS> TAXLoop;
    }
    public class Loop_CTA_ORDERS
    {
        public CTA_5 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_ORDERS
    {
        public CUX_3 CUX;
        public List<DTM_2> DTM;
    }
    public class Loop_LIN_ORDERS
    {
        public LIN_6 LIN;
        public List<PIA> PIA;
        public List<IMD_10> IMD;
        public List<MEA_12> MEA;
        public List<QTY_5> QTY;
        public List<DTM_2> DTM;
        public List<MOA_13> MOA;
        public List<GIN_4> GIN;
        public QVR_4 QVR;
        public List<FTX_14> FTX;
        public List<Loop_PRI_ORDERS> PRILoop;
        public List<Loop_RFF_ORDERS> RFFLoop;
        public List<Loop_PAC_ORDERS> PACLoop;
        public List<Loop_LOC_ORDERS_2> LOCLoop;
        public List<Loop_TAX_ORDERS> TAXLoop;
        public List<Loop_NAD_ORDERS_2> NADLoop;
        public List<Loop_ALC_ORDERS_2> ALCLoop;
        public List<Loop_TDT_ORDERS_2> TDTLoop;
    }
    public class Loop_LOC_ORDERS
    {
        public LOC_7 LOC;
    }
    public class Loop_LOC_ORDERS_2
    {
        public LOC_7 LOC;
        public QTY_5 QTY;
        public List<DTM_2> DTM;
    }
    public class Loop_MOA_ORDERS
    {
        public MOA_13 MOA;
        public RNG_3 RNG;
    }
    public class Loop_NAD_ORDERS
    {
        public NAD_18 NAD;
        public List<LOC_7> LOC;
        public List<Loop_RFF_ORDERS_2> RFFLoop;
        public List<Loop_CTA_ORDERS> CTALoop;
    }
    public class Loop_NAD_ORDERS_2
    {
        public NAD_18 NAD;
        public List<Loop_CTA_ORDERS> CTALoop;
    }
    public class Loop_PAC_ORDERS
    {
        public PAC_9 PAC;
        public List<Loop_PCI_ORDERS> PCILoop;
    }
    public class Loop_PAT_ORDERS
    {
        public PAT_6 PAT;
        public List<DTM_2> DTM;
        public PCD_5 PCD;
        public MOA_13 MOA;
    }
    public class Loop_PCD_ORDERS
    {
        public PCD_5 PCD;
        public RNG_3 RNG;
    }
    public class Loop_PCI_ORDERS
    {
        public PCI_10 PCI;
        public RFF_26 RFF;
        public List<DTM_2> DTM;
        public List<GIN_4> GIN;
    }
    public class Loop_PRI_ORDERS
    {
        public PRI_10 PRI;
        public CUX_3 CUX;
    }
    public class Loop_QTY_ORDERS
    {
        public QTY_5 QTY;
        public RNG_3 RNG;
    }
    public class Loop_RFF_ORDERS
    {
        public RFF_26 RFF;
        public List<DTM_2> DTM;
    }
    public class Loop_RFF_ORDERS_2
    {
        public RFF_26 RFF;
    }
    public class Loop_RTE_ORDERS
    {
        public RTE RTE;
        public RNG_3 RNG;
    }
    public class Loop_TAX_ORDERS
    {
        public TAX_4 TAX;
        public MOA_13 MOA;
    }
    public class Loop_TDT_ORDERS
    {
        public TDT_3 TDT;
        public List<Loop_LOC_ORDERS> LOCLoop;
    }
    public class Loop_TDT_ORDERS_2
    {
        public TDT_3 TDT;
    }
    public class Loop_TOD_ORDERS
    {
        public TOD_8 TOD;
        public List<LOC_7> LOC;
    }
    public class TSORDERS 
    {
        public UNH UNH;
        public BGM_25 BGM;
        public List<DTM_2> DTM;
        public PAI_8 PAI;
        public List<ALI> ALI;
        public List<FTX_14> FTX;
        public List<Loop_RFF_ORDERS> RFFLoop;
        public List<Loop_NAD_ORDERS> NADLoop;
        public List<Loop_TAX_ORDERS> TAXLoop;
        public List<Loop_CUX_ORDERS> CUXLoop;
        public List<Loop_PAT_ORDERS> PATLoop;
        public List<Loop_TDT_ORDERS> TDTLoop;
        public List<Loop_TOD_ORDERS> TODLoop;
        public List<Loop_ALC_ORDERS> ALCLoop;
        public List<Loop_LIN_ORDERS> LINLoop;
        public UNS UNS;
        public List<MOA_13> MOA;
        public List<CNT_11> CNT;
        public UNT UNT;
    }
}
