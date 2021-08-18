

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProp : vtkObject {
		public vtkProp(IntPtr p) : base(p) {}
		public static implicit operator  vtkProp(IntPtr p) {return new vtkProp(p);}
		public static implicit operator  IntPtr(vtkProp o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProp.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProp.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkProp* SafeDownCast(vtkObjectBase * o)
// "static vtkProp* SafeDownCast(vtkObjectBase *o)"
public static vtkProp SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProp.SafeDownCast_0(out returnPointer, o);
//	return (vtkProp)(IntPtr)returnPointer;
	return (vtkProp)(IntPtr)returnPointer;
}


// vtkProp* NewInstance()
// "vtkProp *NewInstance()"
public vtkProp NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProp.NewInstance_0(out returnPointer, this);
//	return (vtkProp)(IntPtr)returnPointer;
	return (vtkProp)(IntPtr)returnPointer;
}


// virtual void GetActors(vtkPropCollection * ARG_0)
// "virtual void GetActors(vtkPropCollection *)"
public void GetActors(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkProp.GetActors_0(this, ARG_0);
}


// virtual void GetActors2D(vtkPropCollection * ARG_0)
// "virtual void GetActors2D(vtkPropCollection *)"
public void GetActors2D(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkProp.GetActors2D_0(this, ARG_0);
}


// virtual void GetVolumes(vtkPropCollection * ARG_0)
// "virtual void GetVolumes(vtkPropCollection *)"
public void GetVolumes(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkProp.GetVolumes_0(this, ARG_0);
}


// virtual void SetVisibility(vtkTypeBool _arg)
// "virtual void SetVisibility (vtkTypeBool _arg)"
public void SetVisibility(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkProp.SetVisibility_0(this, _arg);
}


// virtual vtkTypeBool GetVisibility()
// "virtual vtkTypeBool GetVisibility ()"
public bool GetVisibility() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProp.GetVisibility_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void VisibilityOn()
// "virtual void VisibilityOn ()"
public void VisibilityOn() {
	VTK_API.API_vtkProp.VisibilityOn_0(this);
}


// virtual void VisibilityOff()
// "virtual void VisibilityOff ()"
public void VisibilityOff() {
	VTK_API.API_vtkProp.VisibilityOff_0(this);
}


// virtual void SetPickable(vtkTypeBool _arg)
// "virtual void SetPickable (vtkTypeBool _arg)"
public void SetPickable(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkProp.SetPickable_0(this, _arg);
}


// virtual vtkTypeBool GetPickable()
// "virtual vtkTypeBool GetPickable ()"
public bool GetPickable() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProp.GetPickable_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void PickableOn()
// "virtual void PickableOn ()"
public void PickableOn() {
	VTK_API.API_vtkProp.PickableOn_0(this);
}


// virtual void PickableOff()
// "virtual void PickableOff ()"
public void PickableOff() {
	VTK_API.API_vtkProp.PickableOff_0(this);
}


// virtual void Pick()
// "virtual void Pick()"
public void Pick() {
	VTK_API.API_vtkProp.Pick_0(this);
}


// virtual void SetDragable(vtkTypeBool _arg)
// "virtual void SetDragable (vtkTypeBool _arg)"
public void SetDragable(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkProp.SetDragable_0(this, _arg);
}


// virtual vtkTypeBool GetDragable()
// "virtual vtkTypeBool GetDragable ()"
public bool GetDragable() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProp.GetDragable_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void DragableOn()
// "virtual void DragableOn ()"
public void DragableOn() {
	VTK_API.API_vtkProp.DragableOn_0(this);
}


// virtual void DragableOff()
// "virtual void DragableOff ()"
public void DragableOff() {
	VTK_API.API_vtkProp.DragableOff_0(this);
}


