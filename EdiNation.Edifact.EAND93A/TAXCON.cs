namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_DOC_TAXCON
    {
        public DOC_11 DOC;
        public MOA_11 MOA;
        public CNT CNT;
        public List<Loop_TAX_TAXCON> TAXLoop;
    }
    public class Loop_NAD_TAXCON
    {
        public NAD_28 NAD;
        public RFF_6 RFF;
    }
    public class Loop_RFF_TAXCON
    {
        public RFF_6 RFF;
        public List<DTM_22> DTM;
    }
    public class Loop_RFF_TAXCON_2
    {
        public RFF_6 RFF;
        public List<DTM_22> DTM;
        public List<Loop_DOC_TAXCON> DOCLoop;
    }
    public class Loop_TAX_TAXCON
    {
        public TAX_8 TAX;
        public List<MOA_11> MOA;
    }
    public class TSTAXCON 
    {
        public UNH UNH;
        public BGM_26 BGM;
        public List<DTM_22> DTM;
        public List<Loop_RFF_TAXCON> RFFLoop;
        public List<Loop_NAD_TAXCON> NADLoop;
        public UNS UNS;
        public List<Loop_RFF_TAXCON_2> RFFLoop2;
        public UNT UNT;
    }
}
