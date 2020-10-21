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
    public class bet_EarningStatementLine : Entity {
        
        public new const string EntityLogicalName = "bet_earningstatementline";
        
        public new const string EntitySetName = "bet_earningstatementlines";
        
        public new const string PrimaryIdAttribute = "bet_earningstatementlineid";
        
        public bet_EarningStatementLine() {
        }
        
        public bet_EarningStatementLine(ExpandoObject expandoObject) : 
                base(expandoObject) {
        }
        
        public String bet_AbsencecodeId {
            get {
                return this.GetAttributeValue<String>("bet_AbsencecodeId");
            }
            set {
                this.SetAttributeValue("bet_AbsencecodeId", value);
            }
        }
        
        // <summary>
        // Required name field
        // </summary>
        public String bet_EarningCode {
            get {
                return this.GetAttributeValue<String>("bet_EarningCode");
            }
            set {
                this.SetAttributeValue("bet_EarningCode", value);
            }
        }
        
        public String bet_Earningcodedescription {
            get {
                return this.GetAttributeValue<String>("bet_Earningcodedescription");
            }
            set {
                this.SetAttributeValue("bet_Earningcodedescription", value);
            }
        }
        
        [EntityReference("bet_earningcodes", "_bet_earningcodelookup_value")]
        public EntityReference bet_EarningCodeLookUP {
            get {
                return this.GetAttributeValue<EntityReference>("bet_EarningCodeLookUP@odata.bind");
            }
            set {
                this.SetAttributeValue("bet_EarningCodeLookUP@odata.bind", value);
            }
        }
        
        [Entity("bet_earningcode", "bet_EarningCodeLookUP")]
        public bet_EarningCode bet_EarningCodeLookUPEntity {
            get {
                return this.GetAttributeValue<bet_EarningCode>("bet_EarningCodeLookUP");
            }
            set {
                this.SetAttributeValue("bet_EarningCodeLookUP", value);
            }
        }
        
        [EntityReference("bet_earningstatements", "_bet_earningstatement_value")]
        public EntityReference bet_Earningstatement {
            get {
                return this.GetAttributeValue<EntityReference>("bet_Earningstatement@odata.bind");
            }
            set {
                this.SetAttributeValue("bet_Earningstatement@odata.bind", value);
            }
        }
        
        [Entity("bet_earningstatement", "bet_Earningstatement")]
        public bet_Earningstatement bet_EarningstatementEntity {
            get {
                return this.GetAttributeValue<bet_Earningstatement>("bet_Earningstatement");
            }
            set {
                this.SetAttributeValue("bet_Earningstatement", value);
            }
        }
        
        // <summary>
        // Unique identifier for entity instances
        // </summary>
        public Guid? bet_EarningStatementLineId {
            get {
                return this.GetAttributeValue<Guid?>("bet_EarningStatementLineId");
            }
            set {
                this.SetAttributeValue("bet_EarningStatementLineId", value);
            }
        }
        
        public int? bet_Earningtype {
            get {
                return this.GetAttributeValue<int?>("bet_Earningtype");
            }
            set {
                this.SetAttributeValue("bet_Earningtype", value);
            }
        }
        
        public bool? bet_IsCanceled {
            get {
                return this.GetAttributeValue<bool?>("bet_IsCanceled");
            }
            set {
                this.SetAttributeValue("bet_IsCanceled", value);
            }
        }
        
        public bool? bet_Isgenerated {
            get {
                return this.GetAttributeValue<bool?>("bet_Isgenerated");
            }
            set {
                this.SetAttributeValue("bet_Isgenerated", value);
            }
        }
        
        public int? bet_Payrolllinetype {
            get {
                return this.GetAttributeValue<int?>("bet_Payrolllinetype");
            }
            set {
                this.SetAttributeValue("bet_Payrolllinetype", value);
            }
        }
        
        public decimal? bet_Qty {
            get {
                return this.GetAttributeValue<decimal?>("bet_Qty");
            }
            set {
                this.SetAttributeValue("bet_Qty", value);
            }
        }
        
        public int? bet_Reporttype {
            get {
                return this.GetAttributeValue<int?>("bet_Reporttype");
            }
            set {
                this.SetAttributeValue("bet_Reporttype", value);
            }
        }
        
        [OnlyDate()]
        public DateTime? bet_StatementDate {
            get {
                return this.GetAttributeValue<DateTime?>("bet_StatementDate");
            }
            set {
                this.SetAttributeValue("bet_StatementDate", value);
            }
        }
        
        public String bet_status {
            get {
                return this.GetAttributeValue<String>("bet_status");
            }
            set {
                this.SetAttributeValue("bet_status", value);
            }
        }
        
        public decimal? bet_Unitcost {
            get {
                return this.GetAttributeValue<decimal?>("bet_Unitcost");
            }
            set {
                this.SetAttributeValue("bet_Unitcost", value);
            }
        }
        
        public String bet_Unitofmeasure {
            get {
                return this.GetAttributeValue<String>("bet_Unitofmeasure");
            }
            set {
                this.SetAttributeValue("bet_Unitofmeasure", value);
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
        // Owner Id
        // </summary>
        [EntityReference("systemusers", "_ownerid_value")]
        public EntityReference OwnerId {
            get {
                return this.GetAttributeValue<EntityReference>("OwnerId@odata.bind");
            }
            set {
                this.SetAttributeValue("OwnerId@odata.bind", value);
            }
        }
        
        // <summary>
        // Unique identifier for the business unit that owns the record
        // </summary>
        [EntityReference("businessunits", "_owningbusinessunit_value")]
        public EntityReference OwningBusinessUnit {
            get {
                return this.GetAttributeValue<EntityReference>("owningbusinessunit@odata.bind");
            }
            set {
                this.SetAttributeValue("owningbusinessunit@odata.bind", value);
            }
        }
        
        // <summary>
        // Unique identifier for the team that owns the record.
        // </summary>
        [EntityReference("teams", "_owningteam_value")]
        public EntityReference OwningTeam {
            get {
                return this.GetAttributeValue<EntityReference>("owningteam@odata.bind");
            }
            set {
                this.SetAttributeValue("owningteam@odata.bind", value);
            }
        }
        
        // <summary>
        // Unique identifier for the user that owns the record.
        // </summary>
        [EntityReference("systemusers", "_owninguser_value")]
        public EntityReference OwningUser {
            get {
                return this.GetAttributeValue<EntityReference>("owninguser@odata.bind");
            }
            set {
                this.SetAttributeValue("owninguser@odata.bind", value);
            }
        }
        
        // <summary>
        // Status of the EarningStatementLine
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
        // Reason for the status of the EarningStatementLine
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
            
            public const string _bet_EarningCodeLookUP_value = "_bet_earningcodelookup_value";
            
            public const string _bet_Earningstatement_value = "_bet_earningstatement_value";
            
            public const string _CreatedBy_value = "_createdby_value";
            
            public const string _CreatedOnBehalfBy_value = "_createdonbehalfby_value";
            
            public const string _ModifiedBy_value = "_modifiedby_value";
            
            public const string _ModifiedOnBehalfBy_value = "_modifiedonbehalfby_value";
            
            public const string _OwnerId_value = "_ownerid_value";
            
            public const string _OwningBusinessUnit_value = "_owningbusinessunit_value";
            
            public const string _OwningTeam_value = "_owningteam_value";
            
            public const string _OwningUser_value = "_owninguser_value";
            
            public const string bet_AbsencecodeId = "bet_absencecodeid";
            
            public const string bet_EarningCode = "bet_earningcode";
            
            public const string bet_Earningcodedescription = "bet_earningcodedescription";
            
            public const string bet_EarningCodeLookUP = "bet_earningcodelookup";
            
            public const string bet_EarningCodeLookUPName = "bet_earningcodelookupname";
            
            public const string bet_Earningstatement = "bet_earningstatement";
            
            public const string bet_EarningStatementLineId = "bet_earningstatementlineid";
            
            public const string bet_EarningstatementName = "bet_earningstatementname";
            
            public const string bet_Earningtype = "bet_earningtype";
            
            public const string bet_earningtypeName = "bet_earningtypename";
            
            public const string bet_IsCanceled = "bet_iscanceled";
            
            public const string bet_iscanceledName = "bet_iscanceledname";
            
            public const string bet_Isgenerated = "bet_isgenerated";
            
            public const string bet_isgeneratedName = "bet_isgeneratedname";
            
            public const string bet_Payrolllinetype = "bet_payrolllinetype";
            
            public const string bet_Qty = "bet_qty";
            
            public const string bet_Reporttype = "bet_reporttype";
            
            public const string bet_reporttypeName = "bet_reporttypename";
            
            public const string bet_StatementDate = "bet_statementdate";
            
            public const string bet_status = "bet_status";
            
            public const string bet_Unitcost = "bet_unitcost";
            
            public const string bet_Unitofmeasure = "bet_unitofmeasure";
            
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
            
            public const string OverriddenCreatedOn = "overriddencreatedon";
            
            public const string OwnerId = "ownerid";
            
            public const string OwnerIdName = "owneridname";
            
            public const string OwnerIdType = "owneridtype";
            
            public const string OwnerIdYomiName = "owneridyominame";
            
            public const string OwningBusinessUnit = "owningbusinessunit";
            
            public const string OwningTeam = "owningteam";
            
            public const string OwningUser = "owninguser";
            
            public const string statecode = "statecode";
            
            public const string statecodeName = "statecodename";
            
            public const string statuscode = "statuscode";
            
            public const string statuscodeName = "statuscodename";
            
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            
            public const string VersionNumber = "versionnumber";
            
            public const string Id = "bet_earningstatementlineid";
        }
        
        public class Properties {
            
            public const string bet_EarningCodeLookUP = "bet_EarningCodeLookUP";
            
            public const string bet_Earningstatement = "bet_Earningstatement";
            
            public const string createdby = "createdby";
            
            public const string createdonbehalfby = "createdonbehalfby";
            
            public const string modifiedby = "modifiedby";
            
            public const string modifiedonbehalfby = "modifiedonbehalfby";
            
            public const string ownerid = "ownerid";
            
            public const string owningbusinessunit = "owningbusinessunit";
            
            public const string owningteam = "owningteam";
            
            public const string owninguser = "owninguser";
        }
        
        public class Schemas {
            
            public const string bet_AbsencecodeId = "bet_AbsencecodeId";
            
            public const string bet_EarningCode = "bet_EarningCode";
            
            public const string bet_Earningcodedescription = "bet_Earningcodedescription";
            
            public const string bet_EarningCodeLookUP = "bet_EarningCodeLookUP";
            
            public const string bet_EarningCodeLookUPName = "bet_EarningCodeLookUPName";
            
            public const string bet_Earningstatement = "bet_Earningstatement";
            
            public const string bet_EarningStatementLineId = "bet_EarningStatementLineId";
            
            public const string bet_EarningstatementName = "bet_EarningstatementName";
            
            public const string bet_Earningtype = "bet_Earningtype";
            
            public const string bet_earningtypeName = "bet_earningtypeName";
            
            public const string bet_IsCanceled = "bet_IsCanceled";
            
            public const string bet_iscanceledName = "bet_iscanceledName";
            
            public const string bet_Isgenerated = "bet_Isgenerated";
            
            public const string bet_isgeneratedName = "bet_isgeneratedName";
            
            public const string bet_Payrolllinetype = "bet_Payrolllinetype";
            
            public const string bet_Qty = "bet_Qty";
            
            public const string bet_Reporttype = "bet_Reporttype";
            
            public const string bet_reporttypeName = "bet_reporttypeName";
            
            public const string bet_StatementDate = "bet_StatementDate";
            
            public const string bet_status = "bet_status";
            
            public const string bet_Unitcost = "bet_Unitcost";
            
            public const string bet_Unitofmeasure = "bet_Unitofmeasure";
            
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
            
            public const string OverriddenCreatedOn = "OverriddenCreatedOn";
            
            public const string OwnerId = "OwnerId";
            
            public const string OwnerIdName = "OwnerIdName";
            
            public const string OwnerIdType = "OwnerIdType";
            
            public const string OwnerIdYomiName = "OwnerIdYomiName";
            
            public const string OwningBusinessUnit = "OwningBusinessUnit";
            
            public const string OwningTeam = "OwningTeam";
            
            public const string OwningUser = "OwningUser";
            
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