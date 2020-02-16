namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_ATT_PROINQ
    {
        public ATT ATT;
    }
    public class Loop_CTA_PROINQ
    {
        public CTA_15 CTA;
        public List<COM_2> COM;
    }
    public class Loop_IRQ_PROINQ
    {
        public IRQ IRQ;
        public List<PIA_4> PIA;
        public List<MEA_11> MEA;
        public List<NAD_3> NAD;
        public List<PGI_2> PGI;
        public List<DTM_35> DTM;
        public List<Loop_PRI_PROINQ> PRILoop;
    }
    public class Loop_LIN_PROINQ
    {
        public LIN_4 LIN;
        public List<Loop_ATT_PROINQ> ATTLoop;
        public List<Loop_IRQ_PROINQ> IRQLoop;
    }
    public class Loop_NAD_PROINQ
    {
        public NAD_3 NAD;
        public List<Loop_CTA_PROINQ> CTALoop;
    }
    public class Loop_PRI_PROINQ
    {
        public PRI_11 PRI;
        public RNG_5 RNG;
    }
    public class Loop_RFF_PROINQ
    {
        public RFF_42 RFF;
        public List<DTM_35> DTM;
    }
    public class TSPROINQ 
    {
        public UNH UNH;
        public BGM_34 BGM;
        public List<DTM_35> DTM;
        public CUX_12 CUX;
        public List<Loop_NAD_PROINQ> NADLoop;
        public List<Loop_RFF_PROINQ> RFFLoop;
        public List<Loop_LIN_PROINQ> LINLoop;
        public UNT UNT;
    }
}
