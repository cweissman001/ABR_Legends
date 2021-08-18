

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkFXAAOptions : vtkObject {
		public vtkFXAAOptions(IntPtr p) : base(p) {}
		public static implicit operator  vtkFXAAOptions(IntPtr p) {return new vtkFXAAOptions(p);}
		public static implicit operator  IntPtr(vtkFXAAOptions o) {return o.GetPtr();}

// static vtkFXAAOptions* New()
// "static vtkFXAAOptions* New()"
public static vtkFXAAOptions New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFXAAOptions.New_0(out returnPointer);
//	return (vtkFXAAOptions)(IntPtr)returnPointer;
	return (vtkFXAAOptions)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFXAAOptions.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFXAAOptions.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkFXAAOptions* SafeDownCast(vtkObjectBase * o)
// "static vtkFXAAOptions* SafeDownCast(vtkObjectBase *o)"
public static vtkFXAAOptions SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFXAAOptions.SafeDownCast_0(out returnPointer, o);
//	return (vtkFXAAOptions)(IntPtr)returnPointer;
	return (vtkFXAAOptions)(IntPtr)returnPointer;
}


// vtkFXAAOptions* NewInstance()
// "vtkFXAAOptions *NewInstance()"
public vtkFXAAOptions NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFXAAOptions.NewInstance_0(out returnPointer, this);
//	return (vtkFXAAOptions)(IntPtr)returnPointer;
	return (vtkFXAAOptions)(IntPtr)returnPointer;
}


// virtual void SetRelativeContrastThreshold(float _arg)
// "virtual void SetRelativeContrastThreshold (float _arg)"
public void SetRelativeContrastThreshold(float /*(float)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetRelativeContrastThreshold_0(this, _arg);
}


// virtual float GetRelativeContrastThresholdMinValue()
// "virtual float GetRelativeContrastThresholdMinValue ()"
public float GetRelativeContrastThresholdMinValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetRelativeContrastThresholdMinValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetRelativeContrastThresholdMaxValue()
// "virtual float GetRelativeContrastThresholdMaxValue ()"
public float GetRelativeContrastThresholdMaxValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetRelativeContrastThresholdMaxValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetRelativeContrastThreshold()
// "virtual float GetRelativeContrastThreshold ()"
public float GetRelativeContrastThreshold() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetRelativeContrastThreshold_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual void SetHardContrastThreshold(float _arg)
// "virtual void SetHardContrastThreshold (float _arg)"
public void SetHardContrastThreshold(float /*(float)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetHardContrastThreshold_0(this, _arg);
}


// virtual float GetHardContrastThresholdMinValue()
// "virtual float GetHardContrastThresholdMinValue ()"
public float GetHardContrastThresholdMinValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetHardContrastThresholdMinValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetHardContrastThresholdMaxValue()
// "virtual float GetHardContrastThresholdMaxValue ()"
public float GetHardContrastThresholdMaxValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetHardContrastThresholdMaxValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetHardContrastThreshold()
// "virtual float GetHardContrastThreshold ()"
public float GetHardContrastThreshold() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetHardContrastThreshold_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual void SetSubpixelBlendLimit(float _arg)
// "virtual void SetSubpixelBlendLimit (float _arg)"
public void SetSubpixelBlendLimit(float /*(float)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetSubpixelBlendLimit_0(this, _arg);
}


// virtual float GetSubpixelBlendLimitMinValue()
// "virtual float GetSubpixelBlendLimitMinValue ()"
public float GetSubpixelBlendLimitMinValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetSubpixelBlendLimitMinValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetSubpixelBlendLimitMaxValue()
// "virtual float GetSubpixelBlendLimitMaxValue ()"
public float GetSubpixelBlendLimitMaxValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetSubpixelBlendLimitMaxValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetSubpixelBlendLimit()
// "virtual float GetSubpixelBlendLimit ()"
public float GetSubpixelBlendLimit() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetSubpixelBlendLimit_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual void SetSubpixelContrastThreshold(float _arg)
// "virtual void SetSubpixelContrastThreshold (float _arg)"
public void SetSubpixelContrastThreshold(float /*(float)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetSubpixelContrastThreshold_0(this, _arg);
}


// virtual float GetSubpixelContrastThresholdMinValue()
// "virtual float GetSubpixelContrastThresholdMinValue ()"
public float GetSubpixelContrastThresholdMinValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetSubpixelContrastThresholdMinValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetSubpixelContrastThresholdMaxValue()
// "virtual float GetSubpixelContrastThresholdMaxValue ()"
public float GetSubpixelContrastThresholdMaxValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetSubpixelContrastThresholdMaxValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetSubpixelContrastThreshold()
// "virtual float GetSubpixelContrastThreshold ()"
public float GetSubpixelContrastThreshold() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFXAAOptions.GetSubpixelContrastThreshold_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual void SetUseHighQualityEndpoints(bool _arg)
// "virtual void SetUseHighQualityEndpoints (bool _arg)"
public void SetUseHighQualityEndpoints(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetUseHighQualityEndpoints_0(this, _arg);
}


// virtual bool GetUseHighQualityEndpoints()
// "virtual bool GetUseHighQualityEndpoints ()"
public bool GetUseHighQualityEndpoints() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFXAAOptions.GetUseHighQualityEndpoints_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseHighQualityEndpointsOn()
// "virtual void UseHighQualityEndpointsOn ()"
public void UseHighQualityEndpointsOn() {
	VTK_API.API_vtkFXAAOptions.UseHighQualityEndpointsOn_0(this);
}


// virtual void UseHighQualityEndpointsOff()
// "virtual void UseHighQualityEndpointsOff ()"
public void UseHighQualityEndpointsOff() {
	VTK_API.API_vtkFXAAOptions.UseHighQualityEndpointsOff_0(this);
}


// virtual void SetEndpointSearchIterations(int _arg)
// "virtual void SetEndpointSearchIterations (int _arg)"
public void SetEndpointSearchIterations(int /*(int)*/ _arg) {
	VTK_API.API_vtkFXAAOptions.SetEndpointSearchIterations_0(this, _arg);
}


// virtual int GetEndpointSearchIterationsMinValue()
// "virtual int GetEndpointSearchIterationsMinValue ()"
public int GetEndpointSearchIterationsMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkFXAAOptions.GetEndpointSearchIterationsMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetEndpointSearchIterationsMaxValue()
// "virtual int GetEndpointSearchIterationsMaxValue ()"
public int GetEndpointSearchIterationsMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkFXAAOptions.GetEndpointSearchIterationsMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetEndpointSearchIterations()
// "virtual int GetEndpointSearchIterations ()"
public int GetEndpointSearchIterations() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkFXAAOptions.GetEndpointSearchIterations_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
