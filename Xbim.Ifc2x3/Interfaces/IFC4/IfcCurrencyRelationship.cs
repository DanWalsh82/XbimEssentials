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
namespace Xbim.Ifc2x3.CostResource
{
	public partial class @IfcCurrencyRelationship : IIfcCurrencyRelationship
	{
		IIfcMonetaryUnit IIfcCurrencyRelationship.RelatingMonetaryUnit 
		{ 
			get
			{
				return RelatingMonetaryUnit;
			} 
			set
			{
				RelatingMonetaryUnit = value as MeasureResource.IfcMonetaryUnit;
				
			}
		}
		IIfcMonetaryUnit IIfcCurrencyRelationship.RelatedMonetaryUnit 
		{ 
			get
			{
				return RelatedMonetaryUnit;
			} 
			set
			{
				RelatedMonetaryUnit = value as MeasureResource.IfcMonetaryUnit;
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveRatioMeasure IIfcCurrencyRelationship.ExchangeRate 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveRatioMeasure(ExchangeRate);
			} 
			set
			{
				ExchangeRate = new MeasureResource.IfcPositiveRatioMeasure(value);
				
			}
		}
		Ifc4.DateTimeResource.IfcDateTime? IIfcCurrencyRelationship.RateDateTime 
		{ 
			get
			{
				//## Handle return of RateDateTime for which no match was found
			    return RateDateTime != null
			        ? new Ifc4.DateTimeResource.IfcDateTime(RateDateTime.ToISODateTimeString())
			        : null;
			    //##
			} 
			set
			{
				//## Handle setting of RateDateTime for which no match was found
				//TODO: Handle setting of RateDateTime for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		IIfcLibraryInformation IIfcCurrencyRelationship.RateSource 
		{ 
			get
			{
				return RateSource;
			} 
			set
			{
				RateSource = value as ExternalReferenceResource.IfcLibraryInformation;
				
			}
		}
		private  Ifc4.MeasureResource.IfcLabel? _name;

		Ifc4.MeasureResource.IfcLabel? IIfcResourceLevelRelationship.Name 
		{ 
			get
			{
				return _name;
			} 
			set
			{
				SetValue(v => _name = v, _name, value, "Name", byte.MaxValue);
				
			}
		}
		private  Ifc4.MeasureResource.IfcText? _description;

		Ifc4.MeasureResource.IfcText? IIfcResourceLevelRelationship.Description 
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
	//## Custom code
	//##
	}
}