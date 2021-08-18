

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkActor : vtkProp3D {
		public vtkActor(IntPtr p) : base(p) {}
		public static implicit operator  vtkActor(IntPtr p) {return new vtkActor(p);}
		public static implicit operator  IntPtr(vtkActor o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkActor.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkActor.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkActor* SafeDownCast(vtkObjectBase * o)
// "static vtkActor* SafeDownCast(vtkObjectBase *o)"
public static vtkActor SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor.SafeDownCast_0(out returnPointer, o);
//	return (vtkActor)(IntPtr)returnPointer;
	return (vtkActor)(IntPtr)returnPointer;
}


// vtkActor* NewInstance()
// "vtkActor *NewInstance()"
public vtkActor NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor.NewInstance_0(out returnPointer, this);
//	return (vtkActor)(IntPtr)returnPointer;
	return (vtkActor)(IntPtr)returnPointer;
}


// static vtkActor* New()
// "static vtkActor *New()"
public static vtkActor New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor.New_0(out returnPointer);
//	return (vtkActor)(IntPtr)returnPointer;
	return (vtkActor)(IntPtr)returnPointer;
}


// void GetActors(vtkPropCollection * ARG_0)
// "void GetActors(vtkPropCollection *)"
public void GetActors(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkActor.GetActors_0(this, ARG_0);
}


// int RenderOpaqueGeometry(vtkViewport * viewport)
// "int RenderOpaqueGeometry(vtkViewport *viewport)"
public int RenderOpaqueGeometry(vtkViewport /*(vtkViewport*)*/ viewport) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkActor.RenderOpaqueGeometry_0(out returnPointer, this, viewport);
//	return (int)returnPointer;
	return returnPointer;
}


// int RenderTranslucentPolygonalGeometry(vtkViewport * viewport)
// "int RenderTranslucentPolygonalGeometry(vtkViewport *viewport)"
public int RenderTranslucentPolygonalGeometry(vtkViewport /*(vtkViewport*)*/ viewport) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkActor.RenderTranslucentPolygonalGeometry_0(out returnPointer, this, viewport);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkTypeBool HasTranslucentPolygonalGeometry()
// "vtkTypeBool HasTranslucentPolygonalGeometry()"
public bool HasTranslucentPolygonalGeometry() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkActor.HasTranslucentPolygonalGeometry_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void Render(vtkRenderer * ARG_0, vtkMapper * ARG_1)
// "virtual void Render(vtkRenderer *, vtkMapper *)"
public void Render(vtkRenderer /*(vtkRenderer*)*/ ARG_0, vtkMapper /*(vtkMapper*)*/ ARG_1) {
	VTK_API.API_vtkActor.Render_0(this, ARG_0, ARG_1);
}


// void ShallowCopy(vtkProp * prop)
// "void ShallowCopy(vtkProp *prop)"
public void ShallowCopy(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkActor.ShallowCopy_0(this, prop);
}


// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkActor.ReleaseGraphicsResources_0(this, ARG_0);
}


// void SetProperty(vtkProperty * lut)
// "void SetProperty(vtkProperty *lut)"
public void SetProperty(vtkProperty /*(vtkProperty*)*/ lut) {
	VTK_API.API_vtkActor.SetProperty_0(this, lut);
}


// vtkProperty* GetProperty()
// "vtkProperty *GetProperty()"
public vtkProperty GetProperty() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor.GetProperty_0(out returnPointer, this);
//	return (vtkProperty)(IntPtr)returnPointer;
	return (vtkProperty)(IntPtr)returnPointer;
}


// virtual vtkProperty* MakeProperty()
// "virtual vtkProperty* MakeProperty()"
public vtkProperty MakeProperty() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor.MakeProperty_0(out returnPointer, this);
//	return (vtkProperty)(IntPtr)returnPointer;
	return (vtkProperty)(IntPtr)returnPointer;
}


