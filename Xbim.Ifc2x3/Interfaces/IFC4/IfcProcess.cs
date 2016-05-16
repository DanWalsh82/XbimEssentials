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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcProcess : IIfcProcess
	{
		private  Ifc4.MeasureResource.IfcIdentifier? _identification;

		Ifc4.MeasureResource.IfcIdentifier? IIfcProcess.Identification 
		{ 
			get
			{
				return _identification;
			} 
			set
			{
				SetValue(v => _identification = v, _identification, value, "Identification", byte.MaxValue);
				
			}
		}
		private  Ifc4.MeasureResource.IfcText? _longDescription;

		Ifc4.MeasureResource.IfcText? IIfcProcess.LongDescription 
		{ 
			get
			{
				return _longDescription;
			} 
			set
			{
				SetValue(v => _longDescription = v, _longDescription, value, "LongDescription", byte.MaxValue);
				
			}
		}
		IEnumerable<IIfcRelSequence> IIfcProcess.IsPredecessorTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelSequence>(e => (e.RelatingProcess as IfcProcess) == this, "RelatingProcess", this);
			} 
		}
		IEnumerable<IIfcRelSequence> IIfcProcess.IsSuccessorFrom 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelSequence>(e => (e.RelatedProcess as IfcProcess) == this, "RelatedProcess", this);
			} 
		}
		IEnumerable<IIfcRelAssignsToProcess> IIfcProcess.OperatesOn 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssignsToProcess>(e => (e.RelatingProcess as IfcProcess) == this, "RelatingProcess", this);
			} 
		}
	//## Custom code
	//##
	}
}