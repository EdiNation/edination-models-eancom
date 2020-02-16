namespace EdiNation.Edifact.EAND96A
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
        public LOC_13 LOC;
    }
    public class Loop_NAD_IFTMBC
    {
        public NAD_35 NAD;
    }
    public class Loop_RFF_IFTMBC
    {
        public RFF_18 RFF;
        public List<DTM_27> DTM;
    }
    public class Loop_RFF_IFTMBC_2
    {
        public RFF_18 RFF;
    }
    public class Loop_TDT_IFTMBC
    {
        public TDT_9 TDT;
        public List<DTM_27> DTM;
        public List<Loop_LOC_IFTMBC> LOCLoop;
    }
    public class TSIFTMBC 
    {
        public UNH UNH;
        public BGM_16 BGM;
        public List<DTM_27> DTM;
        public List<FTX_4> FTX;
        public List<Loop_RFF_IFTMBC> RFFLoop;
        public List<Loop_TDT_IFTMBC> TDTLoop;
        public List<Loop_NAD_IFTMBC> NADLoop;
        public List<Loop_GID_IFTMBC> GIDLoop;
        public UNT UNT;
    }
}
