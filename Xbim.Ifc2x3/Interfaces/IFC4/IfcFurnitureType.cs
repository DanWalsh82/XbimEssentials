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
namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	public partial class @IfcFurnitureType : IIfcFurnitureType
	{
		Ifc4.Interfaces.IfcAssemblyPlaceEnum IIfcFurnitureType.AssemblyPlace 
		{ 
			get
			{
				switch (AssemblyPlace)
				{
					case ProductExtension.IfcAssemblyPlaceEnum.SITE:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.SITE;
					
					case ProductExtension.IfcAssemblyPlaceEnum.FACTORY:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.FACTORY;
					
					case ProductExtension.IfcAssemblyPlaceEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		private  Ifc4.Interfaces.IfcFurnitureTypeEnum? _predefinedType;

		Ifc4.Interfaces.IfcFurnitureTypeEnum? IIfcFurnitureType.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", byte.MaxValue);
				
			}
		}
	//## Custom code
	//##
	}
}