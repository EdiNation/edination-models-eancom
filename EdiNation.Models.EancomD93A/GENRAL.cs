namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CTA_GENRAL
    {
        public CTA_3 CTA;
        public List<COM> COM;
    }
    public class Loop_FTX_GENRAL
    {
        public FTX_22 FTX;
        public List<Loop_NAD_GENRAL_2> NADLoop;
    }
    public class Loop_NAD_GENRAL
    {
        public NAD_6 NAD;
        public List<Loop_RFF_GENRAL> RFFLoop;
        public List<Loop_CTA_GENRAL> CTALoop;
    }
    public class Loop_NAD_GENRAL_2
    {
        public NAD_6 NAD;
        public List<Loop_RFF_GENRAL> RFFLoop;
        public List<Loop_CTA_GENRAL> CTALoop;
    }
    public class Loop_RFF_GENRAL
    {
        public RFF_12 RFF;
        public List<DTM_11> DTM;
    }
    public class TSGENRAL 
    {
        public UNH UNH;
        public BGM_4 BGM;
        public List<DTM_11> DTM;
        public List<Loop_RFF_GENRAL> RFFLoop;
        public List<Loop_NAD_GENRAL> NADLoop;
        public List<Loop_FTX_GENRAL> FTXLoop;
        public UNT UNT;
    }
}
