//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(LBA.lba_testEntities1),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySetsd6b41990ae343ea63d4b21a31537b6c29108efbf2edf1ea54edbc93ca71c43fb))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework 6 Power Tools", "0.9.5.0")]
    internal sealed class ViewsForBaseEntitySetsd6b41990ae343ea63d4b21a31537b6c29108efbf2edf1ea54edbc93ca71c43fb : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "d6b41990ae343ea63d4b21a31537b6c29108efbf2edf1ea54edbc93ca71c43fb"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "lba_testModelStoreContainer.sysdiagrams")
            {
                return GetView0();
            }

            if (extentName == "lba_testEntities1.sysdiagrams")
            {
                return GetView1();
            }

            if (extentName == "lba_testModelStoreContainer.T_Limit")
            {
                return GetView2();
            }

            if (extentName == "lba_testEntities1.T_Limit")
            {
                return GetView3();
            }

            if (extentName == "lba_testModelStoreContainer.T_Nationality")
            {
                return GetView4();
            }

            if (extentName == "lba_testModelStoreContainer.T_Operation")
            {
                return GetView5();
            }

            if (extentName == "lba_testModelStoreContainer.T_OperationType")
            {
                return GetView6();
            }

            if (extentName == "lba_testModelStoreContainer.T_Person")
            {
                return GetView7();
            }

            if (extentName == "lba_testEntities1.T_Nationality")
            {
                return GetView8();
            }

            if (extentName == "lba_testEntities1.T_Operation")
            {
                return GetView9();
            }

            if (extentName == "lba_testEntities1.T_OperationType")
            {
                return GetView10();
            }

            if (extentName == "lba_testEntities1.T_Person")
            {
                return GetView11();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for lba_testModelStoreContainer.sysdiagrams.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing sysdiagrams
        [lba_testModel.Store.sysdiagrams](T1.sysdiagrams_name, T1.[sysdiagrams.principal_id], T1.[sysdiagrams.diagram_id], T1.sysdiagrams_version, T1.sysdiagrams_definition)
    FROM (
        SELECT 
            T.name AS sysdiagrams_name, 
            T.principal_id AS [sysdiagrams.principal_id], 
            T.diagram_id AS [sysdiagrams.diagram_id], 
            T.version AS sysdiagrams_version, 
            T.definition AS sysdiagrams_definition, 
            True AS _from0
        FROM lba_testEntities1.sysdiagrams AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testEntities1.sysdiagrams.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing sysdiagrams
        [lba_testModel.sysdiagrams](T1.sysdiagrams_name, T1.[sysdiagrams.principal_id], T1.[sysdiagrams.diagram_id], T1.sysdiagrams_version, T1.sysdiagrams_definition)
    FROM (
        SELECT 
            T.name AS sysdiagrams_name, 
            T.principal_id AS [sysdiagrams.principal_id], 
            T.diagram_id AS [sysdiagrams.diagram_id], 
            T.version AS sysdiagrams_version, 
            T.definition AS sysdiagrams_definition, 
            True AS _from0
        FROM lba_testModelStoreContainer.sysdiagrams AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testModelStoreContainer.T_Limit.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing T_Limit
        [lba_testModel.Store.T_Limit](T1.[T_Limit.limitId], T1.[T_Limit.limitName], T1.[T_Limit.limitAmount])
    FROM (
        SELECT 
            T.limitId AS [T_Limit.limitId], 
            T.limitName AS [T_Limit.limitName], 
            T.limitAmount AS [T_Limit.limitAmount], 
            True AS _from0
        FROM lba_testEntities1.T_Limit AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testEntities1.T_Limit.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing T_Limit
        [lba_testModel.T_Limit](T1.[T_Limit.limitId], T1.[T_Limit.limitName], T1.[T_Limit.limitAmount])
    FROM (
        SELECT 
            T.limitId AS [T_Limit.limitId], 
            T.limitName AS [T_Limit.limitName], 
            T.limitAmount AS [T_Limit.limitAmount], 
            True AS _from0
        FROM lba_testModelStoreContainer.T_Limit AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testModelStoreContainer.T_Nationality.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing T_Nationality
        [lba_testModel.Store.T_Nationality](T1.[T_Nationality.nationalityId], T1.[T_Nationality.countryName], T1.[T_Nationality.countryRisk])
    FROM (
        SELECT 
            T.nationalityId AS [T_Nationality.nationalityId], 
            T.countryName AS [T_Nationality.countryName], 
            T.countryRisk AS [T_Nationality.countryRisk], 
            True AS _from0
        FROM lba_testEntities1.T_Nationality AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testModelStoreContainer.T_Operation.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing T_Operation
        [lba_testModel.Store.T_Operation](T1.[T_Operation.operationId], T1.[T_Operation.personFk], T1.[T_Operation.operationTypeFk], T1.[T_Operation.operatorName], T1.[T_Operation.cashdesk], T1.[T_Operation.cession], T1.[T_Operation.retrocession], T1.[T_Operation.operationDate], T1.[T_Operation.operationAmount], T1.[T_Operation.operationComment])
    FROM (
        SELECT 
            T.operationId AS [T_Operation.operationId], 
            T.personFk AS [T_Operation.personFk], 
            T.operationTypeFk AS [T_Operation.operationTypeFk], 
            T.operatorName AS [T_Operation.operatorName], 
            T.cashdesk AS [T_Operation.cashdesk], 
            T.cession AS [T_Operation.cession], 
            T.retrocession AS [T_Operation.retrocession], 
            T.operationDate AS [T_Operation.operationDate], 
            T.operationAmount AS [T_Operation.operationAmount], 
            T.operationComment AS [T_Operation.operationComment], 
            True AS _from0
        FROM lba_testEntities1.T_Operation AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testModelStoreContainer.T_OperationType.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing T_OperationType
        [lba_testModel.Store.T_OperationType](T1.[T_OperationType.operationTypeId], T1.[T_OperationType.operationTypeName])
    FROM (
        SELECT 
            T.operationTypeId AS [T_OperationType.operationTypeId], 
            T.operationTypeName AS [T_OperationType.operationTypeName], 
            True AS _from0
        FROM lba_testEntities1.T_OperationType AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testModelStoreContainer.T_Person.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView7()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing T_Person
        [lba_testModel.Store.T_Person](T1.[T_Person.personId], T1.[T_Person.lastName], T1.[T_Person.firstName], T1.[T_Person.otherName], T1.[T_Person.nationalityFk], T1.[T_Person.birthday], T1.[T_Person.commentPerson], T1.[T_Person.road], T1.[T_Person.city], T1.[T_Person.country], T1.[T_Person.job], T1.[T_Person.documentType], T1.[T_Person.idValidity], T1.[T_Person.docNumber])
    FROM (
        SELECT 
            T.personId AS [T_Person.personId], 
            T.lastName AS [T_Person.lastName], 
            T.firstName AS [T_Person.firstName], 
            T.otherName AS [T_Person.otherName], 
            T.nationalityFk AS [T_Person.nationalityFk], 
            T.birthday AS [T_Person.birthday], 
            T.commentPerson AS [T_Person.commentPerson], 
            T.road AS [T_Person.road], 
            T.city AS [T_Person.city], 
            T.country AS [T_Person.country], 
            T.job AS [T_Person.job], 
            T.documentType AS [T_Person.documentType], 
            T.idValidity AS [T_Person.idValidity], 
            T.docNumber AS [T_Person.docNumber], 
            True AS _from0
        FROM lba_testEntities1.T_Person AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testEntities1.T_Nationality.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView8()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing T_Nationality
        [lba_testModel.T_Nationality](T1.[T_Nationality.nationalityId], T1.[T_Nationality.countryName], T1.[T_Nationality.countryRisk])
    FROM (
        SELECT 
            T.nationalityId AS [T_Nationality.nationalityId], 
            T.countryName AS [T_Nationality.countryName], 
            T.countryRisk AS [T_Nationality.countryRisk], 
            True AS _from0
        FROM lba_testModelStoreContainer.T_Nationality AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testEntities1.T_Operation.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView9()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing T_Operation
        [lba_testModel.T_Operation](T1.[T_Operation.operationId], T1.[T_Operation.personFk], T1.[T_Operation.operationTypeFk], T1.[T_Operation.cashdesk], T1.[T_Operation.cession], T1.[T_Operation.retrocession], T1.[T_Operation.operationDate], T1.[T_Operation.operationAmount], T1.[T_Operation.operationComment], T1.[T_Operation.operatorName])
    FROM (
        SELECT 
            T.operationId AS [T_Operation.operationId], 
            T.personFk AS [T_Operation.personFk], 
            T.operationTypeFk AS [T_Operation.operationTypeFk], 
            T.cashdesk AS [T_Operation.cashdesk], 
            T.cession AS [T_Operation.cession], 
            T.retrocession AS [T_Operation.retrocession], 
            T.operationDate AS [T_Operation.operationDate], 
            T.operationAmount AS [T_Operation.operationAmount], 
            T.operationComment AS [T_Operation.operationComment], 
            T.operatorName AS [T_Operation.operatorName], 
            True AS _from0
        FROM lba_testModelStoreContainer.T_Operation AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testEntities1.T_OperationType.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView10()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing T_OperationType
        [lba_testModel.T_OperationType](T1.[T_OperationType.operationTypeId], T1.[T_OperationType.operationTypeName])
    FROM (
        SELECT 
            T.operationTypeId AS [T_OperationType.operationTypeId], 
            T.operationTypeName AS [T_OperationType.operationTypeName], 
            True AS _from0
        FROM lba_testModelStoreContainer.T_OperationType AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for lba_testEntities1.T_Person.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView11()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing T_Person
        [lba_testModel.T_Person](T1.[T_Person.personId], T1.[T_Person.lastName], T1.[T_Person.firstName], T1.[T_Person.otherName], T1.[T_Person.nationalityFk], T1.[T_Person.birthday], T1.[T_Person.commentPerson], T1.[T_Person.road], T1.[T_Person.city], T1.[T_Person.country], T1.[T_Person.job], T1.[T_Person.documentType], T1.[T_Person.idValidity], T1.[T_Person.docNumber])
    FROM (
        SELECT 
            T.personId AS [T_Person.personId], 
            T.lastName AS [T_Person.lastName], 
            T.firstName AS [T_Person.firstName], 
            T.otherName AS [T_Person.otherName], 
            T.nationalityFk AS [T_Person.nationalityFk], 
            T.birthday AS [T_Person.birthday], 
            T.commentPerson AS [T_Person.commentPerson], 
            T.road AS [T_Person.road], 
            T.city AS [T_Person.city], 
            T.country AS [T_Person.country], 
            T.job AS [T_Person.job], 
            T.documentType AS [T_Person.documentType], 
            T.idValidity AS [T_Person.idValidity], 
            T.docNumber AS [T_Person.docNumber], 
            True AS _from0
        FROM lba_testModelStoreContainer.T_Person AS T
    ) AS T1");
        }
    }
}
