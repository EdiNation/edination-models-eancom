namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_AJT_COMDIS
    {
        public AJT AJT;
        public List<FTX_9> FTX;
    }
    public class Loop_DLI_COMDIS
    {
        public DLI DLI;
        public List<MOA_6> MOA;
        public List<Loop_AJT_COMDIS> AJTLoop;
    }
    public class Loop_DOC_COMDIS
    {
        public DOC_6 DOC;
        public List<DTM_11> DTM;
        public List<MOA_6> MOA;
        public List<Loop_AJT_COMDIS> AJTLoop;
        public List<Loop_INP_COMDIS> INPLoop;
        public List<Loop_DLI_COMDIS> DLILoop;
    }
    public class Loop_INP_COMDIS
    {
        public INP_3 INP;
        public List<FTX_9> FTX;
    }
    public class Loop_NAD_COMDIS
    {
        public NAD_32 NAD;
        public CTA_10 CTA;
        public List<COM> COM;
    }
    public class TSCOMDIS 
    {
        public UNH UNH;
        public BGM_5 BGM;
        public List<RFF_45> RFF;
        public List<DTM_11> DTM;
        public List<Loop_NAD_COMDIS> NADLoop;
        public List<Loop_DOC_COMDIS> DOCLoop;
        public UNT UNT;
    }
}