// virtual vtkMTimeType GetRedrawMTime()
// "virtual vtkMTimeType GetRedrawMTime()"
public ulong GetRedrawMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkProp.GetRedrawMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual void SetUseBounds(bool _arg)
// "virtual void SetUseBounds (bool _arg)"
public void SetUseBounds(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkProp.SetUseBounds_0(this, _arg);
}


// virtual bool GetUseBounds()
// "virtual bool GetUseBounds ()"
public bool GetUseBounds() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProp.GetUseBounds_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseBoundsOn()
// "virtual void UseBoundsOn ()"
public void UseBoundsOn() {
	VTK_API.API_vtkProp.UseBoundsOn_0(this);
}


// virtual void UseBoundsOff()
// "virtual void UseBoundsOff ()"
public void UseBoundsOff() {
	VTK_API.API_vtkProp.UseBoundsOff_0(this);
}


// virtual double* GetBounds()
// "virtual double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkProp.GetBounds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void ShallowCopy(vtkProp * prop)
// "virtual void ShallowCopy(vtkProp *prop)"
public void ShallowCopy(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkProp.ShallowCopy_0(this, prop);
}


// virtual void InitPathTraversal()
// "virtual void InitPathTraversal()"
public void InitPathTraversal() {
	VTK_API.API_vtkProp.InitPathTraversal_0(this);
}


// virtual vtkAssemblyPath* GetNextPath()
// "virtual vtkAssemblyPath *GetNextPath()"
public vtkAssemblyPath GetNextPath() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProp.GetNextPath_0(out returnPointer, this);
//	return (vtkAssemblyPath)(IntPtr)returnPointer;
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// virtual int GetNumberOfPaths()
// "virtual int GetNumberOfPaths()"
public int GetNumberOfPaths() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProp.GetNumberOfPaths_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void PokeMatrix(vtkMatrix4x4 * ARG_0)
// "virtual void PokeMatrix(vtkMatrix4x4 *)"
public void PokeMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ ARG_0) {
	VTK_API.API_vtkProp.PokeMatrix_0(this, ARG_0);
}


