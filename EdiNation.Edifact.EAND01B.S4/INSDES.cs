namespace EdiNation.Edifact.EAND01B.S4
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
        public List<MEA_12> MEA;
    }
    public class Loop_LIN_INSDES
    {
        public LIN LIN;
        public List<PIA_5> PIA;
        public List<IMD_5> IMD;
        public List<QTY_18> QTY;
        public List<GIN_2> GIN;
        public List<DTM_32> DTM;
        public List<FTX_12> FTX;
        public List<MOA_21> MOA;
        public List<Loop_RFF_INSDES_3> RFFLoop;
        public List<Loop_NAD_INSDES_2> NADLoop;
        public List<Loop_PCI_INSDES> PCILoop;
    }
    public class Loop_NAD_INSDES
    {
        public NAD_18 NAD;
        public List<LOC_9> LOC;
        public List<Loop_RFF_INSDES_2> RFFLoop;
        public List<Loop_CTA_INSDES> CTALoop;
    }
    public class Loop_NAD_INSDES_2
    {
        public NAD_18 NAD;
        public List<LOC_9> LOC;
    }
    public class Loop_PCI_INSDES
    {
        public PCI PCI;
        public List<GIN_2> GIN;
    }
    public class Loop_RFF_INSDES
    {
        public RFF_23 RFF;
        public List<DTM_32> DTM;
    }
    public class Loop_RFF_INSDES_2
    {
        public RFF_23 RFF;
    }
    public class Loop_RFF_INSDES_3
    {
        public RFF_23 RFF;
        public DTM_32 DTM;
    }
    public class Loop_TDT_INSDES
    {
        public TDT_7 TDT;
    }
    public class Loop_TOD_INSDES
    {
        public TOD_6 TOD;
        public List<LOC_9> LOC;
    }
    public class TSINSDES 
    {
        public UNH UNH;
        public BGM_22 BGM;
        public List<DTM_32> DTM;
        public List<FTX_12> FTX;
        public List<Loop_RFF_INSDES> RFFLoop;
        public List<Loop_NAD_INSDES> NADLoop;
        public List<Loop_TOD_INSDES> TODLoop;
        public List<Loop_TDT_INSDES> TDTLoop;
        public List<Loop_EQD_INSDES> EQDLoop;
        public List<Loop_LIN_INSDES> LINLoop;
        public UNS UNS;
        public List<MOA_21> MOA;
        public List<CNT_8> CNT;
        public UNT UNT;
    }
}
