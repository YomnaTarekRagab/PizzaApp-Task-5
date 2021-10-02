﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderView.Persistence
{
	/// <summary>Static class for (extension) methods for fetching and projecting instances of OrderView.DtoClasses.Pizza from the entity model.</summary>
	public static partial class PizzaPersistence
	{
		private static readonly System.Linq.Expressions.Expression<Func<PizzaAppData.EntityClasses.OrdersListEntity, OrderView.DtoClasses.Pizza>> _projectorExpression = CreateProjectionFunc();
		private static readonly Func<PizzaAppData.EntityClasses.OrdersListEntity, OrderView.DtoClasses.Pizza> _compiledProjector = CreateProjectionFunc().Compile();
	
		/// <summary>Empty static ctor for triggering initialization of static members in a thread-safe manner</summary>
		static PizzaPersistence() { }
	
		/// <summary>Extension method which produces a projection to OrderView.DtoClasses.Pizza which instances are projected from the 
		/// results of the specified baseQuery, which returns PizzaAppData.EntityClasses.OrdersListEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <returns>IQueryable to retrieve OrderView.DtoClasses.Pizza instances</returns>
		public static IQueryable<OrderView.DtoClasses.Pizza> ProjectToPizza(this IQueryable<PizzaAppData.EntityClasses.OrdersListEntity> baseQuery)
		{
			return baseQuery.Select(_projectorExpression);
		}
		
		/// <summary>Extension method which produces a projection to OrderView.DtoClasses.Pizza which instances are projected from the
		/// PizzaAppData.EntityClasses.OrdersListEntity entity instance specified, the root entity of the derived element returned by this method.</summary>
		/// <param name="entity">The entity to project from.</param>
		/// <returns>PizzaAppData.EntityClasses.OrdersListEntity instance created from the specified entity instance</returns>
		public static OrderView.DtoClasses.Pizza ProjectToPizza(this PizzaAppData.EntityClasses.OrdersListEntity entity)
		{
			return _compiledProjector(entity);
		}
		
		private static System.Linq.Expressions.Expression<Func<PizzaAppData.EntityClasses.OrdersListEntity, OrderView.DtoClasses.Pizza>> CreateProjectionFunc()
		{
			return p__0 => new OrderView.DtoClasses.Pizza()
			{
				Id = p__0.Id,
				PizzasLists = p__0.PizzasLists.Select(p__1 => new OrderView.DtoClasses.PizzaTypes.PizzasList()
				{
					Id = p__1.Id,
					OrderId = p__1.OrderId,
					PricePerPizza = p__1.PricePerPizza,
					Side = p__1.Side,
					Size = p__1.Size,
					Topping = p__1.Topping,
				}).ToList(),
				TotalPrice = p__0.TotalPrice,
	// __LLBLGENPRO_USER_CODE_REGION_START ProjectionRegion_Pizza 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			};
		}
	}
}

