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
namespace Xbim.Ifc2x3.ActorResource
{
	public partial class @IfcOrganizationRelationship : IIfcOrganizationRelationship
	{
		IIfcOrganization IIfcOrganizationRelationship.RelatingOrganization 
		{ 
			get
			{
				return RelatingOrganization;
			} 
			set
			{
				RelatingOrganization = value as IfcOrganization;
				
			}
		}
		IEnumerable<IIfcOrganization> IIfcOrganizationRelationship.RelatedOrganizations 
		{ 
			get
			{
				foreach (var member in RelatedOrganizations)
				{
					yield return member as IIfcOrganization;
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcResourceLevelRelationship.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
			set
			{
				if (!value.HasValue)
				{
					Name =  default(MeasureResource.IfcLabel) ;
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