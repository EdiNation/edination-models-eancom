namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_CTA_GENRAL
    {
        public CTA CTA;
        public List<COM> COM;
    }
    public class Loop_CTA_GENRAL_2
    {
        public CTA CTA;
        public List<COM> COM;
    }
    public class Loop_FTX_GENRAL
    {
        public FTX_25 FTX;
        public List<Loop_NAD_GENRAL_2> NADLoop;
    }
    public class Loop_NAD_GENRAL
    {
        public NAD_12 NAD;
        public List<Loop_RFF_GENRAL> RFFLoop;
        public List<Loop_CTA_GENRAL> CTALoop;
    }
    public class Loop_NAD_GENRAL_2
    {
        public NAD_12 NAD;
        public List<Loop_RFF_GENRAL> RFFLoop;
        public List<Loop_CTA_GENRAL_2> CTALoop;
    }
    public class Loop_RFF_GENRAL
    {
        public RFF_15 RFF;
        public List<DTM_27> DTM;
    }
    public class TSGENRAL 
    {
        public UNH UNH;
        public BGM_14 BGM;
        public DTM_27 DTM;
        public List<Loop_RFF_GENRAL> RFFLoop;
        public List<Loop_NAD_GENRAL> NADLoop;
        public List<Loop_FTX_GENRAL> FTXLoop;
        public UNT UNT;
    }
}
