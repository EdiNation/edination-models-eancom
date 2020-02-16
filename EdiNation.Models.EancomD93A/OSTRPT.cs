namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CTA_OSTRPT
    {
        public CTA_10 CTA;
        public List<COM_2> COM;
    }
    public class Loop_LIN_OSTRPT
    {
        public LIN LIN;
        public List<PIA_8> PIA;
        public List<IMD_10> IMD;
        public List<Loop_RFF_OSTRPT_2> RFFLoop;
        public List<Loop_QTY_OSTRPT> QTYLoop;
    }
    public class Loop_NAD_OSTRPT
    {
        public NAD_19 NAD;
        public List<Loop_CTA_OSTRPT> CTALoop;
    }
    public class Loop_QTY_OSTRPT
    {
        public QTY_26 QTY;
        public List<DTM_15> DTM;
        public LOC_13 LOC;
        public List<Loop_STS_OSTRPT> STSLoop;
    }
    public class Loop_RFF_OSTRPT
    {
        public RFF_8 RFF;
        public List<DTM_15> DTM;
        public List<Loop_STS_OSTRPT> STSLoop;
        public List<Loop_LIN_OSTRPT> LINLoop;
    }
    public class Loop_RFF_OSTRPT_2
    {
        public RFF_8 RFF;
        public List<DTM_15> DTM;
    }
    public class Loop_STS_OSTRPT
    {
        public STS STS;
        public List<DTM_15> DTM;
        public PCD_6 PCD;
        public NAD_19 NAD;
    }
    public class TSOSTRPT 
    {
        public UNH UNH;
        public BGM_15 BGM;
        public List<DTM_15> DTM;
        public RFF_8 RFF;
        public List<FTX_27> FTX;
        public List<Loop_NAD_OSTRPT> NADLoop;
        public List<Loop_RFF_OSTRPT> RFFLoop;
        public UNT UNT;
    }
}
