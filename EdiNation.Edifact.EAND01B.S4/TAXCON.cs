namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_DOC_TAXCON
    {
        public DOC_16 DOC;
        public List<MOA_19> MOA;
        public CNT_2 CNT;
        public List<Loop_TAX_TAXCON> TAXLoop;
    }
    public class Loop_NAD_TAXCON
    {
        public NAD_44 NAD;
        public RFF_7 RFF;
    }
    public class Loop_RFF_TAXCON
    {
        public RFF_7 RFF;
        public List<DTM_43> DTM;
    }
    public class Loop_RFF_TAXCON_2
    {
        public RFF_7 RFF;
        public List<DTM_43> DTM;
        public List<Loop_DOC_TAXCON> DOCLoop;
    }
    public class Loop_TAX_TAXCON
    {
        public TAX_7 TAX;
        public List<MOA_19> MOA;
    }
    public class TSTAXCON 
    {
        public UNH UNH;
        public BGM_46 BGM;
        public List<DTM_43> DTM;
        public List<Loop_RFF_TAXCON> RFFLoop;
        public List<Loop_NAD_TAXCON> NADLoop;
        public UNS UNS;
        public List<Loop_RFF_TAXCON_2> RFFLoop2;
        public UNT UNT;
    }
}
