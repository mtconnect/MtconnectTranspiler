using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Contracts.Navigation
{
    /// <summary>
    /// A class containing the navigational tree for <see cref="UmlPackage"/>s in the XMI document.
    /// </summary>
    public class ModelNavigation
    {
        private ProfileNavigation? _Profile;
        /// <summary>
        /// <inheritdoc cref="Profile" /> to <c>Profile</c>
        /// </summary>
        public ProfileNavigation Profile => _Profile ??= new ProfileNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Profile</c>
        /// </summary>
        public class ProfileNavigation : NavigationItem
        {
            private NavigationItem? _DataTypes;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>DataTypes</c>
            /// </summary>
            public NavigationItem DataTypes => _DataTypes ??= (this, "DataTypes");


            private NavigationItem? _Stereotypes;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Stereotypes</c>
            /// </summary>
            public NavigationItem Stereotypes => _Stereotypes ??= (this, "Stereotypes");



            /// <summary>
            /// Constructs a new <see cref="ProfileNavigation" /> navigation tree.
            /// </summary>
            public ProfileNavigation() : base("Profile") { }
        }

        private AssetInformationModelNavigation? _AssetInformationModel;
        /// <summary>
        /// <inheritdoc cref="AssetInformationModel" /> to <c>Asset Information Model</c>
        /// </summary>
        public AssetInformationModelNavigation AssetInformationModel => _AssetInformationModel ??= new AssetInformationModelNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Asset Information Model</c>
        /// </summary>
        public class AssetInformationModelNavigation : NavigationItem
        {
            private CuttingToolNavigation? _CuttingTool;
            /// <summary>
            /// <inheritdoc cref="CuttingTool" /> to <c>Cutting Tool</c>
            /// </summary>
            public CuttingToolNavigation CuttingTool => _CuttingTool ??= new CuttingToolNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Cutting Tool</c>
            /// </summary>
            public class CuttingToolNavigation : NavigationItem
            {
                private CuttingItemNavigation? _CuttingItem;
                /// <summary>
                /// <inheritdoc cref="CuttingItem" /> to <c>Cutting Item</c>
                /// </summary>
                public CuttingItemNavigation CuttingItem => _CuttingItem ??= new CuttingItemNavigation(this);
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Cutting Item</c>
                /// </summary>
                public class CuttingItemNavigation : NavigationItem
                {
                    private NavigationItem? _CuttingItemMeasurementSubtypes;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Cutting Item Measurement Subtypes</c>
                    /// </summary>
                    public NavigationItem CuttingItemMeasurementSubtypes => _CuttingItemMeasurementSubtypes ??= (this, "Cutting Item Measurement Subtypes");



                    /// <summary>
                    /// Constructs a new <see cref="CuttingItemNavigation" /> navigation tree.
                    /// </summary>
                    /// <param name="parent">Reference to the parent branch <see cref="CuttingToolNavigation"/></param>
                    public CuttingItemNavigation(CuttingToolNavigation parent) : base("Cutting Item", parent) { }
                }

                private NavigationItem? _CuttingToolMeasurementSubtypes;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Cutting Tool Measurement Subtypes</c>
                /// </summary>
                public NavigationItem CuttingToolMeasurementSubtypes => _CuttingToolMeasurementSubtypes ??= (this, "Cutting Tool Measurement Subtypes");


                private NavigationItem? _CuttingToolLifeCycle;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Cutting Tool Life Cycle</c>
                /// </summary>
                public NavigationItem CuttingToolLifeCycle => _CuttingToolLifeCycle ??= (this, "Cutting Tool Life Cycle");



                /// <summary>
                /// Constructs a new <see cref="CuttingToolNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="AssetInformationModelNavigation"/></param>
                public CuttingToolNavigation(AssetInformationModelNavigation parent) : base("Cutting Tool", parent) { }
            }

            private NavigationItem? _Files;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Files</c>
            /// </summary>
            public NavigationItem Files => _Files ??= (this, "Files");


            private NavigationItem? _RawMaterial;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Raw Material</c>
            /// </summary>
            public NavigationItem RawMaterial => _RawMaterial ??= (this, "Raw Material");


            private NavigationItem? _QIF;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>QIF</c>
            /// </summary>
            public NavigationItem QIF => _QIF ??= (this, "QIF");


            private NavigationItem? _ComponentConfigurationParameters;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Component Configuration Parameters</c>
            /// </summary>
            public NavigationItem ComponentConfigurationParameters => _ComponentConfigurationParameters ??= (this, "Component Configuration Parameters");



            /// <summary>
            /// Constructs a new <see cref="AssetInformationModelNavigation" /> navigation tree.
            /// </summary>
            public AssetInformationModelNavigation() : base("Asset Information Model") { }
        }

        private FundamentalsNavigation? _Fundamentals;
        /// <summary>
        /// <inheritdoc cref="Fundamentals" /> to <c>Fundamentals</c>
        /// </summary>
        public FundamentalsNavigation Fundamentals => _Fundamentals ??= new FundamentalsNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Fundamentals</c>
        /// </summary>
        public class FundamentalsNavigation : NavigationItem
        {
            private MTConnectProtocolNavigation? _MTConnectProtocol;
            /// <summary>
            /// <inheritdoc cref="MTConnectProtocol" /> to <c>MTConnect Protocol</c>
            /// </summary>
            public MTConnectProtocolNavigation MTConnectProtocol => _MTConnectProtocol ??= new MTConnectProtocolNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>MTConnect Protocol</c>
            /// </summary>
            public class MTConnectProtocolNavigation : NavigationItem
            {
                private NavigationItem? _MTConnectAssetsResponseDocument;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>MTConnectAssets Response Document</c>
                /// </summary>
                public NavigationItem MTConnectAssetsResponseDocument => _MTConnectAssetsResponseDocument ??= (this, "MTConnectAssets Response Document");


                private NavigationItem? _MTConnectDevicesResponseDocument;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>MTConnectDevices Response Document</c>
                /// </summary>
                public NavigationItem MTConnectDevicesResponseDocument => _MTConnectDevicesResponseDocument ??= (this, "MTConnectDevices Response Document");


                private NavigationItem? _MTConnectStreamsResponseDocument;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>MTConnectStreams Response Document</c>
                /// </summary>
                public NavigationItem MTConnectStreamsResponseDocument => _MTConnectStreamsResponseDocument ??= (this, "MTConnectStreams Response Document");


                private NavigationItem? _MTConnectErrorsResponseDocument;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>MTConnectErrors Response Document</c>
                /// </summary>
                public NavigationItem MTConnectErrorsResponseDocument => _MTConnectErrorsResponseDocument ??= (this, "MTConnectErrors Response Document");


                private NavigationItem? _RESTProtocol;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>REST Protocol</c>
                /// </summary>
                public NavigationItem RESTProtocol => _RESTProtocol ??= (this, "REST Protocol");



                /// <summary>
                /// Constructs a new <see cref="MTConnectProtocolNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="FundamentalsNavigation"/></param>
                public MTConnectProtocolNavigation(FundamentalsNavigation parent) : base("MTConnect Protocol", parent) { }
            }


            /// <summary>
            /// Constructs a new <see cref="FundamentalsNavigation" /> navigation tree.
            /// </summary>
            public FundamentalsNavigation() : base("Fundamentals") { }
        }

        private ObservationInformationModelNavigation? _ObservationInformationModel;
        /// <summary>
        /// <inheritdoc cref="ObservationInformationModel" /> to <c>Observation Information Model</c>
        /// </summary>
        public ObservationInformationModelNavigation ObservationInformationModel => _ObservationInformationModel ??= new ObservationInformationModelNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Observation Information Model</c>
        /// </summary>
        public class ObservationInformationModelNavigation : NavigationItem
        {
            private NavigationItem? _Representations;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Representations</c>
            /// </summary>
            public NavigationItem Representations => _Representations ??= (this, "Representations");


            private ObservationTypesNavigation? _ObservationTypes;
            /// <summary>
            /// <inheritdoc cref="ObservationTypes" /> to <c>Observation Types</c>
            /// </summary>
            public ObservationTypesNavigation ObservationTypes => _ObservationTypes ??= new ObservationTypesNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Observation Types</c>
            /// </summary>
            public class ObservationTypesNavigation : NavigationItem
            {
                private NavigationItem? _SampleTypes;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Sample Types</c>
                /// </summary>
                public NavigationItem SampleTypes => _SampleTypes ??= (this, "Sample Types");


                private NavigationItem? _EventTypes;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Event Types</c>
                /// </summary>
                public NavigationItem EventTypes => _EventTypes ??= (this, "Event Types");


                private NavigationItem? _ConditionTypes;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Condition Types</c>
                /// </summary>
                public NavigationItem ConditionTypes => _ConditionTypes ??= (this, "Condition Types");



                /// <summary>
                /// Constructs a new <see cref="ObservationTypesNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="ObservationInformationModelNavigation"/></param>
                public ObservationTypesNavigation(ObservationInformationModelNavigation parent) : base("Observation Types", parent) { }
            }


            /// <summary>
            /// Constructs a new <see cref="ObservationInformationModelNavigation" /> navigation tree.
            /// </summary>
            public ObservationInformationModelNavigation() : base("Observation Information Model") { }
        }

        private GlossaryNavigation? _Glossary;
        /// <summary>
        /// <inheritdoc cref="Glossary" /> to <c>Glossary</c>
        /// </summary>
        public GlossaryNavigation Glossary => _Glossary ??= new GlossaryNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Glossary</c>
        /// </summary>
        public class GlossaryNavigation : NavigationItem
        {
            private NavigationItem? _XMLTerms;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>XML Terms</c>
            /// </summary>
            public NavigationItem XMLTerms => _XMLTerms ??= (this, "XML Terms");


            private NavigationItem? _HTTPTerms;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>HTTP Terms</c>
            /// </summary>
            public NavigationItem HTTPTerms => _HTTPTerms ??= (this, "HTTP Terms");


            private MTConnectTermsNavigation? _MTConnectTerms;
            /// <summary>
            /// <inheritdoc cref="MTConnectTerms" /> to <c>MTConnect Terms</c>
            /// </summary>
            public MTConnectTermsNavigation MTConnectTerms => _MTConnectTerms ??= new MTConnectTermsNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>MTConnect Terms</c>
            /// </summary>
            public class MTConnectTermsNavigation : NavigationItem
            {
                private NavigationItem? _AdditionalObservationTerms;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Additional Observation Terms</c>
                /// </summary>
                public NavigationItem AdditionalObservationTerms => _AdditionalObservationTerms ??= (this, "Additional Observation Terms");



                /// <summary>
                /// Constructs a new <see cref="MTConnectTermsNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="GlossaryNavigation"/></param>
                public MTConnectTermsNavigation(GlossaryNavigation parent) : base("MTConnect Terms", parent) { }
            }

            private NavigationItem? _InformationModelTerms;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Information Model Terms</c>
            /// </summary>
            public NavigationItem InformationModelTerms => _InformationModelTerms ??= (this, "Information Model Terms");


            private NavigationItem? _ProtocolTerms;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Protocol Terms</c>
            /// </summary>
            public NavigationItem ProtocolTerms => _ProtocolTerms ??= (this, "Protocol Terms");


            private NavigationItem? _IndustrialTerms;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Industrial Terms</c>
            /// </summary>
            public NavigationItem IndustrialTerms => _IndustrialTerms ??= (this, "Industrial Terms");



            /// <summary>
            /// Constructs a new <see cref="GlossaryNavigation" /> navigation tree.
            /// </summary>
            public GlossaryNavigation() : base("Glossary") { }
        }

        private AgentArchitectureNavigation? _AgentArchitecture;
        /// <summary>
        /// <inheritdoc cref="AgentArchitecture" /> to <c>Agent Architecture</c>
        /// </summary>
        public AgentArchitectureNavigation AgentArchitecture => _AgentArchitecture ??= new AgentArchitectureNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Agent Architecture</c>
        /// </summary>
        public class AgentArchitectureNavigation : NavigationItem
        {
            private RestNavigation? _Rest;
            /// <summary>
            /// <inheritdoc cref="Rest" /> to <c>Rest</c>
            /// </summary>
            public RestNavigation Rest => _Rest ??= new RestNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Rest</c>
            /// </summary>
            public class RestNavigation : NavigationItem
            {
                private NavigationItem? _Storage;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Storage</c>
                /// </summary>
                public NavigationItem Storage => _Storage ??= (this, "Storage");



                /// <summary>
                /// Constructs a new <see cref="RestNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="AgentArchitectureNavigation"/></param>
                public RestNavigation(AgentArchitectureNavigation parent) : base("Rest", parent) { }
            }

            private NavigationItem? _Source;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Source</c>
            /// </summary>
            public NavigationItem Source => _Source ??= (this, "Source");


            private NavigationItem? _Sink;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Sink</c>
            /// </summary>
            public NavigationItem Sink => _Sink ??= (this, "Sink");


            private NavigationItem? _Transformation;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Transformation</c>
            /// </summary>
            public NavigationItem Transformation => _Transformation ??= (this, "Transformation");


            private NavigationItem? _Printer;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Printer</c>
            /// </summary>
            public NavigationItem Printer => _Printer ??= (this, "Printer");


            private NavigationItem? _Parser;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Parser</c>
            /// </summary>
            public NavigationItem Parser => _Parser ??= (this, "Parser");


            private NavigationItem? _InformationModel;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>InformationModel</c>
            /// </summary>
            public NavigationItem InformationModel => _InformationModel ??= (this, "InformationModel");


            private NavigationItem? _Pipelines;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Pipelines</c>
            /// </summary>
            public NavigationItem Pipelines => _Pipelines ??= (this, "Pipelines");



            /// <summary>
            /// Constructs a new <see cref="AgentArchitectureNavigation" /> navigation tree.
            /// </summary>
            public AgentArchitectureNavigation() : base("Agent Architecture") { }
        }

        private NavigationItem? _DevelopmentProcess;
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Development Process</c>
        /// </summary>
        public NavigationItem DevelopmentProcess => _DevelopmentProcess ??= "Development Process";


        private SupportingDocumentsNavigation? _SupportingDocuments;
        /// <summary>
        /// <inheritdoc cref="SupportingDocuments" /> to <c>Supporting Documents</c>
        /// </summary>
        public SupportingDocumentsNavigation SupportingDocuments => _SupportingDocuments ??= new SupportingDocumentsNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Supporting Documents</c>
        /// </summary>
        public class SupportingDocumentsNavigation : NavigationItem
        {
            private NavigationItem? _CommonDocuments;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Common Documents</c>
            /// </summary>
            public NavigationItem CommonDocuments => _CommonDocuments ??= (this, "Common Documents");



            /// <summary>
            /// Constructs a new <see cref="SupportingDocumentsNavigation" /> navigation tree.
            /// </summary>
            public SupportingDocumentsNavigation() : base("Supporting Documents") { }
        }

        private WIPBestPracticeswithExamplesNavigation? _WIPBestPracticeswithExamples;
        /// <summary>
        /// <inheritdoc cref="WIPBestPracticeswithExamples" /> to <c>WIP: Best Practices with Examples</c>
        /// </summary>
        public WIPBestPracticeswithExamplesNavigation WIPBestPracticeswithExamples => _WIPBestPracticeswithExamples ??= new WIPBestPracticeswithExamplesNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>WIP: Best Practices with Examples</c>
        /// </summary>
        public class WIPBestPracticeswithExamplesNavigation : NavigationItem
        {
            private MachineToolNavigation? _MachineTool;
            /// <summary>
            /// <inheritdoc cref="MachineTool" /> to <c>Machine Tool</c>
            /// </summary>
            public MachineToolNavigation MachineTool => _MachineTool ??= new MachineToolNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Machine Tool</c>
            /// </summary>
            public class MachineToolNavigation : NavigationItem
            {
                private DeviceExamplesNavigation? _DeviceExamples;
                /// <summary>
                /// <inheritdoc cref="DeviceExamples" /> to <c>Device Examples</c>
                /// </summary>
                public DeviceExamplesNavigation DeviceExamples => _DeviceExamples ??= new DeviceExamplesNavigation(this);
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Device Examples</c>
                /// </summary>
                public class DeviceExamplesNavigation : NavigationItem
                {
                    private OperationalStateNavigation? _OperationalState;
                    /// <summary>
                    /// <inheritdoc cref="OperationalState" /> to <c>Operational State</c>
                    /// </summary>
                    public OperationalStateNavigation OperationalState => _OperationalState ??= new OperationalStateNavigation(this);
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Operational State</c>
                    /// </summary>
                    public class OperationalStateNavigation : NavigationItem
                    {
                        private NavigationItem? _UseCases;
                        /// <summary>
                        /// <inheritdoc cref="NavigationItem" /> to <c>Use Cases</c>
                        /// </summary>
                        public NavigationItem UseCases => _UseCases ??= (this, "Use Cases");


                        private NavigationItem? _Actors;
                        /// <summary>
                        /// <inheritdoc cref="NavigationItem" /> to <c>Actors</c>
                        /// </summary>
                        public NavigationItem Actors => _Actors ??= (this, "Actors");



                        /// <summary>
                        /// Constructs a new <see cref="OperationalStateNavigation" /> navigation tree.
                        /// </summary>
                        /// <param name="parent">Reference to the parent branch <see cref="DeviceExamplesNavigation"/></param>
                        public OperationalStateNavigation(DeviceExamplesNavigation parent) : base("Operational State", parent) { }
                    }


                    /// <summary>
                    /// Constructs a new <see cref="DeviceExamplesNavigation" /> navigation tree.
                    /// </summary>
                    /// <param name="parent">Reference to the parent branch <see cref="MachineToolNavigation"/></param>
                    public DeviceExamplesNavigation(MachineToolNavigation parent) : base("Device Examples", parent) { }
                }


                /// <summary>
                /// Constructs a new <see cref="MachineToolNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="WIPBestPracticeswithExamplesNavigation"/></param>
                public MachineToolNavigation(WIPBestPracticeswithExamplesNavigation parent) : base("Machine Tool", parent) { }
            }

            private OtherExamplesNavigation? _OtherExamples;
            /// <summary>
            /// <inheritdoc cref="OtherExamples" /> to <c>Other Examples</c>
            /// </summary>
            public OtherExamplesNavigation OtherExamples => _OtherExamples ??= new OtherExamplesNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Other Examples</c>
            /// </summary>
            public class OtherExamplesNavigation : NavigationItem
            {
                private NavigationItem? _PocketNC;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>PocketNC</c>
                /// </summary>
                public NavigationItem PocketNC => _PocketNC ??= (this, "PocketNC");


                private KinematicsSimulationNavigation? _KinematicsSimulation;
                /// <summary>
                /// <inheritdoc cref="KinematicsSimulation" /> to <c>Kinematics Simulation</c>
                /// </summary>
                public KinematicsSimulationNavigation KinematicsSimulation => _KinematicsSimulation ??= new KinematicsSimulationNavigation(this);
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Kinematics Simulation</c>
                /// </summary>
                public class KinematicsSimulationNavigation : NavigationItem
                {
                    private NavigationItem? _Simulation;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Simulation</c>
                    /// </summary>
                    public NavigationItem Simulation => _Simulation ??= (this, "Simulation");


                    private NavigationItem? _XArm7Model;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>XArm7Model</c>
                    /// </summary>
                    public NavigationItem XArm7Model => _XArm7Model ??= (this, "XArm7Model");


                    private NavigationItem? _XArm7Instance;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>XArm7Instance</c>
                    /// </summary>
                    public NavigationItem XArm7Instance => _XArm7Instance ??= (this, "XArm7Instance");



                    /// <summary>
                    /// Constructs a new <see cref="KinematicsSimulationNavigation" /> navigation tree.
                    /// </summary>
                    /// <param name="parent">Reference to the parent branch <see cref="OtherExamplesNavigation"/></param>
                    public KinematicsSimulationNavigation(OtherExamplesNavigation parent) : base("Kinematics Simulation", parent) { }
                }

                private MillwSmoothGNavigation? _MillwSmoothG;
                /// <summary>
                /// <inheritdoc cref="MillwSmoothG" /> to <c>Mill w/SmoothG</c>
                /// </summary>
                public MillwSmoothGNavigation MillwSmoothG => _MillwSmoothG ??= new MillwSmoothGNavigation(this);
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Mill w/SmoothG</c>
                /// </summary>
                public class MillwSmoothGNavigation : NavigationItem
                {
                    private NavigationItem? _Representation;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Representation</c>
                    /// </summary>
                    public NavigationItem Representation => _Representation ??= (this, "Representation");



                    /// <summary>
                    /// Constructs a new <see cref="MillwSmoothGNavigation" /> navigation tree.
                    /// </summary>
                    /// <param name="parent">Reference to the parent branch <see cref="OtherExamplesNavigation"/></param>
                    public MillwSmoothGNavigation(OtherExamplesNavigation parent) : base("Mill w/SmoothG", parent) { }
                }


                /// <summary>
                /// Constructs a new <see cref="OtherExamplesNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="WIPBestPracticeswithExamplesNavigation"/></param>
                public OtherExamplesNavigation(WIPBestPracticeswithExamplesNavigation parent) : base("Other Examples", parent) { }
            }

            private NavigationItem? _Thermal;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Thermal</c>
            /// </summary>
            public NavigationItem Thermal => _Thermal ??= (this, "Thermal");


            private NavigationItem? _RobotArms;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Robot Arms</c>
            /// </summary>
            public NavigationItem RobotArms => _RobotArms ??= (this, "Robot Arms");


            private NavigationItem? _Additive;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Additive</c>
            /// </summary>
            public NavigationItem Additive => _Additive ??= (this, "Additive");



            /// <summary>
            /// Constructs a new <see cref="WIPBestPracticeswithExamplesNavigation" /> navigation tree.
            /// </summary>
            public WIPBestPracticeswithExamplesNavigation() : base("WIP: Best Practices with Examples") { }
        }

        private NavigationItem? _MTConnectDeviceValidationSuite;
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>MTConnect Device Validation Suite</c>
        /// </summary>
        public NavigationItem MTConnectDeviceValidationSuite => _MTConnectDeviceValidationSuite ??= "MTConnect Device Validation Suite";


        private InterfaceInteractionModelNavigation? _InterfaceInteractionModel;
        /// <summary>
        /// <inheritdoc cref="InterfaceInteractionModel" /> to <c>Interface Interaction Model</c>
        /// </summary>
        public InterfaceInteractionModelNavigation InterfaceInteractionModel => _InterfaceInteractionModel ??= new InterfaceInteractionModelNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Interface Interaction Model</c>
        /// </summary>
        public class InterfaceInteractionModelNavigation : NavigationItem
        {
            private NavigationItem? _Signals;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Signals</c>
            /// </summary>
            public NavigationItem Signals => _Signals ??= (this, "Signals");


            private NavigationItem? _InterfaceTypes;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Interface Types</c>
            /// </summary>
            public NavigationItem InterfaceTypes => _InterfaceTypes ??= (this, "Interface Types");


            private MultiDeviceInteractionModelNavigation? _MultiDeviceInteractionModel;
            /// <summary>
            /// <inheritdoc cref="MultiDeviceInteractionModel" /> to <c>Multi-Device Interaction Model</c>
            /// </summary>
            public MultiDeviceInteractionModelNavigation MultiDeviceInteractionModel => _MultiDeviceInteractionModel ??= new MultiDeviceInteractionModelNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Multi-Device Interaction Model</c>
            /// </summary>
            public class MultiDeviceInteractionModelNavigation : NavigationItem
            {
                private NavigationItem? _TasksInformationModel;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Tasks Information Model</c>
                /// </summary>
                public NavigationItem TasksInformationModel => _TasksInformationModel ??= (this, "Tasks Information Model");



                /// <summary>
                /// Constructs a new <see cref="MultiDeviceInteractionModelNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="InterfaceInteractionModelNavigation"/></param>
                public MultiDeviceInteractionModelNavigation(InterfaceInteractionModelNavigation parent) : base("Multi-Device Interaction Model", parent) { }
            }

            private OperationandErrorRecoveryNavigation? _OperationandErrorRecovery;
            /// <summary>
            /// <inheritdoc cref="OperationandErrorRecovery" /> to <c>Operation and Error Recovery</c>
            /// </summary>
            public OperationandErrorRecoveryNavigation OperationandErrorRecovery => _OperationandErrorRecovery ??= new OperationandErrorRecoveryNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Operation and Error Recovery</c>
            /// </summary>
            public class OperationandErrorRecoveryNavigation : NavigationItem
            {
                private NavigationItem? _RequestandResponseFailureHandlingandRecovery;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Request and Response Failure Handling and Recovery</c>
                /// </summary>
                public NavigationItem RequestandResponseFailureHandlingandRecovery => _RequestandResponseFailureHandlingandRecovery ??= (this, "Request and Response Failure Handling and Recovery");



                /// <summary>
                /// Constructs a new <see cref="OperationandErrorRecoveryNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="InterfaceInteractionModelNavigation"/></param>
                public OperationandErrorRecoveryNavigation(InterfaceInteractionModelNavigation parent) : base("Operation and Error Recovery", parent) { }
            }

            private NavigationItem? _DataItemTypesforInterface;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>DataItem Types for Interface</c>
            /// </summary>
            public NavigationItem DataItemTypesforInterface => _DataItemTypesforInterface ??= (this, "DataItem Types for Interface");


            private NavigationItem? _DataforInterface;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Data for Interface</c>
            /// </summary>
            public NavigationItem DataforInterface => _DataforInterface ??= (this, "Data for Interface");



            /// <summary>
            /// Constructs a new <see cref="InterfaceInteractionModelNavigation" /> navigation tree.
            /// </summary>
            public InterfaceInteractionModelNavigation() : base("Interface Interaction Model") { }
        }

        private DeviceInformationModelNavigation? _DeviceInformationModel;
        /// <summary>
        /// <inheritdoc cref="DeviceInformationModel" /> to <c>Device Information Model</c>
        /// </summary>
        public DeviceInformationModelNavigation DeviceInformationModel => _DeviceInformationModel ??= new DeviceInformationModelNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Device Information Model</c>
        /// </summary>
        public class DeviceInformationModelNavigation : NavigationItem
        {
            private ComponentsNavigation? _Components;
            /// <summary>
            /// <inheritdoc cref="Components" /> to <c>Components</c>
            /// </summary>
            public ComponentsNavigation Components => _Components ??= new ComponentsNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Components</c>
            /// </summary>
            public class ComponentsNavigation : NavigationItem
            {
                private ComponentTypesNavigation? _ComponentTypes;
                /// <summary>
                /// <inheritdoc cref="ComponentTypes" /> to <c>Component Types</c>
                /// </summary>
                public ComponentTypesNavigation ComponentTypes => _ComponentTypes ??= new ComponentTypesNavigation(this);
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Component Types</c>
                /// </summary>
                public class ComponentTypesNavigation : NavigationItem
                {
                    private NavigationItem? _ComponentOrganizerTypes;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Component Organizer Types</c>
                    /// </summary>
                    public NavigationItem ComponentOrganizerTypes => _ComponentOrganizerTypes ??= (this, "Component Organizer Types");



                    /// <summary>
                    /// Constructs a new <see cref="ComponentTypesNavigation" /> navigation tree.
                    /// </summary>
                    /// <param name="parent">Reference to the parent branch <see cref="ComponentsNavigation"/></param>
                    public ComponentTypesNavigation(ComponentsNavigation parent) : base("Component Types", parent) { }
                }

                private NavigationItem? _Devices;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Devices</c>
                /// </summary>
                public NavigationItem Devices => _Devices ??= (this, "Devices");



                /// <summary>
                /// Constructs a new <see cref="ComponentsNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="DeviceInformationModelNavigation"/></param>
                public ComponentsNavigation(DeviceInformationModelNavigation parent) : base("Components", parent) { }
            }

            private NavigationItem? _Compositions;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Compositions</c>
            /// </summary>
            public NavigationItem Compositions => _Compositions ??= (this, "Compositions");


            private DataItemsNavigation? _DataItems;
            /// <summary>
            /// <inheritdoc cref="DataItems" /> to <c>DataItems</c>
            /// </summary>
            public DataItemsNavigation DataItems => _DataItems ??= new DataItemsNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>DataItems</c>
            /// </summary>
            public class DataItemsNavigation : NavigationItem
            {
                private NavigationItem? _DataItemTypes;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>DataItem Types</c>
                /// </summary>
                public NavigationItem DataItemTypes => _DataItemTypes ??= (this, "DataItem Types");


                private PropertiesofDataItemNavigation? _PropertiesofDataItem;
                /// <summary>
                /// <inheritdoc cref="PropertiesofDataItem" /> to <c>Properties of DataItem</c>
                /// </summary>
                public PropertiesofDataItemNavigation PropertiesofDataItem => _PropertiesofDataItem ??= new PropertiesofDataItemNavigation(this);
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Properties of DataItem</c>
                /// </summary>
                public class PropertiesofDataItemNavigation : NavigationItem
                {
                    private NavigationItem? _PropertiesofDefinition;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Properties of Definition</c>
                    /// </summary>
                    public NavigationItem PropertiesofDefinition => _PropertiesofDefinition ??= (this, "Properties of Definition");


                    private NavigationItem? _RelationshipTypesforDataItem;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Relationship Types for DataItem</c>
                    /// </summary>
                    public NavigationItem RelationshipTypesforDataItem => _RelationshipTypesforDataItem ??= (this, "Relationship Types for DataItem");



                    /// <summary>
                    /// Constructs a new <see cref="PropertiesofDataItemNavigation" /> navigation tree.
                    /// </summary>
                    /// <param name="parent">Reference to the parent branch <see cref="DataItemsNavigation"/></param>
                    public PropertiesofDataItemNavigation(DataItemsNavigation parent) : base("Properties of DataItem", parent) { }
                }


                /// <summary>
                /// Constructs a new <see cref="DataItemsNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="DeviceInformationModelNavigation"/></param>
                public DataItemsNavigation(DeviceInformationModelNavigation parent) : base("DataItems", parent) { }
            }

            private NavigationItem? _References;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>References</c>
            /// </summary>
            public NavigationItem References => _References ??= (this, "References");


            private ConfigurationsNavigation? _Configurations;
            /// <summary>
            /// <inheritdoc cref="Configurations" /> to <c>Configurations</c>
            /// </summary>
            public ConfigurationsNavigation Configurations => _Configurations ??= new ConfigurationsNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Configurations</c>
            /// </summary>
            public class ConfigurationsNavigation : NavigationItem
            {
                private NavigationItem? _CoordinateSystems;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>CoordinateSystems</c>
                /// </summary>
                public NavigationItem CoordinateSystems => _CoordinateSystems ??= (this, "CoordinateSystems");


                private NavigationItem? _Motion;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Motion</c>
                /// </summary>
                public NavigationItem Motion => _Motion ??= (this, "Motion");


                private NavigationItem? _Specifications;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Specifications</c>
                /// </summary>
                public NavigationItem Specifications => _Specifications ??= (this, "Specifications");


                private NavigationItem? _Sensor;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Sensor</c>
                /// </summary>
                public NavigationItem Sensor => _Sensor ??= (this, "Sensor");


                private NavigationItem? _Relationships;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Relationships</c>
                /// </summary>
                public NavigationItem Relationships => _Relationships ??= (this, "Relationships");


                private NavigationItem? _SolidModel;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>SolidModel</c>
                /// </summary>
                public NavigationItem SolidModel => _SolidModel ??= (this, "SolidModel");


                private NavigationItem? _ImageFiles;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>ImageFiles</c>
                /// </summary>
                public NavigationItem ImageFiles => _ImageFiles ??= (this, "ImageFiles");


                private NavigationItem? _PowerSource;
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>PowerSource</c>
                /// </summary>
                public NavigationItem PowerSource => _PowerSource ??= (this, "PowerSource");



                /// <summary>
                /// Constructs a new <see cref="ConfigurationsNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="DeviceInformationModelNavigation"/></param>
                public ConfigurationsNavigation(DeviceInformationModelNavigation parent) : base("Configurations", parent) { }
            }


            /// <summary>
            /// Constructs a new <see cref="DeviceInformationModelNavigation" /> navigation tree.
            /// </summary>
            public DeviceInformationModelNavigation() : base("Device Information Model") { }
        }

        private ImportsNavigation? _Imports;
        /// <summary>
        /// <inheritdoc cref="Imports" /> to <c>Imports</c>
        /// </summary>
        public ImportsNavigation Imports => _Imports ??= new ImportsNavigation();
        /// <summary>
        /// <inheritdoc cref="NavigationItem" /> to <c>Imports</c>
        /// </summary>
        public class ImportsNavigation : NavigationItem
        {
            private NavigationItem? _CSVImports;
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>CSV Imports</c>
            /// </summary>
            public NavigationItem CSVImports => _CSVImports ??= (this, "CSV Imports");


            private UnitImportsNavigation? _UnitImports;
            /// <summary>
            /// <inheritdoc cref="UnitImports" /> to <c>Unit Imports</c>
            /// </summary>
            public UnitImportsNavigation UnitImports => _UnitImports ??= new UnitImportsNavigation(this);
            /// <summary>
            /// <inheritdoc cref="NavigationItem" /> to <c>Unit Imports</c>
            /// </summary>
            public class UnitImportsNavigation : NavigationItem
            {
                private BasicUnitsNavigation? _BasicUnits;
                /// <summary>
                /// <inheritdoc cref="BasicUnits" /> to <c>Basic Units</c>
                /// </summary>
                public BasicUnitsNavigation BasicUnits => _BasicUnits ??= new BasicUnitsNavigation(this);
                /// <summary>
                /// <inheritdoc cref="NavigationItem" /> to <c>Basic Units</c>
                /// </summary>
                public class BasicUnitsNavigation : NavigationItem
                {
                    private NavigationItem? _BasicLength;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Length</c>
                    /// </summary>
                    public NavigationItem BasicLength => _BasicLength ??= (this, "Basic Length");


                    private NavigationItem? _BasicMass;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Mass</c>
                    /// </summary>
                    public NavigationItem BasicMass => _BasicMass ??= (this, "Basic Mass");


                    private NavigationItem? _BasicArea;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Area</c>
                    /// </summary>
                    public NavigationItem BasicArea => _BasicArea ??= (this, "Basic Area");


                    private NavigationItem? _BasicVolume;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Volume</c>
                    /// </summary>
                    public NavigationItem BasicVolume => _BasicVolume ??= (this, "Basic Volume");


                    private NavigationItem? _BasicTime;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Time</c>
                    /// </summary>
                    public NavigationItem BasicTime => _BasicTime ??= (this, "Basic Time");


                    private NavigationItem? _BasicElectricCurrent;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Electric Current</c>
                    /// </summary>
                    public NavigationItem BasicElectricCurrent => _BasicElectricCurrent ??= (this, "Basic Electric Current");


                    private NavigationItem? _BasicThermodynamicTemperature;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Thermodynamic Temperature</c>
                    /// </summary>
                    public NavigationItem BasicThermodynamicTemperature => _BasicThermodynamicTemperature ??= (this, "Basic Thermodynamic Temperature");


                    private NavigationItem? _BasicAmountofSubstance;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Amount of Substance</c>
                    /// </summary>
                    public NavigationItem BasicAmountofSubstance => _BasicAmountofSubstance ??= (this, "Basic Amount of Substance");


                    private NavigationItem? _BasicLuminousIntensity;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Luminous Intensity</c>
                    /// </summary>
                    public NavigationItem BasicLuminousIntensity => _BasicLuminousIntensity ??= (this, "Basic Luminous Intensity");


                    private NavigationItem? _BasicSpeedandVelocity;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Speed and Velocity</c>
                    /// </summary>
                    public NavigationItem BasicSpeedandVelocity => _BasicSpeedandVelocity ??= (this, "Basic Speed and Velocity");


                    private NavigationItem? _BasicAcceleration;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Acceleration</c>
                    /// </summary>
                    public NavigationItem BasicAcceleration => _BasicAcceleration ??= (this, "Basic Acceleration");


                    private NavigationItem? _BasicMassDensity;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Mass Density</c>
                    /// </summary>
                    public NavigationItem BasicMassDensity => _BasicMassDensity ??= (this, "Basic Mass Density");


                    private NavigationItem? _BasicElectricCurrentDensity;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Electric Current Density</c>
                    /// </summary>
                    public NavigationItem BasicElectricCurrentDensity => _BasicElectricCurrentDensity ??= (this, "Basic Electric Current Density");


                    private NavigationItem? _BasicAmountofSubstanceConcentration;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Amount of Substance Concentration</c>
                    /// </summary>
                    public NavigationItem BasicAmountofSubstanceConcentration => _BasicAmountofSubstanceConcentration ??= (this, "Basic Amount of Substance Concentration");


                    private NavigationItem? _BasicMagneticFieldStrength;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Magnetic Field Strength</c>
                    /// </summary>
                    public NavigationItem BasicMagneticFieldStrength => _BasicMagneticFieldStrength ??= (this, "Basic Magnetic Field Strength");


                    private NavigationItem? _BasicLuminance;
                    /// <summary>
                    /// <inheritdoc cref="NavigationItem" /> to <c>Basic Luminance</c>
                    /// </summary>
                    public NavigationItem BasicLuminance => _BasicLuminance ??= (this, "Basic Luminance");



                    /// <summary>
                    /// Constructs a new <see cref="BasicUnitsNavigation" /> navigation tree.
                    /// </summary>
                    /// <param name="parent">Reference to the parent branch <see cref="UnitImportsNavigation"/></param>
                    public BasicUnitsNavigation(UnitImportsNavigation parent) : base("Basic Units", parent) { }
                }


                /// <summary>
                /// Constructs a new <see cref="UnitImportsNavigation" /> navigation tree.
                /// </summary>
                /// <param name="parent">Reference to the parent branch <see cref="ImportsNavigation"/></param>
                public UnitImportsNavigation(ImportsNavigation parent) : base("Unit Imports", parent) { }
            }


            /// <summary>
            /// Constructs a new <see cref="ImportsNavigation" /> navigation tree.
            /// </summary>
            public ImportsNavigation() : base("Imports") { }
        }



    }
}
