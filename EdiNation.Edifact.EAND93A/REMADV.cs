namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_AJT_REMADV
    {
        public AJT AJT;
        public MOA_7 MOA;
        public RFF_4 RFF;
    }
    public class Loop_CTA_REMADV
    {
        public CTA_14 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_REMADV
    {
        public CUX_3 CUX;
        public DTM_9 DTM;
    }
    public class Loop_DLI_REMADV
    {
        public DLI DLI;
        public List<MOA_12> MOA;
        public List<PIA_2> PIA;
        public List<DTM_9> DTM;
        public List<Loop_CUX_REMADV> CUXLoop;
        public List<Loop_AJT_REMADV> AJTLoop;
    }
    public class Loop_DOC_REMADV
    {
        public DOC_10 DOC;
        public List<MOA_12> MOA;
        public List<DTM_9> DTM;
        public List<RFF_4> RFF;
        public List<NAD> NAD;
        public List<Loop_CUX_REMADV> CUXLoop;
        public List<Loop_AJT_REMADV> AJTLoop;
        public List<Loop_DLI_REMADV> DLILoop;
    }
    public class Loop_NAD_REMADV
    {
        public NAD_24 NAD;
        public List<Loop_CTA_REMADV> CTALoop;
    }
    public class TSREMADV 
    {
        public UNH UNH;
        public BGM_22 BGM;
        public List<DTM_9> DTM;
        public List<RFF_4> RFF;
        public List<FII_7> FII;
        public PAI_3 PAI;
        public List<FTX_31> FTX;
        public List<Loop_NAD_REMADV> NADLoop;
        public List<Loop_CUX_REMADV> CUXLoop;
        public List<Loop_DOC_REMADV> DOCLoop;
        public UNS UNS;
        public List<MOA_7> MOA;
        public UNT UNT;
    }
}
