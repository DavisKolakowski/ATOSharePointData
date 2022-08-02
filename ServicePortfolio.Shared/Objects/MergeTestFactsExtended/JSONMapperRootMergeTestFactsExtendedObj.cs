using Newtonsoft.Json; 
namespace ServicePortfolio.Shared.Objects.MergeTestFactsExtended{ 

    public class JSONMapperRootMergeTestFactsExtendedObj
    {
        [JsonProperty("reference_num")]
        public string ReferenceNum { get; set; } = String.Empty;

        [JsonProperty("PI Planning ")]
        public PIPlanningObj PIPlanning { get; set; } = new PIPlanningObj();

        [JsonProperty("Contributing Teams")]
        public ContributingTeamsObj ContributingTeams { get; set; } = new ContributingTeamsObj();

        [JsonProperty("Sprint #")]
        public SprintObj Sprint { get; set; } = new SprintObj();

        [JsonProperty("Resource Impact")]
        public ResourceImpactObj ResourceImpact { get; set; } = new ResourceImpactObj();

        [JsonProperty("Orange Crush ART")]
        public OrangeCrushARTObj OrangeCrushART { get; set; } = new OrangeCrushARTObj();

        [JsonProperty("Benefit hypothesis")]
        public BenefitHypothesisObj BenefitHypothesis { get; set; } = new BenefitHypothesisObj();

        [JsonProperty("Acceptance criteria")]
        public AcceptanceCriteriaObj AcceptanceCriteria { get; set; } = new AcceptanceCriteriaObj();

        [JsonProperty("Impact of not completing")]
        public ImpactOfNotCompletingObj ImpactOfNotCompleting { get; set; } = new ImpactOfNotCompletingObj();

        [JsonProperty("External Ticket ID")]
        public ExternalTicketIDObj ExternalTicketID { get; set; } = new ExternalTicketIDObj();

        [JsonProperty("Commitment")]
        public CommitmentObj Commitment { get; set; } = new CommitmentObj();

        [JsonProperty("Date Requested")]
        public DateRequestedObj DateRequested { get; set; } = new DateRequestedObj();

        [JsonProperty("Business Value")]
        public BusinessValueObj BusinessValue { get; set; } = new BusinessValueObj();

        [JsonProperty("Time Criticality")]
        public TimeCriticalityObj TimeCriticality { get; set; } = new TimeCriticalityObj();

        [JsonProperty("Risk Reduction/Opportunity Enablement")]
        public RiskReductionOpportunityEnablementObj RiskReductionOpportunityEnablement { get; set; } = new RiskReductionOpportunityEnablementObj();

        [JsonProperty("Job Size/Duration")]
        public JobSizeDurationObj JobSizeDuration { get; set; } = new JobSizeDurationObj();

        [JsonProperty("FW Story")]
        public FWStoryObj FWStory { get; set; } = new FWStoryObj();

        [JsonProperty("Business Owners")]
        public BusinessOwnersObj BusinessOwners { get; set; } = new BusinessOwnersObj();

        [JsonProperty("OC_P2_2020")]
        public OCP22020Obj OCP22020 { get; set; } = new OCP22020Obj();

        [JsonProperty("Purple Rain ART")]
        public PurpleRainARTObj PurpleRainART { get; set; } = new PurpleRainARTObj();

        public ProjectObj Project { get; set; } = new ProjectObj();

        [JsonProperty("Stack Rank")]
        public StackRankObj StackRank { get; set; } = new StackRankObj();

        [JsonProperty("FreeWheel MRM")]
        public FreeWheelMRMObj FreeWheelMRM { get; set; } = new FreeWheelMRMObj();

        [JsonProperty("P2_2021")]
        public P22021Obj P22021 { get; set; } = new P22021Obj();

        [JsonProperty("P3_2020")]
        public P32020Obj P32020 { get; set; } = new P32020Obj();

        [JsonProperty("Command Center")]
        public CommandCenterObj CommandCenter { get; set; } = new CommandCenterObj();

        public VDEObj VDE { get; set; } = new VDEObj();

        [JsonProperty("Feature size")]
        public FeatureSizeObj FeatureSize { get; set; } = new FeatureSizeObj();

