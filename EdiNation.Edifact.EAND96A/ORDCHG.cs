namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_ALC_ORDCHG
    {
        public ALC_4 ALC;
        public List<ALI> ALI;
        public List<DTM> DTM;
        public Loop_QTY_ORDCHG QTYLoop;
        public Loop_PCD_ORDCHG PCDLoop;
        public List<Loop_MOA_ORDCHG> MOALoop;
        public Loop_RTE_ORDCHG RTELoop;
        public List<Loop_TAX_ORDCHG> TAXLoop;
    }
    public class Loop_ALC_ORDCHG_2
    {
        public ALC_4 ALC;
        public List<ALI> ALI;
        public List<DTM> DTM;
        public Loop_QTY_ORDCHG QTYLoop;
        public Loop_PCD_ORDCHG PCDLoop;
        public List<Loop_MOA_ORDCHG> MOALoop;
        public Loop_RTE_ORDCHG RTELoop;
        public List<Loop_TAX_ORDCHG> TAXLoop;
    }
    public class Loop_CTA_ORDCHG
    {
        public CTA_4 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_ORDCHG
    {
        public CUX_3 CUX;
        public List<DTM> DTM;
    }
    public class Loop_LIN_ORDCHG
    {
        public LIN_8 LIN;
        public List<PIA_8> PIA;
        public List<IMD_9> IMD;
        public List<MEA_12> MEA;
        public List<QTY_4> QTY;
        public List<DTM> DTM;
        public List<MOA_12> MOA;
        public List<GIN_4> GIN;
        public QVR_3 QVR;
        public List<FTX_13> FTX;
        public List<Loop_PRI_ORDCHG> PRILoop;
        public List<Loop_RFF_ORDCHG> RFFLoop;
        public List<Loop_PAC_ORDCHG> PACLoop;
        public List<Loop_LOC_ORDCHG_2> LOCLoop;
        public List<Loop_TAX_ORDCHG> TAXLoop;
        public List<Loop_NAD_ORDCHG_2> NADLoop;
        public List<Loop_ALC_ORDCHG_2> ALCLoop;
        public List<Loop_TDT_ORDCHG_2> TDTLoop;
    }
    public class Loop_LOC_ORDCHG
    {
        public LOC_7 LOC;
    }
    public class Loop_LOC_ORDCHG_2
    {
        public LOC_7 LOC;
        public QTY_4 QTY;
        public List<DTM> DTM;
    }
    public class Loop_MOA_ORDCHG
    {
        public MOA_12 MOA;
        public RNG_3 RNG;
    }
    public class Loop_NAD_ORDCHG
    {
        public NAD_18 NAD;
        public List<LOC_7> LOC;
        public List<Loop_RFF_ORDCHG_2> RFFLoop;
        public List<Loop_CTA_ORDCHG> CTALoop;
    }
    public class Loop_NAD_ORDCHG_2
    {
        public NAD_18 NAD;
        public List<Loop_CTA_ORDCHG> CTALoop;
    }
    public class Loop_PAC_ORDCHG
    {
        public PAC_8 PAC;
        public List<Loop_PCI_ORDCHG> PCILoop;
    }
    public class Loop_PAT_ORDCHG
    {
        public PAT_5 PAT;
        public List<DTM> DTM;
        public PCD_4 PCD;
        public MOA_12 MOA;
    }
    public class Loop_PCD_ORDCHG
    {
        public PCD_4 PCD;
        public RNG_3 RNG;
    }
    public class Loop_PCI_ORDCHG
    {
        public PCI_9 PCI;
        public RFF_25 RFF;
        public List<DTM> DTM;
        public List<GIN_4> GIN;
    }
    public class Loop_PRI_ORDCHG
    {
        public PRI_10 PRI;
        public CUX_3 CUX;
    }
    public class Loop_QTY_ORDCHG
    {
        public QTY_4 QTY;
        public RNG_3 RNG;
    }
    public class Loop_RFF_ORDCHG
    {
        public RFF_25 RFF;
        public List<DTM> DTM;
    }
    public class Loop_RFF_ORDCHG_2
    {
        public RFF_25 RFF;
    }
    public class Loop_RTE_ORDCHG
    {
        public RTE RTE;
        public RNG_3 RNG;
    }
    public class Loop_TAX_ORDCHG
    {
        public TAX_4 TAX;
        public MOA_12 MOA;
    }
    public class Loop_TDT_ORDCHG
    {
        public TDT_3 TDT;
        public List<Loop_LOC_ORDCHG> LOCLoop;
    }
    public class Loop_TDT_ORDCHG_2
    {
        public TDT_3 TDT;
    }
    public class Loop_TOD_ORDCHG
    {
        public TOD_7 TOD;
        public List<LOC_7> LOC;
    }
    public class TSORDCHG 
    {
        public UNH UNH;
        public BGM_24 BGM;
        public List<DTM> DTM;
        public PAI_7 PAI;
        public List<ALI> ALI;
        public List<FTX_13> FTX;
        public List<Loop_RFF_ORDCHG> RFFLoop;
        public List<Loop_NAD_ORDCHG> NADLoop;
        public List<Loop_TAX_ORDCHG> TAXLoop;
        public List<Loop_CUX_ORDCHG> CUXLoop;
        public List<Loop_PAT_ORDCHG> PATLoop;
        public List<Loop_TDT_ORDCHG> TDTLoop;
        public List<Loop_TOD_ORDCHG> TODLoop;
        public List<Loop_ALC_ORDCHG> ALCLoop;
        public List<Loop_LIN_ORDCHG> LINLoop;
        public UNS UNS;
        public List<MOA_12> MOA;
        public List<CNT_11> CNT;
        public UNT UNT;
    }
}
