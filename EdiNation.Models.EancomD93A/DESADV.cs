namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CPS_DESADV
    {
        public CPS CPS;
        public List<FTX_5> FTX;
        public List<Loop_PAC_DESADV> PACLoop;
        public List<Loop_LIN_DESADV> LINLoop;
    }
    public class Loop_CTA_DESADV
    {
        public CTA_9 CTA;
        public List<COM> COM;
    }
    public class Loop_DGS_DESADV
    {
        public DGS DGS;
        public QTY_16 QTY;
        public List<FTX_5> FTX;
    }
    public class Loop_EQD_DESADV
    {
        public EQD_2 EQD;
        public List<MEA_2> MEA;
        public List<SEL_2> SEL;
        public List<EQA> EQA;
        public List<Loop_HAN_DESADV> HANLoop;
    }
    public class Loop_GIN_DESADV
    {
        public GIN GIN;
        public List<DLM_3> DLM;
    }
    public class Loop_GIN_DESADV_2
    {
        public GIN GIN;
        public List<DLM> DLM;
    }
    public class Loop_HAN_DESADV
    {
        public HAN HAN;
        public List<FTX_5> FTX;
    }
    public class Loop_HAN_DESADV_2
    {
        public HAN_2 HAN;
        public List<FTX_5> FTX;
    }
    public class Loop_HAN_DESADV_3
    {
        public HAN_2 HAN;
        public List<FTX_5> FTX;
        public List<GIN> GIN;
    }
    public class Loop_LIN_DESADV
    {
        public LIN LIN;
        public List<PIA_5> PIA;
        public List<IMD> IMD;
        public List<MEA_2> MEA;
        public List<QTY_4> QTY;
        public List<ALI_4> ALI;
        public List<GIN> GIN;
        public List<GIR> GIR;
        public List<DLM> DLM;
        public List<DTM_5> DTM;
        public List<FTX_17> FTX;
        public List<Loop_RFF_DESADV> RFFLoop;
        public List<Loop_DGS_DESADV> DGSLoop;
        public List<Loop_LOC_DESADV_2> LOCLoop;
        public List<Loop_SGP_DESADV> SGPLoop;
        public List<Loop_PCI_DESADV_2> PCILoop;
        public List<Loop_QVA_DESADV> QVALoop;
    }
    public class Loop_LOC_DESADV
    {
        public LOC_4 LOC;
        public List<DTM_5> DTM;
    }
    public class Loop_LOC_DESADV_2
    {
        public LOC_4 LOC;
        public NAD_3 NAD;
        public DTM_5 DTM;
        public List<QTY_4> QTY;
    }
    public class Loop_NAD_DESADV
    {
        public NAD_20 NAD;
        public List<LOC_4> LOC;
        public List<Loop_RFF_DESADV> RFFLoop;
        public List<Loop_CTA_DESADV> CTALoop;
    }
    public class Loop_PAC_DESADV
    {
        public PAC_9 PAC;
        public List<MEA_2> MEA;
        public List<QTY_4> QTY;
        public List<Loop_HAN_DESADV_2> HANLoop;
        public List<Loop_PCI_DESADV> PCILoop;
    }
    public class Loop_PCI_DESADV
    {
        public PCI_3 PCI;
        public RFF_11 RFF;
        public List<DTM_5> DTM;
        public List<GIR> GIR;
        public List<Loop_GIN_DESADV> GINLoop;
    }
    public class Loop_PCI_DESADV_2
    {
        public PCI_3 PCI;
        public List<DTM_5> DTM;
        public List<MEA_2> MEA;
        public QTY_4 QTY;
        public List<Loop_GIN_DESADV_2> GINLoop;
        public List<Loop_HAN_DESADV_3> HANLoop;
    }
    public class Loop_QVA_DESADV
    {
        public QVA_8 QVA;
        public List<DTM_5> DTM;
    }
    public class Loop_RFF_DESADV
    {
        public RFF_11 RFF;
        public DTM_5 DTM;
    }
    public class Loop_SGP_DESADV
    {
        public SGP SGP;
        public List<QTY_16> QTY;
    }
    public class Loop_TDT_DESADV
    {
        public TDT_8 TDT;
        public PCD_7 PCD;
        public List<Loop_LOC_DESADV> LOCLoop;
    }
    public class Loop_TOD_DESADV
    {
        public TOD_5 TOD;
        public List<LOC_4> LOC;
        public List<FTX_5> FTX;
    }
    public class TSDESADV 
    {
        public UNH UNH;
        public BGM_3 BGM;
        public List<DTM_5> DTM;
        public List<ALI_4> ALI;
        public List<MEA_20> MEA;
        public List<Loop_RFF_DESADV> RFFLoop;
        public List<Loop_NAD_DESADV> NADLoop;
        public List<Loop_TOD_DESADV> TODLoop;
        public List<Loop_TDT_DESADV> TDTLoop;
        public List<Loop_EQD_DESADV> EQDLoop;
        public List<Loop_CPS_DESADV> CPSLoop;
        public CNT_2 CNT;
        public UNT UNT;
    }
}
