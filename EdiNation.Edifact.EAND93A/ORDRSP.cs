namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_ALC_ORDRSP
    {
        public ALC_3 ALC;
        public List<ALI> ALI;
        public List<DTM> DTM;
        public Loop_QTY_ORDRSP_2 QTYLoop;
        public Loop_PCD_ORDRSP PCDLoop;
        public List<Loop_MOA_ORDRSP> MOALoop;
        public Loop_RTE_ORDRSP RTELoop;
        public List<Loop_TAX_ORDRSP_2> TAXLoop;
    }
    public class Loop_ALC_ORDRSP_2
    {
        public ALC_3 ALC;
        public List<ALI_5> ALI;
        public List<DTM> DTM;
        public Loop_QTY_ORDRSP_3 QTYLoop;
        public Loop_PCD_ORDRSP_2 PCDLoop;
        public List<Loop_MOA_ORDRSP_2> MOALoop;
        public Loop_RTE_ORDRSP_2 RTELoop;
        public List<Loop_TAX_ORDRSP_3> TAXLoop;
    }
    public class Loop_ALC_ORDRSP_3
    {
        public ALC_3 ALC;
        public ALI ALI;
        public List<MOA_4> MOA;
    }
    public class Loop_API_ORDRSP
    {
        public API_3 API;
        public List<DTM> DTM;
        public RNG RNG;
    }
    public class Loop_CTA_ORDRSP
    {
        public CTA_5 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_ORDRSP
    {
        public CUX_7 CUX;
        public List<PCD> PCD;
        public List<DTM> DTM;
    }
    public class Loop_DOC_ORDRSP
    {
        public DOC_7 DOC;
        public List<DTM> DTM;
    }
    public class Loop_EQD_ORDRSP
    {
        public EQD EQD;
        public List<HAN> HAN;
        public List<MEA_3> MEA;
        public List<FTX_2> FTX;
    }
    public class Loop_LIN_ORDRSP
    {
        public LIN_5 LIN;
        public List<PIA_10> PIA;
        public List<IMD> IMD;
        public List<MEA_10> MEA;
        public List<QTY_17> QTY;
        public List<PCD> PCD;
        public List<ALI> ALI;
        public List<DTM> DTM;
        public List<MOA_4> MOA;
        public List<GIN_2> GIN;
        public List<GIR_2> GIR;
        public QVA_6 QVA;
        public List<DOC_7> DOC;
        public PAI PAI;
        public List<FTX_19> FTX;
        public List<Loop_PAT_ORDRSP> PATLoop;
        public List<Loop_PRI_ORDRSP> PRILoop;
        public List<Loop_RFF_ORDRSP> RFFLoop;
        public List<Loop_PAC_ORDRSP_2> PACLoop;
        public List<Loop_LOC_ORDRSP_2> LOCLoop;
        public List<Loop_TAX_ORDRSP> TAXLoop;
        public List<Loop_NAD_ORDRSP_2> NADLoop;
        public List<Loop_ALC_ORDRSP_2> ALCLoop;
        public List<Loop_TDT_ORDRSP> TDTLoop;
        public List<Loop_TOD_ORDRSP_2> TODLoop;
        public List<Loop_EQD_ORDRSP> EQDLoop;
        public List<Loop_SCC_ORDRSP> SCCLoop;
        public List<Loop_RCS_ORDRSP> RCSLoop;
    }
    public class Loop_LOC_ORDRSP
    {
        public LOC_5 LOC;
        public List<DTM> DTM;
    }
    public class Loop_LOC_ORDRSP_2
    {
        public LOC_5 LOC;
        public QTY_17 QTY;
        public List<DTM> DTM;
    }
    public class Loop_MOA_ORDRSP
    {
        public MOA_4 MOA;
        public RNG RNG;
    }
    public class Loop_MOA_ORDRSP_2
    {
        public MOA_15 MOA;
        public RNG_2 RNG;
    }
    public class Loop_NAD_ORDRSP
    {
        public NAD_11 NAD;
        public List<LOC_5> LOC;
        public List<FII_4> FII;
        public List<Loop_RFF_ORDRSP> RFFLoop;
        public List<Loop_DOC_ORDRSP> DOCLoop;
        public List<Loop_CTA_ORDRSP> CTALoop;
    }
    public class Loop_NAD_ORDRSP_2
    {
        public NAD_11 NAD;
        public List<LOC_5> LOC;
        public List<Loop_RFF_ORDRSP> RFFLoop;
        public List<Loop_DOC_ORDRSP> DOCLoop;
        public List<Loop_CTA_ORDRSP> CTALoop;
    }
    public class Loop_PAC_ORDRSP
    {
        public PAC_13 PAC;
        public List<MEA_3> MEA;
        public List<Loop_PCI_ORDRSP> PCILoop;
    }
    public class Loop_PAC_ORDRSP_2
    {
        public PAC_4 PAC;
        public List<MEA_3> MEA;
        public List<QTY_13> QTY;
        public List<DTM> DTM;
        public Loop_RFF_ORDRSP RFFLoop;
        public List<Loop_PCI_ORDRSP> PCILoop;
    }
    public class Loop_PAT_ORDRSP
    {
        public PAT PAT;
        public List<DTM> DTM;
        public PCD PCD;
        public MOA_4 MOA;
    }
    public class Loop_PCD_ORDRSP
    {
        public PCD PCD;
        public RNG RNG;
    }
    public class Loop_PCD_ORDRSP_2
    {
        public PCD PCD;
        public RNG_2 RNG;
    }
    public class Loop_PCI_ORDRSP
    {
        public PCI_4 PCI;
        public RFF_2 RFF;
        public List<DTM> DTM;
        public List<GIN_2> GIN;
    }
    public class Loop_PRI_ORDRSP
    {
        public PRI_10 PRI;
        public CUX_7 CUX;
        public API_3 API;
        public RNG RNG;
        public List<DTM> DTM;
    }
    public class Loop_QTY_ORDRSP
    {
        public QTY_13 QTY;
        public List<DTM> DTM;
    }
    public class Loop_QTY_ORDRSP_2
    {
        public QTY_13 QTY;
        public RNG RNG;
    }
    public class Loop_QTY_ORDRSP_3
    {
        public QTY_17 QTY;
        public RNG_2 RNG;
    }
    public class Loop_RCS_ORDRSP
    {
        public RCS_3 RCS;
        public List<RFF_2> RFF;
        public List<DTM> DTM;
        public List<FTX_2> FTX;
    }
    public class Loop_RFF_ORDRSP
    {
        public RFF_2 RFF;
        public List<DTM> DTM;
    }
    public class Loop_RTE_ORDRSP
    {
        public RTE_3 RTE;
        public RNG RNG;
    }
    public class Loop_RTE_ORDRSP_2
    {
        public RTE_2 RTE;
        public RNG_2 RNG;
    }
    public class Loop_SCC_ORDRSP
    {
        public SCC_2 SCC;
        public List<FTX_2> FTX;
        public List<RFF_2> RFF;
        public List<Loop_QTY_ORDRSP> QTYLoop;
    }
    public class Loop_TAX_ORDRSP
    {
        public TAX_6 TAX;
        public MOA_4 MOA;
        public List<LOC_5> LOC;
    }
    public class Loop_TAX_ORDRSP_2
    {
        public TAX_2 TAX;
        public MOA_4 MOA;
    }
    public class Loop_TAX_ORDRSP_3
    {
        public TAX_6 TAX;
        public MOA_4 MOA;
    }
    public class Loop_TDT_ORDRSP
    {
        public TDT_4 TDT;
        public List<Loop_LOC_ORDRSP> LOCLoop;
    }
    public class Loop_TOD_ORDRSP
    {
        public TOD_8 TOD;
        public List<LOC_5> LOC;
    }
    public class Loop_TOD_ORDRSP_2
    {
        public TOD_2 TOD;
        public List<LOC_5> LOC;
    }
    public class TSORDRSP 
    {
        public UNH UNH;
        public BGM_13 BGM;
        public List<DTM> DTM;
        public PAI PAI;
        public List<ALI> ALI;
        public IMD_14 IMD;
        public List<FTX_19> FTX;
        public List<Loop_RFF_ORDRSP> RFFLoop;
        public List<Loop_NAD_ORDRSP> NADLoop;
        public List<Loop_TAX_ORDRSP> TAXLoop;
        public List<Loop_CUX_ORDRSP> CUXLoop;
        public List<Loop_PAT_ORDRSP> PATLoop;
        public List<Loop_TDT_ORDRSP> TDTLoop;
        public List<Loop_TOD_ORDRSP> TODLoop;
        public List<Loop_PAC_ORDRSP> PACLoop;
        public List<Loop_EQD_ORDRSP> EQDLoop;
        public List<Loop_SCC_ORDRSP> SCCLoop;
        public List<Loop_API_ORDRSP> APILoop;
        public List<Loop_ALC_ORDRSP> ALCLoop;
        public List<Loop_RCS_ORDRSP> RCSLoop;
        public List<Loop_LIN_ORDRSP> LINLoop;
        public UNS UNS;
        public List<MOA_4> MOA;
        public List<CNT_2> CNT;
        public List<Loop_ALC_ORDRSP_3> ALCLoop2;
        public UNT UNT;
    }
}