// void SetBackfaceProperty(vtkProperty * lut)
// "void SetBackfaceProperty(vtkProperty *lut)"
public void SetBackfaceProperty(vtkProperty /*(vtkProperty*)*/ lut) {
	VTK_API.API_vtkActor.SetBackfaceProperty_0(this, lut);
}


// virtual vtkProperty* GetBackfaceProperty()
// "virtual vtkProperty *GetBackfaceProperty ()"
public vtkProperty GetBackfaceProperty() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor.GetBackfaceProperty_0(out returnPointer, this);
//	return (vtkProperty)(IntPtr)returnPointer;
	return (vtkProperty)(IntPtr)returnPointer;
}


// virtual void SetTexture(vtkTexture * ARG_0)
// "virtual void SetTexture(vtkTexture*)"
public void SetTexture(vtkTexture /*(vtkTexture*)*/ ARG_0) {
	VTK_API.API_vtkActor.SetTexture_0(this, ARG_0);
}


// virtual vtkTexture* GetTexture()
// "virtual vtkTexture *GetTexture ()"
public vtkTexture GetTexture() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor.GetTexture_0(out returnPointer, this);
//	return (vtkTexture)(IntPtr)returnPointer;
	return (vtkTexture)(IntPtr)returnPointer;
}


// virtual void SetMapper(vtkMapper * ARG_0)
// "virtual void SetMapper(vtkMapper *)"
public void SetMapper(vtkMapper /*(vtkMapper*)*/ ARG_0) {
	VTK_API.API_vtkActor.SetMapper_0(this, ARG_0);
}


// virtual vtkMapper* GetMapper()
// "virtual vtkMapper *GetMapper ()"
public vtkMapper GetMapper() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor.GetMapper_0(out returnPointer, this);
//	return (vtkMapper)(IntPtr)returnPointer;
	return (vtkMapper)(IntPtr)returnPointer;
}


// double* GetBounds()
// "double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkActor.GetBounds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void ApplyProperties()
// "virtual void ApplyProperties()"
public void ApplyProperties() {
	VTK_API.API_vtkActor.ApplyProperties_0(this);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkActor.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// vtkMTimeType GetRedrawMTime()
// "vtkMTimeType GetRedrawMTime()"
public ulong GetRedrawMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkActor.GetRedrawMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual bool GetForceOpaque()
// "virtual bool GetForceOpaque ()"
public bool GetForceOpaque() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkActor.GetForceOpaque_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetForceOpaque(bool _arg)
// "virtual void SetForceOpaque (bool _arg)"
public void SetForceOpaque(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkActor.SetForceOpaque_0(this, _arg);
}


// virtual void ForceOpaqueOn()
// "virtual void ForceOpaqueOn ()"
public void ForceOpaqueOn() {
	VTK_API.API_vtkActor.ForceOpaqueOn_0(this);
}


// virtual void ForceOpaqueOff()
// "virtual void ForceOpaqueOff ()"
public void ForceOpaqueOff() {
	VTK_API.API_vtkActor.ForceOpaqueOff_0(this);
}


// virtual bool GetForceTranslucent()
// "virtual bool GetForceTranslucent ()"
public bool GetForceTranslucent() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkActor.GetForceTranslucent_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetForceTranslucent(bool _arg)
// "virtual void SetForceTranslucent (bool _arg)"
public void SetForceTranslucent(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkActor.SetForceTranslucent_0(this, _arg);
}


// virtual void ForceTranslucentOn()
// "virtual void ForceTranslucentOn ()"
public void ForceTranslucentOn() {
	VTK_API.API_vtkActor.ForceTranslucentOn_0(this);
}


// virtual void ForceTranslucentOff()
// "virtual void ForceTranslucentOff ()"
public void ForceTranslucentOff() {
	VTK_API.API_vtkActor.ForceTranslucentOff_0(this);
}


// bool GetSupportsSelection()
// "bool GetSupportsSelection()"
public bool GetSupportsSelection() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkActor.GetSupportsSelection_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
