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
namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralLinearAction : IIfcStructuralLinearAction
	{
		Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum? IIfcStructuralCurveAction.ProjectedOrTrue 
		{ 
			get
			{
				switch (ProjectedOrTrue)
				{
					case IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH:
						return Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH;
					
					case IfcProjectedOrTrueLengthEnum.TRUE_LENGTH:
						return Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum.TRUE_LENGTH;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		private  Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum _predefinedType;

		Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum IIfcStructuralCurveAction.PredefinedType 
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