// virtual vtkMatrix4x4* GetMatrix()
// "virtual vtkMatrix4x4 *GetMatrix()"
public vtkMatrix4x4 GetMatrix() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProp.GetMatrix_0(out returnPointer, this);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// virtual int RenderOpaqueGeometry(vtkViewport * ARG_0)
// "virtual int RenderOpaqueGeometry(vtkViewport *)"
public int RenderOpaqueGeometry(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProp.RenderOpaqueGeometry_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int RenderTranslucentPolygonalGeometry(vtkViewport * ARG_0)
// "virtual int RenderTranslucentPolygonalGeometry(vtkViewport *)"
public int RenderTranslucentPolygonalGeometry(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProp.RenderTranslucentPolygonalGeometry_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int RenderVolumetricGeometry(vtkViewport * ARG_0)
// "virtual int RenderVolumetricGeometry(vtkViewport *)"
public int RenderVolumetricGeometry(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProp.RenderVolumetricGeometry_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int RenderOverlay(vtkViewport * ARG_0)
// "virtual int RenderOverlay(vtkViewport *)"
public int RenderOverlay(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProp.RenderOverlay_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkTypeBool HasTranslucentPolygonalGeometry()
// "virtual vtkTypeBool HasTranslucentPolygonalGeometry()"
public bool HasTranslucentPolygonalGeometry() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProp.HasTranslucentPolygonalGeometry_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "virtual void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkProp.ReleaseGraphicsResources_0(this, ARG_0);
}


// virtual double GetEstimatedRenderTime(vtkViewport * ARG_0)
// "virtual double GetEstimatedRenderTime( vtkViewport * )"
public double GetEstimatedRenderTime(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProp.GetEstimatedRenderTime_0(out returnPointer, this, ARG_0);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetEstimatedRenderTime()
// "virtual double GetEstimatedRenderTime()"
public double GetEstimatedRenderTime() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProp.GetEstimatedRenderTime_1(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetEstimatedRenderTime(double t)
// "virtual void SetEstimatedRenderTime(double t)"
public void SetEstimatedRenderTime(double /*(double)*/ t) {
	VTK_API.API_vtkProp.SetEstimatedRenderTime_0(this, t);
}


// virtual void RestoreEstimatedRenderTime()
// "virtual void RestoreEstimatedRenderTime()"
public void RestoreEstimatedRenderTime() {
	VTK_API.API_vtkProp.RestoreEstimatedRenderTime_0(this);
}


// virtual void AddEstimatedRenderTime(double t, vtkViewport * ARG_0)
// "virtual void AddEstimatedRenderTime(double t, vtkViewport *)"
public void AddEstimatedRenderTime(double /*(double)*/ t, vtkViewport /*(vtkViewport*)*/ ARG_0) {
	VTK_API.API_vtkProp.AddEstimatedRenderTime_0(this, t, ARG_0);
}


// virtual void SetAllocatedRenderTime(double t, vtkViewport * ARG_0)
// "virtual void SetAllocatedRenderTime(double t, vtkViewport *)"
public void SetAllocatedRenderTime(double /*(double)*/ t, vtkViewport /*(vtkViewport*)*/ ARG_0) {
	VTK_API.API_vtkProp.SetAllocatedRenderTime_0(this, t, ARG_0);
}


// virtual double GetAllocatedRenderTime()
// "virtual double GetAllocatedRenderTime ()"
public double GetAllocatedRenderTime() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProp.GetAllocatedRenderTime_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void SetRenderTimeMultiplier(double t)
// "void SetRenderTimeMultiplier( double t )"
public void SetRenderTimeMultiplier(double /*(double)*/ t) {
	VTK_API.API_vtkProp.SetRenderTimeMultiplier_0(this, t);
}


// virtual double GetRenderTimeMultiplier()
// "virtual double GetRenderTimeMultiplier ()"
public double GetRenderTimeMultiplier() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProp.GetRenderTimeMultiplier_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void BuildPaths(vtkAssemblyPaths * paths, vtkAssemblyPath * path)
// "virtual void BuildPaths(vtkAssemblyPaths *paths, vtkAssemblyPath *path)"
public void BuildPaths(vtkAssemblyPaths /*(vtkAssemblyPaths*)*/ paths, vtkAssemblyPath /*(vtkAssemblyPath*)*/ path) {
	VTK_API.API_vtkProp.BuildPaths_0(this, paths, path);
}


// virtual bool GetSupportsSelection()
// "virtual bool GetSupportsSelection()"
public bool GetSupportsSelection() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProp.GetSupportsSelection_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfConsumers()
// "virtual int GetNumberOfConsumers ()"
public int GetNumberOfConsumers() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProp.GetNumberOfConsumers_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void AddConsumer(vtkObject * c)
// "void AddConsumer(vtkObject *c)"
public void AddConsumer(vtkObject /*(vtkObject*)*/ c) {
	VTK_API.API_vtkProp.AddConsumer_0(this, c);
}


// void RemoveConsumer(vtkObject * c)
// "void RemoveConsumer(vtkObject *c)"
public void RemoveConsumer(vtkObject /*(vtkObject*)*/ c) {
	VTK_API.API_vtkProp.RemoveConsumer_0(this, c);
}


// vtkObject* GetConsumer(int i)
// "vtkObject *GetConsumer(int i)"
public vtkObject GetConsumer(int /*(int)*/ i) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProp.GetConsumer_0(out returnPointer, this, i);
//	return (vtkObject)(IntPtr)returnPointer;
	return (vtkObject)(IntPtr)returnPointer;
}


// int IsConsumer(vtkObject * c)
// "int IsConsumer(vtkObject *c)"
public int IsConsumer(vtkObject /*(vtkObject*)*/ c) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProp.IsConsumer_0(out returnPointer, this, c);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
