namespace EdiNation.Edifact.EAND96A
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
        public Loop_QTY_INVOIC QTYLoop;
        public Loop_PCD_INVOIC PCDLoop;
        public List<Loop_MOA_INVOIC> MOALoop;
        public Loop_RTE_INVOIC RTELoop;
        public List<Loop_TAX_INVOIC> TAXLoop;
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
        public CUX_7 CUX;
        public List<DTM_31> DTM;
    }
    public class Loop_LIN_INVOIC
    {
        public LIN_6 LIN;
        public List<PIA_7> PIA;
        public List<IMD_6> IMD;
        public List<MEA_9> MEA;
        public List<QTY_3> QTY;
        public List<ALI> ALI;
        public List<DTM_31> DTM;
        public QVR_2 QVR;
        public List<FTX_12> FTX;
        public List<Loop_MOA_INVOIC> MOALoop;
        public List<Loop_PAT_INVOIC> PATLoop;
        public List<Loop_PRI_INVOIC> PRILoop;
        public List<Loop_RFF_INVOIC> RFFLoop;
        public List<Loop_PAC_INVOIC_2> PACLoop;
        public List<Loop_LOC_INVOIC> LOCLoop;
        public List<Loop_TAX_INVOIC> TAXLoop;
        public List<Loop_NAD_INVOIC_2> NADLoop;
        public List<Loop_ALC_INVOIC_2> ALCLoop;
        public List<Loop_TDT_INVOIC> TDTLoop;
    }
    public class Loop_LOC_INVOIC
    {
        public LOC_4 LOC;
        public List<QTY_3> QTY;
        public List<DTM_31> DTM;
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
        public NAD_16 NAD;
        public List<FII_9> FII;
        public List<Loop_RFF_INVOIC_2> RFFLoop;
        public List<Loop_CTA_INVOIC> CTALoop;
    }
    public class Loop_NAD_INVOIC_2
    {
        public NAD_16 NAD;
        public List<Loop_RFF_INVOIC_2> RFFLoop;
    }
    public class Loop_PAC_INVOIC
    {
        public PAC_2 PAC;
    }
    public class Loop_PAC_INVOIC_2
    {
        public PAC_2 PAC;
        public List<MEA_9> MEA;
        public List<Loop_PCI_INVOIC> PCILoop;
    }
    public class Loop_PAT_INVOIC
    {
        public PAT PAT;
        public List<DTM_31> DTM;
        public PCD_3 PCD;
        public MOA_3 MOA;
    }
    public class Loop_PCD_INVOIC
    {
        public PCD_3 PCD;
    }
    public class Loop_PCI_INVOIC
    {
        public PCI_8 PCI;
        public List<GIN_2> GIN;
    }
    public class Loop_PRI_INVOIC
    {
        public PRI_8 PRI;
    }
    public class Loop_QTY_INVOIC
    {
        public QTY_3 QTY;
    }
    public class Loop_RFF_INVOIC
    {
        public RFF_22 RFF;
        public List<DTM_31> DTM;
    }
    public class Loop_RFF_INVOIC_2
    {
        public RFF_22 RFF;
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
    public class Loop_TDT_INVOIC
    {
        public TDT_2 TDT;
    }
    public class Loop_TOD_INVOIC
    {
        public TOD_6 TOD;
        public List<LOC_4> LOC;
    }
    public class TSINVOIC 
    {
        public UNH UNH;
        public BGM_21 BGM;
        public List<DTM_31> DTM;
        public PAI_6 PAI;
        public List<ALI> ALI;
        public List<FTX_12> FTX;
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
        public List<Loop_TAX_INVOIC_2> TAXLoop2;
        public List<Loop_ALC_INVOIC_3> ALCLoop2;
        public UNT UNT;
    }
}
