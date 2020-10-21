//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrmWebApiEarlyBoundGenerator {
    using System.Reflection;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Diagnostics.CodeAnalysis;
    
    
    [ExcludeFromCodeCoverageAttribute()]
    public class bet_WorkHoursIntegration : Entity {
        
        public new const string EntityLogicalName = "bet_workhoursintegration";
        
        public new const string EntitySetName = "bet_workhoursintegrations";
        
        public new const string PrimaryIdAttribute = "bet_workhoursintegrationid";
        
        public bet_WorkHoursIntegration() {
        }
        
        public bet_WorkHoursIntegration(ExpandoObject expandoObject) : 
                base(expandoObject) {
        }
        
        public DateTime? bet_Datestart {
            get {
                return this.GetAttributeValue<DateTime?>("bet_Datestart");
            }
            set {
                this.SetAttributeValue("bet_Datestart", value);
            }
        }
        
        public DateTime? bet_Datestop {
            get {
                return this.GetAttributeValue<DateTime?>("bet_Datestop");
            }
            set {
                this.SetAttributeValue("bet_Datestop", value);
            }
        }
        
        public String bet_Description {
            get {
                return this.GetAttributeValue<String>("bet_Description");
            }
            set {
                this.SetAttributeValue("bet_Description", value);
            }
        }
        
        public String bet_EarningCode {
            get {
                return this.GetAttributeValue<String>("bet_EarningCode");
            }
            set {
                this.SetAttributeValue("bet_EarningCode", value);
            }
        }
        
        // <summary>
        // Required name field
        // </summary>
        public String bet_PersonnelNumber {
            get {
                return this.GetAttributeValue<String>("bet_PersonnelNumber");
            }
            set {
                this.SetAttributeValue("bet_PersonnelNumber", value);
            }
        }
        
        public String bet_Source {
            get {
                return this.GetAttributeValue<String>("bet_Source");
            }
            set {
                this.SetAttributeValue("bet_Source", value);
            }
        }
        
        public String bet_SourcereferenceID {
            get {
                return this.GetAttributeValue<String>("bet_SourcereferenceID");
            }
            set {
                this.SetAttributeValue("bet_SourcereferenceID", value);
            }
        }
        
        // <summary>
        // Unique identifier for entity instances
        // </summary>
        public Guid? bet_WorkHoursIntegrationId {
            get {
                return this.GetAttributeValue<Guid?>("bet_WorkHoursIntegrationId");
            }
            set {
                this.SetAttributeValue("bet_WorkHoursIntegrationId", value);
            }
        }
        
        // <summary>
        // Unique identifier of the user who created the record.
        // </summary>
        [EntityReference("systemusers", "_createdby_value")]
        public EntityReference CreatedBy {
            get {
                return this.GetAttributeValue<EntityReference>("createdby@odata.bind");
            }
            set {
                this.SetAttributeValue("createdby@odata.bind", value);
            }
        }
        
        // <summary>
        // Date and time when the record was created.
        // </summary>
        public DateTime? CreatedOn {
            get {
                return this.GetAttributeValue<DateTime?>("CreatedOn");
            }
            set {
                this.SetAttributeValue("CreatedOn", value);
            }
        }
        
        // <summary>
        // Unique identifier of the delegate user who created the record.
        // </summary>
        [EntityReference("systemusers", "_createdonbehalfby_value")]
        public EntityReference CreatedOnBehalfBy {
            get {
                return this.GetAttributeValue<EntityReference>("createdonbehalfby@odata.bind");
            }
            set {
                this.SetAttributeValue("createdonbehalfby@odata.bind", value);
            }
        }
        
        // <summary>
        // Sequence number of the import that created this record.
        // </summary>
        public int? ImportSequenceNumber {
            get {
                return this.GetAttributeValue<int?>("ImportSequenceNumber");
            }
            set {
                this.SetAttributeValue("ImportSequenceNumber", value);
            }
        }
        
        // <summary>
        // Unique identifier of the user who modified the record.
        // </summary>
        [EntityReference("systemusers", "_modifiedby_value")]
        public EntityReference ModifiedBy {
            get {
                return this.GetAttributeValue<EntityReference>("modifiedby@odata.bind");
            }
            set {
                this.SetAttributeValue("modifiedby@odata.bind", value);
            }
        }
        
        // <summary>
        // Date and time when the record was modified.
        // </summary>
        public DateTime? ModifiedOn {
            get {
                return this.GetAttributeValue<DateTime?>("ModifiedOn");
            }
            set {
                this.SetAttributeValue("ModifiedOn", value);
            }
        }
        
        // <summary>
        // Unique identifier of the delegate user who modified the record.
        // </summary>
        [EntityReference("systemusers", "_modifiedonbehalfby_value")]
        public EntityReference ModifiedOnBehalfBy {
            get {
                return this.GetAttributeValue<EntityReference>("modifiedonbehalfby@odata.bind");
            }
            set {
                this.SetAttributeValue("modifiedonbehalfby@odata.bind", value);
            }
        }
        
        // <summary>
        // Unique identifier for the organization
        // </summary>
        [EntityReference("organizations", "_organizationid_value")]
        public EntityReference OrganizationId {
            get {
                return this.GetAttributeValue<EntityReference>("organizationid@odata.bind");
            }
            set {
                this.SetAttributeValue("organizationid@odata.bind", value);
            }
        }
        
        // <summary>
        // Date and time that the record was migrated.
        // </summary>
        [OnlyDate()]
        public DateTime? OverriddenCreatedOn {
            get {
                return this.GetAttributeValue<DateTime?>("OverriddenCreatedOn");
            }
            set {
                this.SetAttributeValue("OverriddenCreatedOn", value);
            }
        }
        
        // <summary>
        // Status of the Work hours integration
        // </summary>
        public int? statecode {
            get {
                return this.GetAttributeValue<int?>("statecode");
            }
            set {
                this.SetAttributeValue("statecode", value);
            }
        }
        
        // <summary>
        // Reason for the status of the Work hours integration
        // </summary>
        public int? statuscode {
            get {
                return this.GetAttributeValue<int?>("statuscode");
            }
            set {
                this.SetAttributeValue("statuscode", value);
            }
        }
        
        // <summary>
        // For internal use only.
        // </summary>
        public int? TimeZoneRuleVersionNumber {
            get {
                return this.GetAttributeValue<int?>("TimeZoneRuleVersionNumber");
            }
            set {
                this.SetAttributeValue("TimeZoneRuleVersionNumber", value);
            }
        }
        
        // <summary>
        // Time zone code that was in use when the record was created.
        // </summary>
        public int? UTCConversionTimeZoneCode {
            get {
                return this.GetAttributeValue<int?>("UTCConversionTimeZoneCode");
            }
            set {
                this.SetAttributeValue("UTCConversionTimeZoneCode", value);
            }
        }
        
        // <summary>
        // Version Number
        // </summary>
        public long? VersionNumber {
            get {
                return this.GetAttributeValue<long?>("VersionNumber");
            }
            set {
                this.SetAttributeValue("VersionNumber", value);
            }
        }
        
        public class Fields {
            
            public const string _CreatedBy_value = "_createdby_value";
            
            public const string _CreatedOnBehalfBy_value = "_createdonbehalfby_value";
            
            public const string _ModifiedBy_value = "_modifiedby_value";
            
            public const string _ModifiedOnBehalfBy_value = "_modifiedonbehalfby_value";
            
            public const string _OrganizationId_value = "_organizationid_value";
            
            public const string bet_Datestart = "bet_datestart";
            
            public const string bet_Datestop = "bet_datestop";
            
            public const string bet_Description = "bet_description";
            
            public const string bet_EarningCode = "bet_earningcode";
            
            public const string bet_PersonnelNumber = "bet_personnelnumber";
            
            public const string bet_Source = "bet_source";
            
            public const string bet_SourcereferenceID = "bet_sourcereferenceid";
            
            public const string bet_WorkHoursIntegrationId = "bet_workhoursintegrationid";
            
            public const string CreatedBy = "createdby";
            
            public const string CreatedByName = "createdbyname";
            
            public const string CreatedByYomiName = "createdbyyominame";
            
            public const string CreatedOn = "createdon";
            
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            
            public const string CreatedOnBehalfByName = "createdonbehalfbyname";
            
            public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
            
            public const string ImportSequenceNumber = "importsequencenumber";
            
            public const string ModifiedBy = "modifiedby";
            
            public const string ModifiedByName = "modifiedbyname";
            
            public const string ModifiedByYomiName = "modifiedbyyominame";
            
            public const string ModifiedOn = "modifiedon";
            
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            
            public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
            
            public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
            
            public const string OrganizationId = "organizationid";
            
            public const string OrganizationIdName = "organizationidname";
            
            public const string OverriddenCreatedOn = "overriddencreatedon";
            
            public const string statecode = "statecode";
            
            public const string statecodeName = "statecodename";
            
            public const string statuscode = "statuscode";
            
            public const string statuscodeName = "statuscodename";
            
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            
            public const string VersionNumber = "versionnumber";
            
            public const string Id = "bet_workhoursintegrationid";
        }
        
        public class Properties {
            
            public const string createdby = "createdby";
            
            public const string createdonbehalfby = "createdonbehalfby";
            
            public const string modifiedby = "modifiedby";
            
            public const string modifiedonbehalfby = "modifiedonbehalfby";
            
            public const string organizationid = "organizationid";
        }
        
        public class Schemas {
            
            public const string bet_Datestart = "bet_Datestart";
            
            public const string bet_Datestop = "bet_Datestop";
            
            public const string bet_Description = "bet_Description";
            
            public const string bet_EarningCode = "bet_EarningCode";
            
            public const string bet_PersonnelNumber = "bet_PersonnelNumber";
            
            public const string bet_Source = "bet_Source";
            
            public const string bet_SourcereferenceID = "bet_SourcereferenceID";
            
            public const string bet_WorkHoursIntegrationId = "bet_WorkHoursIntegrationId";
            
            public const string CreatedBy = "CreatedBy";
            
            public const string CreatedByName = "CreatedByName";
            
            public const string CreatedByYomiName = "CreatedByYomiName";
            
            public const string CreatedOn = "CreatedOn";
            
            public const string CreatedOnBehalfBy = "CreatedOnBehalfBy";
            
            public const string CreatedOnBehalfByName = "CreatedOnBehalfByName";
            
            public const string CreatedOnBehalfByYomiName = "CreatedOnBehalfByYomiName";
            
            public const string ImportSequenceNumber = "ImportSequenceNumber";
            
            public const string ModifiedBy = "ModifiedBy";
            
            public const string ModifiedByName = "ModifiedByName";
            
            public const string ModifiedByYomiName = "ModifiedByYomiName";
            
            public const string ModifiedOn = "ModifiedOn";
            
            public const string ModifiedOnBehalfBy = "ModifiedOnBehalfBy";
            
            public const string ModifiedOnBehalfByName = "ModifiedOnBehalfByName";
            
            public const string ModifiedOnBehalfByYomiName = "ModifiedOnBehalfByYomiName";
            
            public const string OrganizationId = "OrganizationId";
            
            public const string OrganizationIdName = "OrganizationIdName";
            
            public const string OverriddenCreatedOn = "OverriddenCreatedOn";
            
            public const string statecode = "statecode";
            
            public const string statecodeName = "statecodeName";
            
            public const string statuscode = "statuscode";
            
            public const string statuscodeName = "statuscodeName";
            
            public const string TimeZoneRuleVersionNumber = "TimeZoneRuleVersionNumber";
            
            public const string UTCConversionTimeZoneCode = "UTCConversionTimeZoneCode";
            
            public const string VersionNumber = "VersionNumber";
        }
    }
}
