namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_CTA_SLSRPT
    {
        public CTA_18 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_SLSRPT
    {
        public CUX CUX;
        public List<DTM_41> DTM;
    }
    public class Loop_LIN_SLSRPT
    {
        public LIN LIN;
        public List<PIA_4> PIA;
        public List<IMD_15> IMD;
        public List<RFF_38> RFF;
        public List<ALI> ALI;
        public List<MOA_24> MOA;
        public List<Loop_PRI_SLSRPT> PRILoop;
        public List<PAI_2> PAI;
        public List<Loop_QTY_SLSRPT> QTYLoop;
    }
    public class Loop_LOC_SLSRPT
    {
        public LOC_20 LOC;
        public List<DTM_41> DTM;
        public List<Loop_LIN_SLSRPT> LINLoop;
    }
    public class Loop_NAD_SLSRPT
    {
        public NAD_29 NAD;
        public List<Loop_CTA_SLSRPT> CTALoop;
        public List<Loop_RFF_SLSRPT_2> RFFLoop;
    }
    public class Loop_PRI_SLSRPT
    {
        public PRI_12 PRI;
    }
    public class Loop_QTY_SLSRPT
    {
        public QTY_25 QTY;
        public NAD_29 NAD;
    }
    public class Loop_RFF_SLSRPT
    {
        public RFF_38 RFF;
        public List<DTM_41> DTM;
    }
    public class Loop_RFF_SLSRPT_2
    {
        public RFF_38 RFF;
    }
    public class TSSLSRPT 
    {
        public UNH UNH;
        public BGM_44 BGM;
        public List<DTM_41> DTM;
        public List<Loop_RFF_SLSRPT> RFFLoop;
        public List<Loop_NAD_SLSRPT> NADLoop;
        public List<Loop_CUX_SLSRPT> CUXLoop;
        public List<Loop_LOC_SLSRPT> LOCLoop;
        public UNT UNT;
    }
}
