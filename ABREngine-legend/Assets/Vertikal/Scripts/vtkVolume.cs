

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkVolume : vtkProp3D {
		public vtkVolume(IntPtr p) : base(p) {}
		public static implicit operator  vtkVolume(IntPtr p) {return new vtkVolume(p);}
		public static implicit operator  IntPtr(vtkVolume o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkVolume.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkVolume.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkVolume* SafeDownCast(vtkObjectBase * o)
// "static vtkVolume* SafeDownCast(vtkObjectBase *o)"
public static vtkVolume SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVolume.SafeDownCast_0(out returnPointer, o);
//	return (vtkVolume)(IntPtr)returnPointer;
	return (vtkVolume)(IntPtr)returnPointer;
}


// vtkVolume* NewInstance()
// "vtkVolume *NewInstance()"
public vtkVolume NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVolume.NewInstance_0(out returnPointer, this);
//	return (vtkVolume)(IntPtr)returnPointer;
	return (vtkVolume)(IntPtr)returnPointer;
}


// static vtkVolume* New()
// "static vtkVolume *New()"
public static vtkVolume New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVolume.New_0(out returnPointer);
//	return (vtkVolume)(IntPtr)returnPointer;
	return (vtkVolume)(IntPtr)returnPointer;
}


// void SetMapper(vtkAbstractVolumeMapper * mapper)
// "void SetMapper(vtkAbstractVolumeMapper *mapper)"
public void SetMapper(vtkAbstractVolumeMapper /*(vtkAbstractVolumeMapper*)*/ mapper) {
	VTK_API.API_vtkVolume.SetMapper_0(this, mapper);
}


// virtual vtkAbstractVolumeMapper* GetMapper()
// "virtual vtkAbstractVolumeMapper *GetMapper ()"
public vtkAbstractVolumeMapper GetMapper() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVolume.GetMapper_0(out returnPointer, this);
//	return (vtkAbstractVolumeMapper)(IntPtr)returnPointer;
	return (vtkAbstractVolumeMapper)(IntPtr)returnPointer;
}


// virtual void SetProperty(vtkVolumeProperty * property)
// "virtual void SetProperty(vtkVolumeProperty *property)"
public void SetProperty(vtkVolumeProperty /*(vtkVolumeProperty*)*/ property) {
	VTK_API.API_vtkVolume.SetProperty_0(this, property);
}


// virtual vtkVolumeProperty* GetProperty()
// "virtual vtkVolumeProperty *GetProperty()"
public vtkVolumeProperty GetProperty() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVolume.GetProperty_0(out returnPointer, this);
//	return (vtkVolumeProperty)(IntPtr)returnPointer;
	return (vtkVolumeProperty)(IntPtr)returnPointer;
}


// void GetVolumes(vtkPropCollection * vc)
// "void GetVolumes(vtkPropCollection *vc)"
public void GetVolumes(vtkPropCollection /*(vtkPropCollection*)*/ vc) {
	VTK_API.API_vtkVolume.GetVolumes_0(this, vc);
}


// void Update()
// "void Update()"
public void Update() {
	VTK_API.API_vtkVolume.Update_0(this);
}


// double* GetBounds()
// "double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkVolume.GetBounds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkVolume.GetBounds_1(this, bounds);
}


// double GetMinXBound()
// "double GetMinXBound()"
public double GetMinXBound() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkVolume.GetMinXBound_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// double GetMaxXBound()
// "double GetMaxXBound()"
public double GetMaxXBound() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkVolume.GetMaxXBound_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// double GetMinYBound()
// "double GetMinYBound()"
public double GetMinYBound() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkVolume.GetMinYBound_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// double GetMaxYBound()
// "double GetMaxYBound()"
public double GetMaxYBound() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkVolume.GetMaxYBound_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// double GetMinZBound()
// "double GetMinZBound()"
public double GetMinZBound() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkVolume.GetMinZBound_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// double GetMaxZBound()
// "double GetMaxZBound()"
public double GetMaxZBound() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkVolume.GetMaxZBound_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkVolume.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// vtkMTimeType GetRedrawMTime()
// "vtkMTimeType GetRedrawMTime()"
public ulong GetRedrawMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkVolume.GetRedrawMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void ShallowCopy(vtkProp * prop)
// "void ShallowCopy(vtkProp *prop)"
public void ShallowCopy(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkVolume.ShallowCopy_0(this, prop);
}


