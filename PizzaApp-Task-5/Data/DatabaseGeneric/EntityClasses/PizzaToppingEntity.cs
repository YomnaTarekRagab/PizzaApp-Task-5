//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using PizzaAppData.HelperClasses;
using PizzaAppData.FactoryClasses;
using PizzaAppData.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace PizzaAppData.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'PizzaTopping'.<br/><br/></summary>
	[Serializable]
	public partial class PizzaToppingEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static PizzaToppingEntityStaticMetaData _staticMetaData = new PizzaToppingEntityStaticMetaData();
		private static PizzaToppingRelations _relationsFactory = new PizzaToppingRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class PizzaToppingEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public PizzaToppingEntityStaticMetaData()
			{
				SetEntityCoreInfo("PizzaToppingEntity", InheritanceHierarchyType.None, false, (int)PizzaAppData.EntityType.PizzaToppingEntity, typeof(PizzaToppingEntity), typeof(PizzaToppingEntityFactory), false);
			}
		}

		/// <summary>Static ctor</summary>
		static PizzaToppingEntity()
		{
		}

		/// <summary> CTor</summary>
		public PizzaToppingEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PizzaToppingEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PizzaToppingEntity</param>
		public PizzaToppingEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for PizzaTopping which data should be fetched into this PizzaTopping object</param>
		public PizzaToppingEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for PizzaTopping which data should be fetched into this PizzaTopping object</param>
		/// <param name="validator">The custom validator object for this PizzaToppingEntity</param>
		public PizzaToppingEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PizzaToppingEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PizzaToppingEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static PizzaToppingRelations Relations { get { return _relationsFactory; } }

		/// <summary>The Id property of the Entity PizzaTopping<br/><br/></summary>
		/// <remarks>Mapped on  table field: "pizza_toppings"."id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)PizzaToppingFieldIndex.Id, true); }
			set { SetValue((int)PizzaToppingFieldIndex.Id, value); }		}

		/// <summary>The Price property of the Entity PizzaTopping<br/><br/></summary>
		/// <remarks>Mapped on  table field: "pizza_toppings"."price".<br/>Table field type characteristics (type, precision, scale, length): Double, 38, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Double Price
		{
			get { return (System.Double)GetValue((int)PizzaToppingFieldIndex.Price, true); }
			set	{ SetValue((int)PizzaToppingFieldIndex.Price, value); }
		}

		/// <summary>The Type property of the Entity PizzaTopping<br/><br/></summary>
		/// <remarks>Mapped on  table field: "pizza_toppings"."type".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Type
		{
			get { return (System.String)GetValue((int)PizzaToppingFieldIndex.Type, true); }
			set	{ SetValue((int)PizzaToppingFieldIndex.Type, value); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace PizzaAppData
{
	public enum PizzaToppingFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Price. </summary>
		Price,
		///<summary>Type. </summary>
		Type,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace PizzaAppData.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: PizzaTopping. </summary>
	public partial class PizzaToppingRelations: RelationFactory
	{

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticPizzaToppingRelations
	{

		/// <summary>CTor</summary>
		static StaticPizzaToppingRelations() { }
	}
}