        [JsonProperty("Estimated date of completion")]
        public EstimatedDateOfCompletionObj EstimatedDateOfCompletion { get; set; } = new EstimatedDateOfCompletionObj();

        public EnablerObj Enabler { get; set; } = new EnablerObj();

        [JsonProperty("OC_P1_2020")]
        public OCP12020Obj OCP12020 { get; set; } = new OCP12020Obj();

        [JsonProperty("Requesting Entity")]
        public RequestingEntityObj RequestingEntity { get; set; } = new RequestingEntityObj();

        [JsonProperty("ATO - AQC")]
        public ATOAQCObj ATOAQC { get; set; } = new ATOAQCObj();

        [JsonProperty("P4_2020")]
        public P42020Obj P42020 { get; set; } = new P42020Obj();

        [JsonProperty("P5_2020")]
        public P52020Obj P52020 { get; set; } = new P52020Obj();

        [JsonProperty("PI1_2022")]
        public PI12022Obj PI12022 { get; set; } = new PI12022Obj();

        [JsonProperty("P1_2021")]
        public P12021Obj P12021 { get; set; } = new P12021Obj();

        public DepartmentObj Department { get; set; } = new DepartmentObj();

        [JsonProperty("A1 Risk mitigation")]
        public A1RiskMitigationObj A1RiskMitigation { get; set; } = new A1RiskMitigationObj();

        [JsonProperty("Self-Service Portal")]
        public SelfServicePortalObj SelfServicePortal { get; set; } = new SelfServicePortalObj();

        [JsonProperty("Unified Planning")]
        public UnifiedPlanningObj UnifiedPlanning { get; set; } = new UnifiedPlanningObj();

        [JsonProperty("Schedule Revamp")]
        public ScheduleRevampObj ScheduleRevamp { get; set; } = new ScheduleRevampObj();

        public UniMonObj UniMon { get; set; } = new UniMonObj();

        [JsonProperty("A3 Unlock opportunity")]
        public A3UnlockOpportunityObj A3UnlockOpportunity { get; set; } = new A3UnlockOpportunityObj();

        [JsonProperty("A2 Clean fuel")]
        public A2CleanFuelObj A2CleanFuel { get; set; } = new A2CleanFuelObj();

        [JsonProperty("Full Avail")]
        public FullAvailObj FullAvail { get; set; } = new FullAvailObj();

        public MarketingObj Marketing { get; set; } = new MarketingObj();

        public SalesObj Sales { get; set; } = new SalesObj();

        [JsonProperty("Split Avail")]
        public SplitAvailObj SplitAvail { get; set; } = new SplitAvailObj();

        [JsonProperty("Partner and Content")]
        public PartnerAndContentObj PartnerAndContent { get; set; } = new PartnerAndContentObj();

        [JsonProperty("Unified Addressable")]
        public UnifiedAddressableObj UnifiedAddressable { get; set; } = new UnifiedAddressableObj();

        public CCSObj CCS { get; set; } = new CCSObj();

        [JsonProperty("FW Epic")]
        public FWEpicObj FWEpic { get; set; } = new FWEpicObj();

        public OneCONNECTObj OneCONNECT { get; set; } = new OneCONNECTObj();

        [JsonProperty("Release Name")]
        public ReleaseNameObj ReleaseName { get; set; } = new ReleaseNameObj();

        [JsonProperty("Release Date")]
        public ReleaseDateObj ReleaseDate { get; set; } = new ReleaseDateObj();

        [JsonProperty("FW Tech Debt")]
        public FWTechDebtObj FWTechDebt { get; set; } = new FWTechDebtObj();

        public AutomationObj Automation { get; set; } = new AutomationObj();

        [JsonProperty("Tech Debt")]
        public TechDebtObj TechDebt { get; set; } = new TechDebtObj();

        public SMBOObj SMBO { get; set; } = new SMBOObj();

        public PlaceholderObj Placeholder { get; set; } = new PlaceholderObj();

        [JsonProperty("FreeWheel MVPD")]
        public FreeWheelMVPDObj FreeWheelMVPD { get; set; } = new FreeWheelMVPDObj();

        [JsonProperty("FW Bug")]
        public FWBugObj FWBug { get; set; } = new FWBugObj();

        [JsonProperty("Requested by:")]
        public RequestedByObj RequestedBy { get; set; } = new RequestedByObj();

