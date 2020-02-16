namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_ALC_ORDRSP
    {
        public ALC_4 ALC;
        public List<ALI> ALI;
        public List<DTM_9> DTM;
        public Loop_QTY_ORDRSP QTYLoop;
        public Loop_PCD_ORDRSP PCDLoop;
        public List<Loop_MOA_ORDRSP> MOALoop;
        public Loop_RTE_ORDRSP RTELoop;
        public List<Loop_TAX_ORDRSP> TAXLoop;
    }
    public class Loop_ALC_ORDRSP_2
    {
        public ALC_4 ALC;
        public List<ALI> ALI;
        public List<DTM_9> DTM;
        public Loop_QTY_ORDRSP QTYLoop;
        public Loop_PCD_ORDRSP PCDLoop;
        public List<Loop_MOA_ORDRSP> MOALoop;
        public Loop_RTE_ORDRSP RTELoop;
        public List<Loop_TAX_ORDRSP> TAXLoop;
    }
    public class Loop_CTA_ORDRSP
    {
        public CTA_6 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_ORDRSP
    {
        public CUX CUX;
        public List<DTM_9> DTM;
    }
    public class Loop_EQD_ORDRSP
    {
        public EQD_3 EQD;
    }
    public class Loop_LIN_ORDRSP
    {
        public LIN_4 LIN;
        public List<PIA_7> PIA;
        public List<IMD_10> IMD;
        public List<MEA_14> MEA;
        public List<QTY_6> QTY;
        public List<ALI> ALI;
        public List<DTM_9> DTM;
        public List<MOA_12> MOA;
        public List<GIN_3> GIN;
        public QVR_5 QVR;
        public List<FTX_16> FTX;
        public List<Loop_PRI_ORDRSP> PRILoop;
        public List<Loop_RFF_ORDRSP> RFFLoop;
        public List<Loop_PAC_ORDRSP_2> PACLoop;
        public List<Loop_LOC_ORDRSP_2> LOCLoop;
        public List<Loop_TAX_ORDRSP> TAXLoop;
        public List<Loop_NAD_ORDRSP_2> NADLoop;
        public List<Loop_ALC_ORDRSP_2> ALCLoop;
        public List<Loop_TDT_ORDRSP_2> TDTLoop;
    }
    public class Loop_LOC_ORDRSP
    {
        public LOC_8 LOC;
        public List<DTM_9> DTM;
    }
    public class Loop_LOC_ORDRSP_2
    {
        public LOC_8 LOC;
        public QTY_6 QTY;
        public List<DTM_9> DTM;
    }
    public class Loop_MOA_ORDRSP
    {
        public MOA_12 MOA;
        public RNG_3 RNG;
    }
    public class Loop_NAD_ORDRSP
    {
        public NAD_22 NAD;
        public List<LOC_8> LOC;
        public List<FII_12> FII;
        public List<Loop_RFF_ORDRSP_2> RFFLoop;
        public List<Loop_CTA_ORDRSP> CTALoop;
    }
    public class Loop_NAD_ORDRSP_2
    {
        public NAD_22 NAD;
        public List<Loop_CTA_ORDRSP> CTALoop;
    }
    public class Loop_PAC_ORDRSP
    {
        public PAC_2 PAC;
        public List<Loop_PCI_ORDRSP> PCILoop;
    }
    public class Loop_PAC_ORDRSP_2
    {
        public PAC_2 PAC;
        public List<QTY_6> QTY;
        public List<Loop_PCI_ORDRSP> PCILoop;
    }
    public class Loop_PAT_ORDRSP
    {
        public PAT_7 PAT;
        public List<DTM_9> DTM;
        public PCD_4 PCD;
        public MOA_12 MOA;
    }
    public class Loop_PCD_ORDRSP
    {
        public PCD_4 PCD;
        public RNG_3 RNG;
    }
    public class Loop_PCI_ORDRSP
    {
        public PCI_4 PCI;
        public RFF_29 RFF;
        public List<DTM_9> DTM;
        public List<GIN_3> GIN;
    }
    public class Loop_PRI_ORDRSP
    {
        public PRI_8 PRI;
        public CUX CUX;
        public List<DTM_9> DTM;
    }
    public class Loop_QTY_ORDRSP
    {
        public QTY_6 QTY;
        public RNG_3 RNG;
    }
    public class Loop_RFF_ORDRSP
    {
        public RFF_29 RFF;
        public List<DTM_9> DTM;
    }
    public class Loop_RFF_ORDRSP_2
    {
        public RFF_29 RFF;
    }
    public class Loop_RTE_ORDRSP
    {
        public RTE RTE;
        public RNG_3 RNG;
    }
    public class Loop_TAX_ORDRSP
    {
        public TAX_4 TAX;
        public MOA_12 MOA;
    }
    public class Loop_TDT_ORDRSP
    {
        public TDT_6 TDT;
        public List<Loop_LOC_ORDRSP> LOCLoop;
    }
    public class Loop_TDT_ORDRSP_2
    {
        public TDT_6 TDT;
    }
    public class Loop_TOD_ORDRSP
    {
        public TOD_7 TOD;
        public List<LOC_8> LOC;
    }
    public class TSORDRSP 
    {
        public UNH UNH;
        public BGM_28 BGM;
        public List<DTM_9> DTM;
        public PAI_10 PAI;
        public List<ALI> ALI;
        public List<FTX_16> FTX;
        public List<Loop_RFF_ORDRSP> RFFLoop;
        public List<Loop_NAD_ORDRSP> NADLoop;
        public List<Loop_TAX_ORDRSP> TAXLoop;
        public List<Loop_CUX_ORDRSP> CUXLoop;
        public List<Loop_PAT_ORDRSP> PATLoop;
        public List<Loop_TDT_ORDRSP> TDTLoop;
        public List<Loop_TOD_ORDRSP> TODLoop;
        public List<Loop_PAC_ORDRSP> PACLoop;
        public List<Loop_EQD_ORDRSP> EQDLoop;
        public List<Loop_ALC_ORDRSP> ALCLoop;
        public List<Loop_LIN_ORDRSP> LINLoop;
        public UNS UNS;
        public List<MOA_12> MOA;
        public List<CNT_11> CNT;
        public UNT UNT;
    }
}
