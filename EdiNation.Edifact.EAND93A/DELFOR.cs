namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CTA_DELFOR
    {
        public CTA_2 CTA;
        public List<COM> COM;
    }
    public class Loop_DOC_DELFOR
    {
        public DOC DOC;
        public List<DTM_3> DTM;
    }
    public class Loop_DOC_DELFOR_2
    {
        public DOC DOC;
        public DTM_3 DTM;
    }
    public class Loop_LIN_DELFOR
    {
        public LIN LIN;
        public List<PIA> PIA;
        public List<IMD_5> IMD;
        public List<MEA_6> MEA;
        public List<ALI_4> ALI;
        public List<GIN_2> GIN;
        public List<GIR_2> GIR;
        public List<LOC_2> LOC;
        public List<DTM_3> DTM;
        public List<FTX_6> FTX;
        public List<Loop_CTA_DELFOR> CTALoop;
        public List<Loop_RFF_DELFOR> RFFLoop;
        public List<Loop_TDT_DELFOR_2> TDTLoop;
        public List<Loop_QTY_DELFOR> QTYLoop;
        public List<Loop_PAC_DELFOR> PACLoop;
    }
    public class Loop_LIN_DELFOR_2
    {
        public LIN LIN;
        public List<PIA> PIA;
        public List<IMD_5> IMD;
        public List<MEA_6> MEA;
        public List<ALI_4> ALI;
        public List<GIN_2> GIN;
        public List<GIR_2> GIR;
        public List<DTM_3> DTM;
        public List<FTX_6> FTX;
        public List<Loop_RFF_DELFOR> RFFLoop;
        public List<Loop_QTY_DELFOR_2> QTYLoop;
        public List<Loop_PAC_DELFOR_2> PACLoop;
        public List<Loop_NAD_DELFOR_3> NADLoop;
    }
    public class Loop_NAD_DELFOR
    {
        public NAD_5 NAD;
        public List<LOC_2> LOC;
        public List<Loop_CTA_DELFOR> CTALoop;
    }
    public class Loop_NAD_DELFOR_2
    {
        public NAD_5 NAD;
        public List<LOC_2> LOC;
        public List<FTX_6> FTX;
        public List<Loop_DOC_DELFOR> DOCLoop;
        public List<Loop_CTA_DELFOR> CTALoop;
        public List<Loop_TDT_DELFOR> TDTLoop;
        public List<Loop_LIN_DELFOR> LINLoop;
    }
    public class Loop_NAD_DELFOR_3
    {
        public NAD_5 NAD;
        public List<LOC_2> LOC;
        public List<FTX_6> FTX;
        public List<Loop_DOC_DELFOR_2> DOCLoop;
        public List<Loop_CTA_DELFOR> CTALoop;
        public List<Loop_QTY_DELFOR_3> QTYLoop;
        public List<Loop_QVA_DELFOR_2> QVALoop;
        public List<Loop_TDT_DELFOR> TDTLoop;
    }
    public class Loop_PAC_DELFOR
    {
        public PAC PAC;
        public List<MEA_6> MEA;
        public List<QTY_7> QTY;
        public List<DTM_3> DTM;
        public List<Loop_PCI_DELFOR> PCILoop;
        public List<Loop_QVA_DELFOR> QVALoop;
    }
    public class Loop_PAC_DELFOR_2
    {
        public PAC PAC;
        public List<MEA_6> MEA;
        public List<QTY_7> QTY;
        public List<DTM_3> DTM;
        public List<Loop_PCI_DELFOR> PCILoop;
    }
    public class Loop_PCI_DELFOR
    {
        public PCI_2 PCI;
        public List<GIN_2> GIN;
    }
    public class Loop_QTY_DELFOR
    {
        public QTY_19 QTY;
        public SCC SCC;
        public List<DTM_3> DTM;
        public List<Loop_RFF_DELFOR> RFFLoop;
    }
    public class Loop_QTY_DELFOR_2
    {
        public QTY_19 QTY;
        public SCC SCC;
        public List<DTM_3> DTM;
        public List<Loop_RFF_DELFOR> RFFLoop;
    }
    public class Loop_QTY_DELFOR_3
    {
        public QTY_7 QTY;
        public SCC SCC;
        public List<DTM_3> DTM;
        public List<Loop_RFF_DELFOR> RFFLoop;
    }
    public class Loop_QVA_DELFOR
    {
        public QVA_2 QVA;
        public List<DTM_3> DTM;
        public List<Loop_RFF_DELFOR> RFFLoop;
    }
    public class Loop_QVA_DELFOR_2
    {
        public QVA_2 QVA;
        public List<DTM_3> DTM;
        public List<Loop_RFF_DELFOR> RFFLoop;
    }
    public class Loop_RFF_DELFOR
    {
        public RFF_10 RFF;
        public DTM_3 DTM;
    }
    public class Loop_TDT_DELFOR
    {
        public TDT_7 TDT;
        public List<DTM_3> DTM;
    }
    public class Loop_TDT_DELFOR_2
    {
        public TDT TDT;
        public List<DTM_3> DTM;
    }
    public class TSDELFOR 
    {
        public UNH UNH;
        public BGM_2 BGM;
        public List<DTM_3> DTM;
        public List<Loop_RFF_DELFOR> RFFLoop;
        public List<Loop_NAD_DELFOR> NADLoop;
        public UNS UNS;
        public List<Loop_NAD_DELFOR_2> NADLoop2;
        public List<Loop_LIN_DELFOR_2> LINLoop;
        public UNS UNS2;
        public List<CNT_2> CNT;
        public List<FTX_21> FTX;
        public UNT UNT;
    }
}