        [JsonProperty("Requested for:")]
        public RequestedForObj RequestedFor { get; set; } = new RequestedForObj();

        public OneTIMObj OneTIM { get; set; } = new OneTIMObj();

        [JsonProperty("Jetway Efforts")]
        public JetwayEffortsObj JetwayEfforts { get; set; } = new JetwayEffortsObj();

        [JsonProperty("Box.com")]
        public BoxComObj BoxCom { get; set; } = new BoxComObj();

        public ReviewagainObj Reviewagain { get; set; } = new ReviewagainObj();

        [JsonProperty("VDE_MVP")]
        public VDEMVPObj VDEMVP { get; set; } = new VDEMVPObj();

        [JsonProperty("ATO - CQC")]
        public ATOCQCObj ATOCQC { get; set; } = new ATOCQCObj();

        public GramObj Gram { get; set; } = new GramObj();

        public LSAObj LSA { get; set; } = new LSAObj();

        [JsonProperty("Feature eNPS Elevation ID")]
        public FeatureENPSElevationIDObj FeatureENPSElevationID { get; set; } = new FeatureENPSElevationIDObj();

        public ENPSObj ENPS { get; set; } = new ENPSObj();

        [JsonProperty("Ampersand (NCC)")]
        public AmpersandNCCObj AmpersandNCC { get; set; } = new AmpersandNCCObj();

        [JsonProperty("FW Discovery")]
        public FWDiscoveryObj FWDiscovery { get; set; } = new FWDiscoveryObj();

        [JsonProperty("Discovery/Design Needed")]
        public DiscoveryDesignNeededObj DiscoveryDesignNeeded { get; set; } = new DiscoveryDesignNeededObj();

        public CarryoverObj Carryover { get; set; } = new CarryoverObj();

        [JsonProperty("PI2_2021")]
        public PI22021Obj PI22021 { get; set; } = new PI22021Obj();

        [JsonProperty("PI3_2021")]
        public PI32021Obj PI32021 { get; set; } = new PI32021Obj();

        public ComplianceObj Compliance { get; set; } = new ComplianceObj();

        [JsonProperty("Cost of Delay")]
        public CostOfDelayObj CostOfDelay { get; set; } = new CostOfDelayObj();

        public CreativeConflictsObj CreativeConflicts { get; set; } = new CreativeConflictsObj();

        [JsonProperty("PI4_2021")]
        public PI42021Obj PI42021 { get; set; } = new PI42021Obj();

        [JsonProperty("PI5_2021")]
        public PI52021Obj PI52021 { get; set; } = new PI52021Obj();

        public LinearADInsertionsObj LinearADInsertions { get; set; } = new LinearADInsertionsObj();

        [JsonProperty("Tag for Self Service")]
        public TagForSelfServiceObj TagForSelfService { get; set; } = new TagForSelfServiceObj();

        public FMLAObj FMLA { get; set; } = new FMLAObj();

        [JsonProperty("pi3_2022")]
        public Pi32022Obj Pi32022 { get; set; } = new Pi32022Obj();

        [JsonProperty("ATP Exit")]
        public ATPExitObj ATPExit { get; set; } = new ATPExitObj();

        [JsonProperty("FW 7.4.0")]
        public FW740Obj FW740 { get; set; } = new FW740Obj();

        [JsonProperty("ATO - EQA")]
        public ATOEQAObj ATOEQA { get; set; } = new ATOEQAObj();

        [JsonProperty("FW 7.1.0")]
        public FW710Obj FW710 { get; set; } = new FW710Obj();

        [JsonProperty("P4_2021")]
        public P42021Obj P42021 { get; set; } = new P42021Obj();

        [JsonProperty("Fundamental Application Change")]
        public FundamentalApplicationChangeObj FundamentalApplicationChange { get; set; } = new FundamentalApplicationChangeObj();

        [JsonProperty("p3_2021")]
        public P32021Obj P32021 { get; set; } = new P32021Obj();

        public GRCObj GRC { get; set; } = new GRCObj();

        [JsonProperty("PI2_2022")]
        public PI22022Obj PI22022 { get; set; } = new PI22022Obj();

        [JsonProperty("Effectv Platform")]
        public EffectvPlatformObj EffectvPlatform { get; set; } = new EffectvPlatformObj();

