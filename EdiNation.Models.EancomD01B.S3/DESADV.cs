namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_CPS_DESADV
    {
        public CPS CPS;
        public List<Loop_PAC_DESADV> PACLoop;
        public List<Loop_LIN_DESADV> LINLoop;
    }
    public class Loop_CTA_DESADV
    {
        public CTA_12 CTA;
        public List<COM> COM;
    }
    public class Loop_EQD_DESADV
    {
        public EQD_2 EQD;
        public List<MEA> MEA;
        public List<SEL_2> SEL;
    }
    public class Loop_GIN_DESADV
    {
        public GIN GIN;
    }
    public class Loop_GIN_DESADV_2
    {
        public GIN GIN;
        public List<DLM> DLM;
    }
    public class Loop_HAN_DESADV
    {
        public HAN HAN;
    }
    public class Loop_LIN_DESADV
    {
        public LIN LIN;
        public List<PIA_7> PIA;
        public List<IMD_3> IMD;
        public List<MEA> MEA;
        public List<QTY_2> QTY;
        public List<ALI> ALI;
        public List<DLM> DLM;
        public List<DTM_25> DTM;
        public List<FTX_26> FTX;
        public List<MOA_9> MOA;
        public List<Loop_RFF_DESADV> RFFLoop;
        public List<Loop_LOC_DESADV_2> LOCLoop;
        public List<Loop_PCI_DESADV_2> PCILoop;
        public List<Loop_QVR_DESADV> QVRLoop;
    }
    public class Loop_LOC_DESADV
    {
        public LOC_13 LOC;
        public List<DTM_25> DTM;
    }
    public class Loop_LOC_DESADV_2
    {
        public LOC_13 LOC;
        public NAD_4 NAD;
        public DTM_25 DTM;
        public List<QTY_2> QTY;
    }
    public class Loop_NAD_DESADV
    {
        public NAD_4 NAD;
        public List<LOC_13> LOC;
        public List<Loop_RFF_DESADV_2> RFFLoop;
        public List<Loop_CTA_DESADV> CTALoop;
    }
    public class Loop_PAC_DESADV
    {
        public PAC_6 PAC;
        public List<MEA> MEA;
        public List<QTY_2> QTY;
        public List<Loop_HAN_DESADV> HANLoop;
        public List<Loop_PCI_DESADV> PCILoop;
    }
    public class Loop_PCI_DESADV
    {
        public PCI PCI;
        public RFF_14 RFF;
        public List<DTM_25> DTM;
        public List<Loop_GIN_DESADV> GINLoop;
    }
    public class Loop_PCI_DESADV_2
    {
        public PCI PCI;
        public List<DTM_25> DTM;
        public List<MEA> MEA;
        public QTY_2 QTY;
        public List<Loop_GIN_DESADV_2> GINLoop;
        public List<Loop_HAN_DESADV> HANLoop;
    }
    public class Loop_QVR_DESADV
    {
        public QVR_6 QVR;
        public List<DTM_25> DTM;
    }
    public class Loop_RFF_DESADV
    {
        public RFF_14 RFF;
        public DTM_25 DTM;
    }
    public class Loop_RFF_DESADV_2
    {
        public RFF_14 RFF;
    }
    public class Loop_TDT_DESADV
    {
        public TDT_7 TDT;
        public List<Loop_LOC_DESADV> LOCLoop;
    }
    public class Loop_TOD_DESADV
    {
        public TOD_4 TOD;
        public List<LOC_13> LOC;
    }
    public class TSDESADV 
    {
        public UNH UNH;
        public BGM_10 BGM;
        public List<DTM_25> DTM;
        public List<ALI> ALI;
        public List<MEA> MEA;
        public List<MOA_9> MOA;
        public List<Loop_RFF_DESADV> RFFLoop;
        public List<Loop_NAD_DESADV> NADLoop;
        public List<Loop_TOD_DESADV> TODLoop;
        public List<Loop_TDT_DESADV> TDTLoop;
        public List<Loop_EQD_DESADV> EQDLoop;
        public List<Loop_CPS_DESADV> CPSLoop;
        public List<CNT_4> CNT;
        public UNT UNT;
    }
}
