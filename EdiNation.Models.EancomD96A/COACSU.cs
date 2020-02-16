namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_AJT_COACSU
    {
        public AJT_4 AJT;
        public MOA_15 MOA;
        public RFF_9 RFF;
    }
    public class Loop_CTA_COACSU
    {
        public CTA_10 CTA;
        public List<COM_2> COM;
    }
    public class Loop_CUX_COACSU
    {
        public CUX_6 CUX;
    }
    public class Loop_DOC_COACSU
    {
        public DOC_5 DOC;
        public List<DTM_18> DTM;
        public List<Loop_NAD_COACSU_2> NADLoop;
        public List<Loop_MOA_COACSU> MOALoop;
    }
    public class Loop_MOA_COACSU
    {
        public MOA_15 MOA;
        public List<TAX> TAX;
        public List<Loop_AJT_COACSU> AJTLoop;
    }
    public class Loop_MOA_COACSU_2
    {
        public MOA_15 MOA;
        public List<TAX> TAX;
        public List<DTM_18> DTM;
    }
    public class Loop_NAD_COACSU
    {
        public NAD_6 NAD;
        public List<FII_7> FII;
        public List<Loop_RFF_COACSU> RFFLoop;
        public List<Loop_CTA_COACSU> CTALoop;
    }
    public class Loop_NAD_COACSU_2
    {
        public NAD_6 NAD;
        public List<Loop_RFF_COACSU_2> RFFLoop;
    }
    public class Loop_PAT_COACSU
    {
        public PAT_4 PAT;
        public List<MOA_15> MOA;
        public List<PCD_8> PCD;
        public List<DTM_18> DTM;
        public FII_7 FII;
        public List<PAI_3> PAI;
        public List<Loop_TAX_COACSU> TAXLoop;
    }
    public class Loop_RFF_COACSU
    {
        public RFF_9 RFF;
    }
    public class Loop_RFF_COACSU_2
    {
        public RFF_9 RFF;
        public List<DTM_18> DTM;
    }
    public class Loop_TAX_COACSU
    {
        public TAX TAX;
        public List<MOA_15> MOA;
    }
    public class TSCOACSU 
    {
        public UNH UNH;
        public BGM_4 BGM;
        public List<DTM_18> DTM;
        public List<FTX_27> FTX;
        public List<Loop_NAD_COACSU> NADLoop;
        public List<Loop_CUX_COACSU> CUXLoop;
        public List<Loop_PAT_COACSU> PATLoop;
        public List<Loop_DOC_COACSU> DOCLoop;
        public UNS UNS;
        public List<Loop_MOA_COACSU_2> MOALoop;
        public UNT UNT;
    }
}
