// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.PropertyResource
{
	public partial class @IfcPropertyDependencyRelationship : IIfcPropertyDependencyRelationship
	{
		IIfcProperty IIfcPropertyDependencyRelationship.DependingProperty 
		{ 
			get
			{
				return DependingProperty;
			} 
			set
			{
				DependingProperty = value as IfcProperty;
				
			}
		}
		IIfcProperty IIfcPropertyDependencyRelationship.DependantProperty 
		{ 
			get
			{
				return DependantProperty;
			} 
			set
			{
				DependantProperty = value as IfcProperty;
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcPropertyDependencyRelationship.Expression 
		{ 
			get
			{
				if (!Expression.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Expression.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					Expression =  null ;
					return;
				}
				Expression = new MeasureResource.IfcText(value.Value);
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcResourceLevelRelationship.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					Name =  null ;
					return;
				}
				Name = new MeasureResource.IfcLabel(value.Value);
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcResourceLevelRelationship.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					Description =  null ;
					return;
				}
				Description = new MeasureResource.IfcText(value.Value);
				
			}
		}
	//## Custom code
	//##
	}
}