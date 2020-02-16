namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CTA_CONDRA
    {
        public CTA_9 CTA;
        public List<COM_2> COM;
    }
    public class Loop_EFI_CONDRA
    {
        public EFI EFI;
        public List<CED> CED;
        public List<RFF_2> RFF;
        public List<DTM_16> DTM;
        public List<QTY_16> QTY;
    }
    public class Loop_NAD_CONDRA
    {
        public NAD_33 NAD;
        public List<Loop_CTA_CONDRA> CTALoop;
    }
    public class Loop_RFF_CONDRA
    {
        public RFF_2 RFF;
    }
    public class TSCONDRA 
    {
        public UNH UNH;
        public BGM_6 BGM;
        public List<DTM_16> DTM;
        public List<Loop_RFF_CONDRA> RFFLoop;
        public List<Loop_NAD_CONDRA> NADLoop;
        public List<Loop_EFI_CONDRA> EFILoop;
        public UNT UNT;
    }
}
