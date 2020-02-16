namespace EdiNation.Edifact.EAND01B.S4
{
    using System.Collections.Generic;
    public class Loop_CTA_PAYDUC
    {
        public CTA_9 CTA;
        public COM_3 COM;
    }
    public class Loop_DTM_PAYDUC
    {
        public DTM_36 DTM;
        public Loop_UGH_PAYDUC UGHLoop;
    }
    public class Loop_GIS_PAYDUC
    {
        public GIS_3 GIS;
        public RFF_3 RFF;
        public List<MOA_17> MOA;
        public BUS_3 BUS;
        public List<Loop_DTM_PAYDUC> DTMLoop;
    }
    public class Loop_NAD_PAYDUC
    {
        public NAD_25 NAD;
        public List<Loop_CTA_PAYDUC> CTALoop;
    }
    public class Loop_NAD_PAYDUC_2
    {
        public NAD_25 NAD;
        public List<RFF_3> RFF;
        public List<MOA_17> MOA;
        public List<AJT_6> AJT;
        public List<FTX_21> FTX;
    }
    public class Loop_RFF_PAYDUC
    {
        public RFF_3 RFF;
        public DTM_36 DTM;
    }
    public class Loop_UGH_PAYDUC
    {
        public UGH UGH;
        public List<Loop_NAD_PAYDUC_2> NADLoop;
        public UGT UGT;
    }
    public class TSPAYDUC 
    {
        public UNH UNH;
        public BGM_32 BGM;
        public PAI_11 PAI;
        public List<FII_13> FII;
        public List<DTM_36> DTM;
        public List<FTX_21> FTX;
        public List<Loop_RFF_PAYDUC> RFFLoop;
        public List<Loop_NAD_PAYDUC> NADLoop;
        public List<Loop_GIS_PAYDUC> GISLoop;
        public UNS UNS;
        public MOA_17 MOA;
        public UNT UNT;
    }
}
