namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_AJT_REMADV
    {
        public AJT_3 AJT;
        public MOA_4 MOA;
        public RFF RFF;
    }
    public class Loop_CTA_REMADV
    {
        public CTA_17 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_REMADV
    {
        public CUX_4 CUX;
        public DTM_7 DTM;
    }
    public class Loop_DLI_REMADV
    {
        public DLI_2 DLI;
        public List<MOA_4> MOA;
        public List<PIA_2> PIA;
        public List<Loop_CUX_REMADV> CUXLoop;
        public List<Loop_AJT_REMADV> AJTLoop;
    }
    public class Loop_DOC_REMADV
    {
        public DOC_12 DOC;
        public List<MOA_4> MOA;
        public List<DTM_7> DTM;
        public List<RFF> RFF;
        public List<NAD> NAD;
        public List<Loop_CUX_REMADV> CUXLoop;
        public List<Loop_AJT_REMADV> AJTLoop;
        public List<Loop_DLI_REMADV> DLILoop;
    }
    public class Loop_NAD_REMADV
    {
        public NAD NAD;
        public List<Loop_CTA_REMADV> CTALoop;
    }
    public class TSREMADV 
    {
        public UNH UNH;
        public BGM_38 BGM;
        public List<DTM_7> DTM;
        public List<RFF> RFF;
        public List<FII_11> FII;
        public PAI_10 PAI;
        public List<Loop_NAD_REMADV> NADLoop;
        public List<Loop_CUX_REMADV> CUXLoop;
        public List<Loop_DOC_REMADV> DOCLoop;
        public UNS UNS;
        public List<MOA_4> MOA;
        public UNT UNT;
    }
}
