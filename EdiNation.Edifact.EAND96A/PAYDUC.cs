namespace EdiNation.Edifact.EAND96A
{
    using System.Collections.Generic;
    public class Loop_CTA_PAYDUC
    {
        public CTA_9 CTA;
        public COM_3 COM;
    }
    public class Loop_DTM_PAYDUC
    {
        public DTM_34 DTM;
        public List<Loop_NAD_PAYDUC_2> NADLoop;
    }
    public class Loop_GIS_PAYDUC
    {
        public GIS_3 GIS;
        public RFF_3 RFF;
        public List<MOA_11> MOA;
        public BUS_4 BUS;
        public List<Loop_DTM_PAYDUC> DTMLoop;
    }
    public class Loop_NAD_PAYDUC
    {
        public NAD_21 NAD;
        public List<Loop_CTA_PAYDUC> CTALoop;
    }
    public class Loop_NAD_PAYDUC_2
    {
        public NAD_21 NAD;
        public List<RFF_3> RFF;
        public List<MOA_11> MOA;
        public AJT_5 AJT;
        public List<FTX_19> FTX;
    }
    public class Loop_RFF_PAYDUC
    {
        public RFF_3 RFF;
        public DTM_34 DTM;
    }
    public class TSPAYDUC 
    {
        public UNH UNH;
        public BGM_30 BGM;
        public PAI_9 PAI;
        public List<FII_10> FII;
        public List<DTM_34> DTM;
        public List<FTX_19> FTX;
        public List<Loop_RFF_PAYDUC> RFFLoop;
        public List<Loop_NAD_PAYDUC> NADLoop;
        public List<Loop_GIS_PAYDUC> GISLoop;
        public UNS UNS;
        public MOA_11 MOA;
        public UNT UNT;
    }
}
