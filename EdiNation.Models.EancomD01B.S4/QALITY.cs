namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CCI_QALITY
    {
        public CCI_4 CCI;
        public List<Loop_MEA_QALITY> MEALoop;
    }
    public class Loop_CTA_QALITY
    {
        public CTA_9 CTA;
        public List<COM> COM;
    }
    public class Loop_LIN_QALITY
    {
        public LIN LIN;
        public List<PIA_4> PIA;
        public List<IMD_13> IMD;
        public List<MEA_5> MEA;
        public List<DTM_38> DTM;
        public List<QTY_19> QTY;
        public List<FTX_18> FTX;
        public List<Loop_RFF_QALITY_2> RFFLoop;
        public List<Loop_NAD_QALITY_2> NADLoop;
        public List<Loop_CCI_QALITY> CCILoop;
    }
    public class Loop_MEA_QALITY
    {
        public MEA_5 MEA;
    }
    public class Loop_NAD_QALITY
    {
        public NAD_29 NAD;
        public List<LOC_22> LOC;
        public List<Loop_RFF_QALITY_2> RFFLoop;
        public List<Loop_CTA_QALITY> CTALoop;
    }
    public class Loop_NAD_QALITY_2
    {
        public NAD_29 NAD;
    }
    public class Loop_RFF_QALITY
    {
        public RFF_33 RFF;
        public List<DTM_38> DTM;
    }
    public class Loop_RFF_QALITY_2
    {
        public RFF_33 RFF;
    }
    public class TSQALITY 
    {
        public UNH UNH;
        public BGM_37 BGM;
        public List<DTM_38> DTM;
        public List<FTX_18> FTX;
        public List<Loop_RFF_QALITY> RFFLoop;
        public List<Loop_NAD_QALITY> NADLoop;
        public List<Loop_LIN_QALITY> LINLoop;
        public UNT UNT;
    }
}
