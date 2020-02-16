namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CTA_SLSRPT
    {
        public CTA_18 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_SLSRPT
    {
        public CUX_10 CUX;
        public List<DTM_41> DTM;
    }
    public class Loop_LIN_SLSRPT
    {
        public LIN_6 LIN;
        public List<PIA_3> PIA;
        public List<IMD_16> IMD;
        public List<RFF_4> RFF;
        public List<ALI> ALI;
        public List<MOA_22> MOA;
        public List<PRI_6> PRI;
        public List<Loop_QTY_SLSRPT> QTYLoop;
    }
    public class Loop_LOC_SLSRPT
    {
        public LOC_16 LOC;
        public List<DTM_41> DTM;
        public List<Loop_LIN_SLSRPT> LINLoop;
    }
    public class Loop_NAD_SLSRPT
    {
        public NAD_26 NAD;
        public List<Loop_CTA_SLSRPT> CTALoop;
    }
    public class Loop_QTY_SLSRPT
    {
        public QTY_23 QTY;
        public NAD_26 NAD;
    }
    public class Loop_RFF_SLSRPT
    {
        public RFF_4 RFF;
        public List<DTM_41> DTM;
    }
    public class TSSLSRPT 
    {
        public UNH UNH;
        public BGM_43 BGM;
        public List<DTM_41> DTM;
        public List<Loop_NAD_SLSRPT> NADLoop;
        public List<Loop_RFF_SLSRPT> RFFLoop;
        public List<Loop_CUX_SLSRPT> CUXLoop;
        public List<Loop_LOC_SLSRPT> LOCLoop;
        public UNT UNT;
    }
}