// int RenderVolumetricGeometry(vtkViewport * viewport)
// "int RenderVolumetricGeometry(vtkViewport *viewport)"
public int RenderVolumetricGeometry(vtkViewport /*(vtkViewport*)*/ viewport) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkVolume.RenderVolumetricGeometry_0(out returnPointer, this, viewport);
//	return (int)returnPointer;
	return returnPointer;
}


// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkVolume.ReleaseGraphicsResources_0(this, ARG_0);
}


// float* GetCorrectedScalarOpacityArray(int ARG_0)
// "float *GetCorrectedScalarOpacityArray(int)"
public float[] GetCorrectedScalarOpacityArray(int /*(int)*/ ARG_0) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkVolume.GetCorrectedScalarOpacityArray_0(out returnPointer, this, ARG_0);
//	return (float)returnPointer;
	return returnPointer;
}


// float* GetCorrectedScalarOpacityArray()
// "float *GetCorrectedScalarOpacityArray()"
public float[] GetCorrectedScalarOpacityArray() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkVolume.GetCorrectedScalarOpacityArray_1(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// float* GetScalarOpacityArray(int ARG_0)
// "float *GetScalarOpacityArray(int)"
public float[] GetScalarOpacityArray(int /*(int)*/ ARG_0) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkVolume.GetScalarOpacityArray_0(out returnPointer, this, ARG_0);
//	return (float)returnPointer;
	return returnPointer;
}


// float* GetScalarOpacityArray()
// "float *GetScalarOpacityArray()"
public float[] GetScalarOpacityArray() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkVolume.GetScalarOpacityArray_1(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// float* GetGradientOpacityArray(int ARG_0)
// "float *GetGradientOpacityArray(int)"
public float[] GetGradientOpacityArray(int /*(int)*/ ARG_0) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkVolume.GetGradientOpacityArray_0(out returnPointer, this, ARG_0);
//	return (float)returnPointer;
	return returnPointer;
}


// float* GetGradientOpacityArray()
// "float *GetGradientOpacityArray()"
public float[] GetGradientOpacityArray() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkVolume.GetGradientOpacityArray_1(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// float* GetGrayArray(int ARG_0)
// "float *GetGrayArray(int)"
public float[] GetGrayArray(int /*(int)*/ ARG_0) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkVolume.GetGrayArray_0(out returnPointer, this, ARG_0);
//	return (float)returnPointer;
	return returnPointer;
}


// float* GetGrayArray()
// "float *GetGrayArray()"
public float[] GetGrayArray() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkVolume.GetGrayArray_1(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// float* GetRGBArray(int ARG_0)
// "float *GetRGBArray(int)"
public float[] GetRGBArray(int /*(int)*/ ARG_0) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkVolume.GetRGBArray_0(out returnPointer, this, ARG_0);
//	return (float)returnPointer;
	return returnPointer;
}


// float* GetRGBArray()
// "float *GetRGBArray()"
public float[] GetRGBArray() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkVolume.GetRGBArray_1(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// float GetGradientOpacityConstant(int ARG_0)
// "float GetGradientOpacityConstant(int)"
public float GetGradientOpacityConstant(int /*(int)*/ ARG_0) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkVolume.GetGradientOpacityConstant_0(out returnPointer, this, ARG_0);
//	return (float)returnPointer;
	return returnPointer;
}


// float GetGradientOpacityConstant()
// "float GetGradientOpacityConstant()"
public float GetGradientOpacityConstant() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkVolume.GetGradientOpacityConstant_1(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// float GetArraySize()
// "float GetArraySize()"
public float GetArraySize() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkVolume.GetArraySize_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// void UpdateTransferFunctions(vtkRenderer * ren)
// "void UpdateTransferFunctions(vtkRenderer *ren)"
public void UpdateTransferFunctions(vtkRenderer /*(vtkRenderer*)*/ ren) {
	VTK_API.API_vtkVolume.UpdateTransferFunctions_0(this, ren);
}


// void UpdateScalarOpacityforSampleSize(vtkRenderer * ren, float sample_distance)
// "void UpdateScalarOpacityforSampleSize(vtkRenderer *ren, float sample_distance)"
public void UpdateScalarOpacityforSampleSize(vtkRenderer /*(vtkRenderer*)*/ ren, float /*(float)*/ sample_distance) {
	VTK_API.API_vtkVolume.UpdateScalarOpacityforSampleSize_0(this, ren, sample_distance);
}


// bool GetSupportsSelection()
// "bool GetSupportsSelection()"
public bool GetSupportsSelection() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkVolume.GetSupportsSelection_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
