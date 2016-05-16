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
namespace Xbim.Ifc2x3.MaterialResource
{
	public partial class @IfcMaterialLayerSet : IIfcMaterialLayerSet
	{
		IEnumerable<IIfcMaterialLayer> IIfcMaterialLayerSet.MaterialLayers 
		{ 
			get
			{
				foreach (var member in MaterialLayers)
				{
					yield return member as IIfcMaterialLayer;
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcMaterialLayerSet.LayerSetName 
		{ 
			get
			{
				if (!LayerSetName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(LayerSetName.Value);
			} 
			set
			{
				if (!value.HasValue)
				{
					LayerSetName =  null ;
					return;
				}
				LayerSetName = new MeasureResource.IfcLabel(value.Value);
				
			}
		}
		private  Ifc4.MeasureResource.IfcText? _description;

		Ifc4.MeasureResource.IfcText? IIfcMaterialLayerSet.Description 
		{ 
			get
			{
				return _description;
			} 
			set
			{
				SetValue(v => _description = v, _description, value, "Description", byte.MaxValue);
				
			}
		}
		IEnumerable<IIfcRelAssociatesMaterial> IIfcMaterialDefinition.AssociatedTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesMaterial>(e => (e.RelatingMaterial as IfcMaterialLayerSet) == this, "RelatingMaterial", this);
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcMaterialDefinition.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		IEnumerable<IIfcMaterialProperties> IIfcMaterialDefinition.HasProperties 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialProperties>(e => (e.Material as IfcMaterialLayerSet) == this, "Material", this);
			} 
		}
		Ifc4.MeasureResource.IfcLengthMeasure IIfcMaterialLayerSet.TotalThickness 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(TotalThickness);
			}
		}

	//## Custom code
	//##
	}
}