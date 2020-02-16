namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CNI_IFTSTA
    {
        public CNI_2 CNI;
        public List<Loop_STS_IFTSTA> STSLoop;
    }
    public class Loop_GID_IFTSTA
    {
        public GID_3 GID;
        public List<Loop_PCI_IFTSTA> PCILoop;
    }
    public class Loop_NAD_IFTSTA
    {
        public NAD_36 NAD;
    }
    public class Loop_PCI_IFTSTA
    {
        public PCI_6 PCI;
        public List<GIN_2> GIN;
    }
    public class Loop_RFF_IFTSTA
    {
        public RFF_37 RFF;
    }
    public class Loop_STS_IFTSTA
    {
        public STS_3 STS;
        public List<RFF_37> RFF;
        public List<DTM_43> DTM;
        public List<FTX_21> FTX;
        public List<NAD_27> NAD;
        public LOC_22 LOC;
        public List<Loop_GID_IFTSTA> GIDLoop;
    }
    public class TSIFTSTA 
    {
        public UNH UNH;
        public BGM_19 BGM;
        public List<DTM_43> DTM;
        public List<Loop_NAD_IFTSTA> NADLoop;
        public List<Loop_RFF_IFTSTA> RFFLoop;
        public List<FTX_21> FTX;
        public List<Loop_CNI_IFTSTA> CNILoop;
        public UNT UNT;
    }
}
