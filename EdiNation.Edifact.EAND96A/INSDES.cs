namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CTA_INSDES
    {
        public CTA_9 CTA;
        public List<COM> COM;
    }
    public class Loop_EQD_INSDES
    {
        public EQD_2 EQD;
        public List<EQN_2> EQN;
        public List<MEA_10> MEA;
    }
    public class Loop_LIN_INSDES
    {
        public LIN_7 LIN;
        public List<PIA_4> PIA;
        public List<IMD_5> IMD;
        public List<QTY_14> QTY;
        public List<GIN_2> GIN;
        public List<DTM_30> DTM;
        public List<FTX_11> FTX;
        public List<MOA_18> MOA;
        public List<Loop_RFF_INSDES> RFFLoop;
        public List<Loop_NAD_INSDES_2> NADLoop;
        public List<Loop_PCI_INSDES> PCILoop;
    }
    public class Loop_NAD_INSDES
    {
        public NAD_15 NAD;
        public List<LOC_12> LOC;
        public List<Loop_RFF_INSDES_2> RFFLoop;
        public List<Loop_CTA_INSDES> CTALoop;
    }
    public class Loop_NAD_INSDES_2
    {
        public NAD_15 NAD;
        public List<LOC_12> LOC;
    }
    public class Loop_PCI_INSDES
    {
        public PCI_7 PCI;
        public GIN_2 GIN;
    }
    public class Loop_RFF_INSDES
    {
        public RFF_21 RFF;
        public DTM_30 DTM;
    }
    public class Loop_RFF_INSDES_2
    {
        public RFF_21 RFF;
    }
    public class Loop_TDT_INSDES
    {
        public TDT_5 TDT;
    }
    public class Loop_TOD_INSDES
    {
        public TOD_5 TOD;
        public List<LOC_12> LOC;
    }
    public class TSINSDES 
    {
        public UNH UNH;
        public BGM_20 BGM;
        public List<DTM_30> DTM;
        public List<FTX_11> FTX;
        public List<Loop_RFF_INSDES> RFFLoop;
        public List<Loop_NAD_INSDES> NADLoop;
        public List<Loop_TOD_INSDES> TODLoop;
        public List<Loop_TDT_INSDES> TDTLoop;
        public List<Loop_EQD_INSDES> EQDLoop;
        public List<Loop_LIN_INSDES> LINLoop;
        public UNS UNS;
        public List<MOA_18> MOA;
        public List<CNT_4> CNT;
        public UNT UNT;
    }
}
