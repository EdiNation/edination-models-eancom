namespace EdiNation.Edifact.EAND01B.S3
{
    using System.Collections.Generic;
    public class Loop_GID_IFTMBC
    {
        public GID_2 GID;
        public List<FTX_4> FTX;
        public List<Loop_RFF_IFTMBC_2> RFFLoop;
    }
    public class Loop_LOC_IFTMBC
    {
        public LOC_16 LOC;
    }
    public class Loop_NAD_IFTMBC
    {
        public NAD_35 NAD;
    }
    public class Loop_RFF_IFTMBC
    {
        public RFF_19 RFF;
        public List<DTM_30> DTM;
    }
    public class Loop_RFF_IFTMBC_2
    {
        public RFF_19 RFF;
    }
    public class Loop_TDT_IFTMBC
    {
        public TDT_2 TDT;
        public List<DTM_30> DTM;
        public List<Loop_LOC_IFTMBC> LOCLoop;
    }
    public class TSIFTMBC 
    {
        public UNH UNH;
        public BGM_18 BGM;
        public List<DTM_30> DTM;
        public List<FTX_4> FTX;
        public List<Loop_RFF_IFTMBC> RFFLoop;
        public List<Loop_TDT_IFTMBC> TDTLoop;
        public List<Loop_NAD_IFTMBC> NADLoop;
        public List<Loop_GID_IFTMBC> GIDLoop;
        public UNT UNT;
    }
}
