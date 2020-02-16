namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CCI_PARTIN
    {
        public CCI_3 CCI;
        public List<MOA_5> MOA;
        public List<QTY_15> QTY;
        public List<CAV> CAV;
        public List<DTM_35> DTM;
        public List<MEA_10> MEA;
    }
    public class Loop_CTA_PARTIN
    {
        public CTA_7 CTA;
        public List<COM> COM;
    }
    public class Loop_DOC_PARTIN
    {
        public DOC_13 DOC;
    }
    public class Loop_LIN_PARTIN
    {
        public LIN LIN;
        public NAD_24 NAD;
        public List<Loop_DOC_PARTIN> DOCLoop;
    }
    public class Loop_NAD_PARTIN
    {
        public NAD_24 NAD;
        public List<Loop_CTA_PARTIN> CTALoop;
    }
    public class Loop_NAD_PARTIN_2
    {
        public NAD_24 NAD;
        public List<DTM_35> DTM;
        public List<FII_7> FII;
        public List<IDE> IDE;
        public List<FTX_20> FTX;
        public List<TAX> TAX;
        public List<HYN_2> HYN;
        public List<Loop_RFF_PARTIN> RFFLoop;
        public List<Loop_CTA_PARTIN> CTALoop;
        public List<Loop_SCC_PARTIN> SCCLoop;
        public Loop_TOD_PARTIN TODLoop;
        public List<Loop_PAI_PARTIN> PAILoop;
        public List<Loop_CCI_PARTIN> CCILoop;
        public List<Loop_PRC_PARTIN> PRCLoop;
    }
    public class Loop_PAI_PARTIN
    {
        public PAI_5 PAI;
        public PAT_3 PAT;
        public List<CUX> CUX;
        public List<DTM_35> DTM;
        public List<PCD_7> PCD;
        public List<MOA_5> MOA;
    }
    public class Loop_PRC_PARTIN
    {
        public PRC_2 PRC;
        public List<DTM_35> DTM;
        public List<Loop_LIN_PARTIN> LINLoop;
    }
    public class Loop_RFF_PARTIN
    {
        public RFF_30 RFF;
        public DTM_35 DTM;
    }
    public class Loop_SCC_PARTIN
    {
        public SCC_2 SCC;
        public List<DTM_35> DTM;
    }
    public class Loop_TOD_PARTIN
    {
        public TOD_2 TOD;
        public LOC_13 LOC;
    }
    public class TSPARTIN 
    {
        public UNH UNH;
        public BGM_31 BGM;
        public List<DTM_35> DTM;
        public List<FII_7> FII;
        public List<FTX_20> FTX;
        public List<Loop_RFF_PARTIN> RFFLoop;
        public List<Loop_NAD_PARTIN> NADLoop;
        public UNS UNS;
        public List<Loop_NAD_PARTIN_2> NADLoop2;
        public UNT UNT;
    }
}