        [JsonProperty("ATO - Aspera")]
        public ATOAsperaObj ATOAspera { get; set; } = new ATOAsperaObj();

        [JsonProperty("FW Jira")]
        public FWJiraObj FWJira { get; set; } = new FWJiraObj();

        [JsonProperty("CT 2.0")]
        public CT20Obj CT20 { get; set; } = new CT20Obj();

        [JsonProperty("Forecasting & Order Mgmt")]
        public ForecastingOrderMgmtObj ForecastingOrderMgmt { get; set; } = new ForecastingOrderMgmtObj();

        [JsonProperty("FW Task")]
        public FWTaskObj FWTask { get; set; } = new FWTaskObj();

        [JsonProperty("PR/Marketing")]
        public PRMarketingObj PRMarketing { get; set; } = new PRMarketingObj();

        [JsonProperty("Retention of customers")]
        public RetentionOfCustomersObj RetentionOfCustomers { get; set; } = new RetentionOfCustomersObj();

        [JsonProperty("Operational efficiencies")]
        public OperationalEfficienciesObj OperationalEfficiencies { get; set; } = new OperationalEfficienciesObj();

        [JsonProperty("Effort to develop (subtracted)")]
        public EffortToDevelopSubtractedObj EffortToDevelopSubtracted { get; set; } = new EffortToDevelopSubtractedObj();

        [JsonProperty("Sales increase")]
        public SalesIncreaseObj SalesIncrease { get; set; } = new SalesIncreaseObj();

        [JsonProperty("Creative Management, Digital and Addressable")]
        public CreativeManagementDigitalAndAddressableObj CreativeManagementDigitalAndAddressable { get; set; } = new CreativeManagementDigitalAndAddressableObj();

        [JsonProperty("FSB Dep.")]
        public FSBDepObj FSBDep { get; set; } = new FSBDepObj();

        [JsonProperty("xG ticket #")]
        public XGTicketObj XGTicket { get; set; } = new XGTicketObj();

        [JsonProperty("FW 7.3.0")]
        public FW730Obj FW730 { get; set; } = new FW730Obj();

        [JsonProperty("Enterprise Execution and Finance/Billing")]
        public EnterpriseExecutionAndFinanceBillingObj EnterpriseExecutionAndFinanceBilling { get; set; } = new EnterpriseExecutionAndFinanceBillingObj();

        [JsonProperty("ATO - CSM")]
        public ATOCSMObj ATOCSM { get; set; } = new ATOCSMObj();

        [JsonProperty("Follow-Up")]
        public FollowUpObj FollowUp { get; set; } = new FollowUpObj();

        [JsonProperty("FW Spike")]
        public FWSpikeObj FWSpike { get; set; } = new FWSpikeObj();

        [JsonProperty("PI4_2022")]
        public PI42022Obj PI42022 { get; set; } = new PI42022Obj();

        [JsonProperty("Marketing Transformation")]
        public MarketingTransformationObj MarketingTransformation { get; set; } = new MarketingTransformationObj();

        [JsonProperty("FW 7.2.0")]
        public FW720Obj FW720 { get; set; } = new FW720Obj();

        [JsonProperty("FW 7.1.1")]
        public FW711Obj FW711 { get; set; } = new FW711Obj();

        [JsonProperty("OneTIM API")]
        public OneTIMAPIObj OneTIMAPI { get; set; } = new OneTIMAPIObj();

        public RMHObj RMH { get; set; } = new RMHObj();

        [JsonProperty("Target Quarter")]
        public TargetQuarterObj TargetQuarter { get; set; } = new TargetQuarterObj();

        [JsonProperty("JIRA ticket #")]
        public JIRATicketObj JIRATicket { get; set; } = new JIRATicketObj();

        public PriorityObj Priority { get; set; } = new PriorityObj();

        public ThresholdsObj Thresholds { get; set; } = new ThresholdsObj();

        [JsonProperty("FW Parity")]
        public FWParityObj FWParity { get; set; } = new FWParityObj();

        [JsonProperty("FW Initiative")]
        public FWInitiativeObj FWInitiative { get; set; } = new FWInitiativeObj();

        [JsonProperty("FW Design")]
        public FWDesignObj FWDesign { get; set; } = new FWDesignObj();
    }

}