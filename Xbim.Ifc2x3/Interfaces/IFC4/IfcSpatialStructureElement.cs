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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcSpatialStructureElement : IIfcSpatialStructureElement
	{
		Ifc4.Interfaces.IfcElementCompositionEnum? IIfcSpatialStructureElement.CompositionType 
		{ 
			get
			{
				switch (CompositionType)
				{
					case IfcElementCompositionEnum.COMPLEX:
						return Ifc4.Interfaces.IfcElementCompositionEnum.COMPLEX;
					
					case IfcElementCompositionEnum.ELEMENT:
						return Ifc4.Interfaces.IfcElementCompositionEnum.ELEMENT;
					
					case IfcElementCompositionEnum.PARTIAL:
						return Ifc4.Interfaces.IfcElementCompositionEnum.PARTIAL;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcSpatialElement.LongName 
		{ 
			get
			{
				if (!LongName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(LongName.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					LongName =  null ;
					return;
				}
				LongName = new MeasureResource.IfcLabel(value.Value);
				
			}
		}
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcSpatialElement.ContainsElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(e => (e.RelatingStructure as IfcSpatialStructureElement) == this, "RelatingStructure", this);
			} 
		}
		IEnumerable<IIfcRelServicesBuildings> IIfcSpatialElement.ServicedBySystems 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelServicesBuildings>(e => e.RelatedBuildings != null &&  e.RelatedBuildings.Contains(this), "RelatedBuildings", this);
			} 
		}
		IEnumerable<IIfcRelReferencedInSpatialStructure> IIfcSpatialElement.ReferencesElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelReferencedInSpatialStructure>(e => (e.RelatingStructure as IfcSpatialStructureElement) == this, "RelatingStructure", this);
			} 
		}
	//## Custom code
	//##
	}
}