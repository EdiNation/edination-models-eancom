namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_ALC_INVOIC
    {
        public ALC_3 ALC;
        public Loop_QTY_INVOIC QTYLoop;
        public Loop_PCD_INVOIC PCDLoop;
        public List<Loop_MOA_INVOIC> MOALoop;
        public Loop_RTE_INVOIC RTELoop;
        public List<Loop_TAX_INVOIC> TAXLoop;
    }
    public class Loop_ALC_INVOIC_2
    {
        public ALC_3 ALC;
        public List<ALI> ALI;
        public List<DTM> DTM;
        public Loop_QTY_INVOIC QTYLoop;
        public Loop_PCD_INVOIC PCDLoop;
        public List<Loop_MOA_INVOIC> MOALoop;
        public Loop_RTE_INVOIC RTELoop;
        public List<Loop_TAX_INVOIC_2> TAXLoop;
    }
    public class Loop_ALC_INVOIC_3
    {
        public ALC_3 ALC;
        public ALI ALI;
        public List<MOA_3> MOA;
    }
    public class Loop_CTA_INVOIC
    {
        public CTA_13 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_INVOIC
    {
        public CUX CUX;
        public List<DTM> DTM;
    }
    public class Loop_LIN_INVOIC
    {
        public LIN LIN;
        public List<PIA_8> PIA;
        public List<IMD_2> IMD;
        public List<MEA_9> MEA;
        public List<QTY_3> QTY;
        public List<ALI> ALI;
        public List<DTM> DTM;
        public List<GIN_4> GIN;
        public QVR_2 QVR;
        public List<FTX_13> FTX;
        public List<Loop_MOA_INVOIC> MOALoop;
        public List<Loop_PAT_INVOIC_2> PATLoop;
        public List<Loop_PRI_INVOIC> PRILoop;
        public List<Loop_RFF_INVOIC> RFFLoop;
        public List<Loop_PAC_INVOIC_2> PACLoop;
        public List<Loop_LOC_INVOIC_2> LOCLoop;
        public List<Loop_TAX_INVOIC_2> TAXLoop;
        public List<Loop_NAD_INVOIC_2> NADLoop;
        public List<Loop_ALC_INVOIC_2> ALCLoop;
        public List<Loop_TDT_INVOIC_2> TDTLoop;
        public List<Loop_TOD_INVOIC> TODLoop;
    }
    public class Loop_LOC_INVOIC
    {
        public LOC_14 LOC;
        public List<DTM> DTM;
    }
    public class Loop_LOC_INVOIC_2
    {
        public LOC_14 LOC;
        public List<QTY_3> QTY;
        public List<DTM> DTM;
    }
    public class Loop_MOA_INVOIC
    {
        public MOA_3 MOA;
    }
    public class Loop_MOA_INVOIC_2
    {
        public MOA_3 MOA;
        public Loop_RFF_INVOIC RFFLoop;
    }
    public class Loop_NAD_INVOIC
    {
        public NAD_19 NAD;
        public List<FII_8> FII;
        public List<Loop_RFF_INVOIC_2> RFFLoop;
        public List<Loop_CTA_INVOIC> CTALoop;
    }
    public class Loop_NAD_INVOIC_2
    {
        public NAD_19 NAD;
        public List<Loop_RFF_INVOIC_2> RFFLoop;
    }
    public class Loop_PAC_INVOIC
    {
        public PAC PAC;
    }
    public class Loop_PAC_INVOIC_2
    {
        public PAC PAC;
        public List<MEA_9> MEA;
        public List<Loop_PCI_INVOIC> PCILoop;
    }
    public class Loop_PAT_INVOIC
    {
        public PAT PAT;
        public List<DTM> DTM;
        public PCD_3 PCD;
        public MOA_3 MOA;
        public PAI PAI;
        public FII_8 FII;
    }
    public class Loop_PAT_INVOIC_2
    {
        public PAT PAT;
        public List<DTM> DTM;
        public List<PCD_3> PCD;
        public MOA_3 MOA;
    }
    public class Loop_PCD_INVOIC
    {
        public PCD_3 PCD;
    }
    public class Loop_PCI_INVOIC
    {
        public PCI_5 PCI;
        public List<GIN_4> GIN;
    }
    public class Loop_PRI_INVOIC
    {
        public PRI_6 PRI;
        public APR_2 APR;
    }
    public class Loop_QTY_INVOIC
    {
        public QTY_3 QTY;
    }
    public class Loop_RFF_INVOIC
    {
        public RFF_24 RFF;
        public List<DTM> DTM;
    }
    public class Loop_RFF_INVOIC_2
    {
        public RFF_24 RFF;
    }
    public class Loop_RTE_INVOIC
    {
        public RTE RTE;
    }
    public class Loop_TAX_INVOIC
    {
        public TAX TAX;
        public MOA_3 MOA;
    }
    public class Loop_TAX_INVOIC_2
    {
        public TAX TAX;
        public List<MOA_3> MOA;
    }
    public class Loop_TAX_INVOIC_3
    {
        public TAX TAX;
        public List<MOA_3> MOA;
    }
    public class Loop_TDT_INVOIC
    {
        public TDT_3 TDT;
        public List<Loop_LOC_INVOIC> LOCLoop;
    }
    public class Loop_TDT_INVOIC_2
    {
        public TDT_3 TDT;
    }
    public class Loop_TOD_INVOIC
    {
        public TOD_2 TOD;
        public List<LOC_14> LOC;
    }
    public class TSINVOIC 
    {
        public UNH UNH;
        public BGM_23 BGM;
        public List<DTM> DTM;
        public PAI PAI;
        public List<ALI> ALI;
        public List<FTX_13> FTX;
        public List<Loop_RFF_INVOIC> RFFLoop;
        public List<Loop_NAD_INVOIC> NADLoop;
        public List<Loop_TAX_INVOIC> TAXLoop;
        public List<Loop_CUX_INVOIC> CUXLoop;
        public List<Loop_PAT_INVOIC> PATLoop;
        public List<Loop_TDT_INVOIC> TDTLoop;
        public List<Loop_TOD_INVOIC> TODLoop;
        public List<Loop_PAC_INVOIC> PACLoop;
        public List<Loop_ALC_INVOIC> ALCLoop;
        public List<Loop_LIN_INVOIC> LINLoop;
        public UNS UNS;
        public List<CNT_9> CNT;
        public List<Loop_MOA_INVOIC_2> MOALoop;
        public List<Loop_TAX_INVOIC_3> TAXLoop2;
        public List<Loop_ALC_INVOIC_3> ALCLoop2;
        public UNT UNT;
    }
}
