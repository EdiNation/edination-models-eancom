namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_CCI_PROINQ
    {
        public CCI_2 CCI;
        public List<CAV> CAV;
        public List<MEA_2> MEA;
    }
    public class Loop_CTA_PROINQ
    {
        public CTA_15 CTA;
        public List<COM_2> COM;
    }
    public class Loop_IRQ_PROINQ
    {
        public IRQ IRQ;
        public List<PIA_5> PIA;
        public List<MEA_2> MEA;
        public List<NAD_3> NAD;
        public List<PGI_2> PGI;
        public List<DTM_36> DTM;
        public List<Loop_PRI_PROINQ> PRILoop;
    }
    public class Loop_LIN_PROINQ
    {
        public LIN LIN;
        public List<Loop_CCI_PROINQ> CCILoop;
        public List<Loop_IRQ_PROINQ> IRQLoop;
    }
    public class Loop_NAD_PROINQ
    {
        public NAD_3 NAD;
        public List<Loop_CTA_PROINQ> CTALoop;
    }
    public class Loop_PRI_PROINQ
    {
        public PRI_9 PRI;
        public RNG_6 RNG;
    }
    public class Loop_RFF_PROINQ
    {
        public RFF_43 RFF;
        public List<DTM_36> DTM;
    }
    public class TSPROINQ 
    {
        public UNH UNH;
        public BGM_35 BGM;
        public List<DTM_36> DTM;
        public CUX_2 CUX;
        public List<Loop_NAD_PROINQ> NADLoop;
        public List<Loop_RFF_PROINQ> RFFLoop;
        public List<Loop_LIN_PROINQ> LINLoop;
        public UNT UNT;
    }
}
