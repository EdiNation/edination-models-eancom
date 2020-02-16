namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CCI_QALITY
    {
        public CCI_3 CCI;
        public List<Loop_MEA_QALITY> MEALoop;
    }
    public class Loop_CTA_QALITY
    {
        public CTA_9 CTA;
        public List<COM> COM;
    }
    public class Loop_LIN_QALITY
    {
        public LIN_6 LIN;
        public List<PIA_3> PIA;
        public List<IMD_14> IMD;
        public List<MEA_4> MEA;
        public List<DTM_36> DTM;
        public List<QTY_15> QTY;
        public List<FTX_17> FTX;
        public List<Loop_RFF_QALITY_2> RFFLoop;
        public List<Loop_NAD_QALITY_2> NADLoop;
        public List<Loop_CCI_QALITY> CCILoop;
    }
    public class Loop_MEA_QALITY
    {
        public MEA_4 MEA;
    }
    public class Loop_NAD_QALITY
    {
        public NAD_25 NAD;
        public List<LOC_18> LOC;
        public List<Loop_RFF_QALITY_2> RFFLoop;
        public List<Loop_CTA_QALITY> CTALoop;
    }
    public class Loop_NAD_QALITY_2
    {
        public NAD_25 NAD;
    }
    public class Loop_RFF_QALITY
    {
        public RFF_30 RFF;
        public List<DTM_36> DTM;
    }
    public class Loop_RFF_QALITY_2
    {
        public RFF_30 RFF;
    }
    public class TSQALITY 
    {
        public UNH UNH;
        public BGM_35 BGM;
        public List<DTM_36> DTM;
        public List<FTX_17> FTX;
        public List<Loop_RFF_QALITY> RFFLoop;
        public List<Loop_NAD_QALITY> NADLoop;
        public List<Loop_LIN_QALITY> LINLoop;
        public UNT UNT;
    }
}
