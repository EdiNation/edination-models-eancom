namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_AJT_REMADV
    {
        public AJT_4 AJT;
        public MOA_4 MOA;
        public RFF RFF;
        public List<FTX_24> FTX;
        public List<QTY_14> QTY;
        public List<Loop_TAX_REMADV> TAXLoop;
    }
    public class Loop_AJT_REMADV_2
    {
        public AJT_4 AJT;
        public MOA_4 MOA;
        public RFF RFF;
        public List<Loop_TAX_REMADV> TAXLoop;
    }
    public class Loop_CTA_REMADV
    {
        public CTA_17 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_REMADV
    {
        public CUX CUX;
        public DTM_10 DTM;
    }
    public class Loop_DLI_REMADV
    {
        public DLI_2 DLI;
        public List<MOA_4> MOA;
        public List<PIA_3> PIA;
        public List<Loop_CUX_REMADV> CUXLoop;
        public List<Loop_AJT_REMADV_2> AJTLoop;
    }
    public class Loop_DOC_REMADV
    {
        public DOC_15 DOC;
        public List<MOA_4> MOA;
        public List<DTM_10> DTM;
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
    public class Loop_TAX_REMADV
    {
        public TAX TAX;
        public List<MOA_4> MOA;
    }
    public class TSREMADV 
    {
        public UNH UNH;
        public BGM_39 BGM;
        public List<DTM_10> DTM;
        public List<RFF> RFF;
        public List<FII_13> FII;
        public PAI_11 PAI;
        public List<Loop_NAD_REMADV> NADLoop;
        public List<Loop_CUX_REMADV> CUXLoop;
        public List<Loop_DOC_REMADV> DOCLoop;
        public UNS UNS;
        public List<MOA_4> MOA;
        public UNT UNT;
    }
}
