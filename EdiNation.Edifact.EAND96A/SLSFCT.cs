namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CTA_SLSFCT
    {
        public CTA_18 CTA;
        public List<COM> COM;
    }
    public class Loop_CUX_SLSFCT
    {
        public CUX_10 CUX;
        public List<DTM_40> DTM;
    }
    public class Loop_LIN_SLSFCT
    {
        public LIN_12 LIN;
        public List<PIA_13> PIA;
        public List<IMD_15> IMD;
        public List<RFF_4> RFF;
        public List<ALI> ALI;
        public List<MOA_22> MOA;
        public List<PRI_5> PRI;
        public List<Loop_QTY_SLSFCT> QTYLoop;
    }
    public class Loop_LOC_SLSFCT
    {
        public LOC_15 LOC;
        public List<DTM_40> DTM;
        public List<Loop_LIN_SLSFCT> LINLoop;
    }
    public class Loop_NAD_SLSFCT
    {
        public NAD_42 NAD;
        public List<Loop_CTA_SLSFCT> CTALoop;
    }
    public class Loop_QTY_SLSFCT
    {
        public QTY_22 QTY;
    }
    public class Loop_RFF_SLSFCT
    {
        public RFF_4 RFF;
        public List<DTM_40> DTM;
    }
    public class TSSLSFCT 
    {
        public UNH UNH;
        public BGM_42 BGM;
        public List<DTM_40> DTM;
        public List<Loop_NAD_SLSFCT> NADLoop;
        public List<Loop_RFF_SLSFCT> RFFLoop;
        public List<Loop_CUX_SLSFCT> CUXLoop;
        public List<Loop_LOC_SLSFCT> LOCLoop;
        public UNT UNT;
    }
}
