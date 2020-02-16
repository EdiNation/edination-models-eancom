namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_AJT_COACSU
    {
        public AJT_5 AJT;
        public MOA_11 MOA;
        public RFF_10 RFF;
    }
    public class Loop_CTA_COACSU
    {
        public CTA_10 CTA;
        public List<COM_2> COM;
    }
    public class Loop_CUX_COACSU
    {
        public CUX_2 CUX;
    }
    public class Loop_DOC_COACSU
    {
        public DOC_5 DOC;
        public List<DTM_21> DTM;
        public List<Loop_NAD_COACSU_2> NADLoop;
        public List<Loop_MOA_COACSU> MOALoop;
    }
    public class Loop_MOA_COACSU
    {
        public MOA_11 MOA;
        public List<TAX> TAX;
        public List<Loop_AJT_COACSU> AJTLoop;
    }
    public class Loop_MOA_COACSU_2
    {
        public MOA_11 MOA;
        public List<TAX> TAX;
        public List<DTM_21> DTM;
    }
    public class Loop_NAD_COACSU
    {
        public NAD_7 NAD;
        public List<FII_9> FII;
        public List<Loop_RFF_COACSU> RFFLoop;
        public List<Loop_CTA_COACSU> CTALoop;
    }
    public class Loop_NAD_COACSU_2
    {
        public NAD_7 NAD;
        public List<Loop_RFF_COACSU_2> RFFLoop;
    }
    public class Loop_PYT_COACSU
    {
        public PYT PYT;
        public List<MOA_11> MOA;
        public List<PCD_8> PCD;
        public List<DTM_21> DTM;
        public FII_9 FII;
        public List<PAI_6> PAI;
    }
    public class Loop_RFF_COACSU
    {
        public RFF_10 RFF;
    }
    public class Loop_RFF_COACSU_2
    {
        public RFF_10 RFF;
        public List<DTM_21> DTM;
    }
    public class TSCOACSU 
    {
        public UNH UNH;
        public BGM_4 BGM;
        public List<DTM_21> DTM;
        public List<FTX_29> FTX;
        public List<Loop_RFF_COACSU> RFFLoop;
        public List<Loop_NAD_COACSU> NADLoop;
        public List<Loop_CUX_COACSU> CUXLoop;
        public List<Loop_PYT_COACSU> PYTLoop;
        public List<Loop_DOC_COACSU> DOCLoop;
        public UNS UNS;
        public List<Loop_MOA_COACSU_2> MOALoop;
        public CNT_2 CNT;
        public UNT UNT;
    }
}
