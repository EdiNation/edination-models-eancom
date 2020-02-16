namespace EdiNation.Edifact.EAND93A
{
    using System.Collections.Generic;
    public class Loop_CTA_SLSRPT
    {
        public CTA_15 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_SLSRPT
    {
        public CUX_14 CUX;
        public List<DTM_21> DTM;
    }
    public class Loop_LIN_SLSRPT
    {
        public LIN LIN;
        public List<PIA_8> PIA;
        public List<IMD> IMD;
        public List<PAC_8> PAC;
        public List<RFF_5> RFF;
        public List<DOC_13> DOC;
        public List<ALI_5> ALI;
        public List<MOA_18> MOA;
        public List<PRI_7> PRI;
        public List<QTY_22> QTY;
        public List<Loop_NAD_SLSRPT_2> NADLoop;
    }
    public class Loop_LOC_SLSRPT
    {
        public LOC_10 LOC;
        public List<DTM_21> DTM;
        public List<Loop_LIN_SLSRPT> LINLoop;
    }
    public class Loop_NAD_SLSRPT
    {
        public NAD_27 NAD;
        public List<Loop_CTA_SLSRPT> CTALoop;
    }
    public class Loop_NAD_SLSRPT_2
    {
        public NAD_17 NAD;
        public List<QTY_6> QTY;
    }
    public class Loop_RFF_SLSRPT
    {
        public RFF_5 RFF;
        public List<DTM_21> DTM;
    }
    public class TSSLSRPT 
    {
        public UNH UNH;
        public BGM_25 BGM;
        public List<DTM_21> DTM;
        public List<Loop_NAD_SLSRPT> NADLoop;
        public List<Loop_RFF_SLSRPT> RFFLoop;
        public List<Loop_CUX_SLSRPT> CUXLoop;
        public List<Loop_LOC_SLSRPT> LOCLoop;
        public UNT UNT;
    }
}
