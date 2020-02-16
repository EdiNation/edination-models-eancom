namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_ALC_INVOIC
    {
        public ALC ALC;
        public List<ALI> ALI;
        public List<Loop_RFF_INVOIC> RFFLoop;
        public Loop_QTY_INVOIC QTYLoop;
        public Loop_PCD_INVOIC PCDLoop;
        public List<Loop_MOA_INVOIC> MOALoop;
        public Loop_RTE_INVOIC RTELoop;
        public List<Loop_TAX_INVOIC_2> TAXLoop;
    }
    public class Loop_ALC_INVOIC_2
    {
        public ALC ALC;
        public List<ALI_5> ALI;
        public Loop_QTY_INVOIC QTYLoop;
        public Loop_PCD_INVOIC PCDLoop;
        public List<Loop_MOA_INVOIC> MOALoop;
        public Loop_RTE_INVOIC RTELoop;
        public List<Loop_TAX_INVOIC_2> TAXLoop;
    }
    public class Loop_ALC_INVOIC_3
    {
        public ALC ALC;
        public ALI_5 ALI;
        public List<MOA_3> MOA;
    }
    public class Loop_CTA_INVOIC
    {
        public CTA_4 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_INVOIC
    {
        public CUX_10 CUX;
        public List<DTM_6> DTM;
    }
    public class Loop_DOC_INVOIC
    {
        public DOC_3 DOC;
        public List<DTM_6> DTM;
    }
    public class Loop_LIN_INVOIC
    {
        public LIN LIN;
        public List<PIA_7> PIA;
        public List<IMD> IMD;
        public List<MEA_5> MEA;
        public List<QTY_5> QTY;
        public PCD_4 PCD;
        public List<ALI_5> ALI;
        public List<DTM_6> DTM;
        public List<GIN_2> GIN;
        public List<GIR_2> GIR;
        public QVA_3 QVA;
        public List<FTX_14> FTX;
        public List<Loop_MOA_INVOIC_2> MOALoop;
        public List<Loop_PAT_INVOIC> PATLoop;
        public List<Loop_PRI_INVOIC> PRILoop;
        public List<Loop_RFF_INVOIC> RFFLoop;
        public List<Loop_PAC_INVOIC_2> PACLoop;
        public List<Loop_LOC_INVOIC_2> LOCLoop;
        public List<Loop_TAX_INVOIC> TAXLoop;
        public List<Loop_NAD_INVOIC_2> NADLoop;
        public List<Loop_ALC_INVOIC_2> ALCLoop;
        public List<Loop_TDT_INVOIC> TDTLoop;
        public List<Loop_TOD_INVOIC_2> TODLoop;
        public List<Loop_RCS_INVOIC> RCSLoop;
    }
    public class Loop_LOC_INVOIC
    {
        public LOC_4 LOC;
        public List<DTM_6> DTM;
    }
    public class Loop_LOC_INVOIC_2
    {
        public LOC_4 LOC;
        public List<QTY_5> QTY;
        public List<DTM_6> DTM;
    }
    public class Loop_MOA_INVOIC
    {
        public MOA_3 MOA;
        public RNG_4 RNG;
    }
    public class Loop_MOA_INVOIC_2
    {
        public MOA_13 MOA;
        public CUX_4 CUX;
    }
    public class Loop_MOA_INVOIC_3
    {
        public MOA_3 MOA;
        public Loop_RFF_INVOIC RFFLoop;
    }
    public class Loop_NAD_INVOIC
    {
        public NAD_9 NAD;
        public List<LOC_4> LOC;
        public List<FII_3> FII;
        public List<Loop_RFF_INVOIC> RFFLoop;
        public List<Loop_DOC_INVOIC> DOCLoop;
        public List<Loop_CTA_INVOIC> CTALoop;
    }
    public class Loop_NAD_INVOIC_2
    {
        public NAD_9 NAD;
        public List<LOC_4> LOC;
        public List<Loop_RFF_INVOIC> RFFLoop;
        public List<Loop_DOC_INVOIC> DOCLoop;
        public List<Loop_CTA_INVOIC> CTALoop;
    }
    public class Loop_PAC_INVOIC
    {
        public PAC_11 PAC;
        public List<MEA_8> MEA;
        public List<Loop_PCI_INVOIC> PCILoop;
    }
    public class Loop_PAC_INVOIC_2
    {
        public PAC_2 PAC;
        public List<MEA_5> MEA;
        public List<Loop_PCI_INVOIC_2> PCILoop;
    }
    public class Loop_PAT_INVOIC
    {
        public PAT PAT;
        public List<DTM_6> DTM;
        public PCD_4 PCD;
        public MOA_3 MOA;
    }
    public class Loop_PCD_INVOIC
    {
        public PCD_4 PCD;
        public RNG_4 RNG;
    }
    public class Loop_PCI_INVOIC
    {
        public PCI_2 PCI;
        public RFF RFF;
        public List<DTM_6> DTM;
        public List<GIN_2> GIN;
    }
    public class Loop_PCI_INVOIC_2
    {
        public PCI_2 PCI;
        public RFF RFF;
        public List<DTM_6> DTM;
        public List<GIN_2> GIN;
    }
    public class Loop_PRI_INVOIC
    {
        public PRI_8 PRI;
        public API_5 API;
        public RNG_4 RNG;
        public List<DTM_6> DTM;
    }
    public class Loop_QTY_INVOIC
    {
        public QTY_5 QTY;
        public RNG_4 RNG;
    }
    public class Loop_RCS_INVOIC
    {
        public RCS RCS;
        public List<RFF> RFF;
        public List<DTM_6> DTM;
        public List<FTX_12> FTX;
    }
    public class Loop_RFF_INVOIC
    {
        public RFF RFF;
        public List<DTM_6> DTM;
    }
    public class Loop_RTE_INVOIC
    {
        public RTE RTE;
        public RNG_4 RNG;
    }
    public class Loop_TAX_INVOIC
    {
        public TAX TAX;
        public MOA_3 MOA;
        public List<LOC_4> LOC;
    }
    public class Loop_TAX_INVOIC_2
    {
        public TAX TAX;
        public MOA_3 MOA;
    }
    public class Loop_TAX_INVOIC_3
    {
        public TAX TAX;
        public List<MOA_3> MOA;
    }
    public class Loop_TDT_INVOIC
    {
        public TDT_2 TDT;
        public List<Loop_LOC_INVOIC> LOCLoop;
    }
    public class Loop_TOD_INVOIC
    {
        public TOD_7 TOD;
        public List<LOC_4> LOC;
    }
    public class Loop_TOD_INVOIC_2
    {
        public TOD TOD;
        public List<LOC_4> LOC;
    }
    public class TSINVOIC 
    {
        public UNH UNH;
        public BGM_8 BGM;
        public List<DTM_6> DTM;
        public PAI_3 PAI;
        public List<ALI_5> ALI;
        public IMD_14 IMD;
        public List<FTX_26> FTX;
        public List<Loop_RFF_INVOIC> RFFLoop;
        public List<Loop_NAD_INVOIC> NADLoop;
        public List<Loop_TAX_INVOIC> TAXLoop;
        public List<Loop_CUX_INVOIC> CUXLoop;
        public List<Loop_PAT_INVOIC> PATLoop;
        public List<Loop_TDT_INVOIC> TDTLoop;
        public List<Loop_TOD_INVOIC> TODLoop;
        public List<Loop_PAC_INVOIC> PACLoop;
        public List<Loop_ALC_INVOIC> ALCLoop;
        public List<Loop_RCS_INVOIC> RCSLoop;
        public List<Loop_LIN_INVOIC> LINLoop;
        public UNS UNS;
        public List<CNT_5> CNT;
        public List<Loop_MOA_INVOIC_3> MOALoop;
        public List<Loop_TAX_INVOIC_3> TAXLoop2;
        public List<Loop_ALC_INVOIC_3> ALCLoop2;
        public UNT UNT;
    }
}
