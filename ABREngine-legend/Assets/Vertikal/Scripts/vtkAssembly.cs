

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAssembly : vtkProp3D {
		public vtkAssembly(IntPtr p) : base(p) {}
		public static implicit operator  vtkAssembly(IntPtr p) {return new vtkAssembly(p);}
		public static implicit operator  IntPtr(vtkAssembly o) {return o.GetPtr();}

// static vtkAssembly* New()
// "static vtkAssembly *New()"
public static vtkAssembly New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssembly.New_0(out returnPointer);
//	return (vtkAssembly)(IntPtr)returnPointer;
	return (vtkAssembly)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAssembly.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAssembly.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAssembly* SafeDownCast(vtkObjectBase * o)
// "static vtkAssembly* SafeDownCast(vtkObjectBase *o)"
public static vtkAssembly SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssembly.SafeDownCast_0(out returnPointer, o);
//	return (vtkAssembly)(IntPtr)returnPointer;
	return (vtkAssembly)(IntPtr)returnPointer;
}


// vtkAssembly* NewInstance()
// "vtkAssembly *NewInstance()"
public vtkAssembly NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssembly.NewInstance_0(out returnPointer, this);
//	return (vtkAssembly)(IntPtr)returnPointer;
	return (vtkAssembly)(IntPtr)returnPointer;
}


// void AddPart(vtkProp3D * ARG_0)
// "void AddPart(vtkProp3D *)"
public void AddPart(vtkProp3D /*(vtkProp3D*)*/ ARG_0) {
	VTK_API.API_vtkAssembly.AddPart_0(this, ARG_0);
}


// void RemovePart(vtkProp3D * ARG_0)
// "void RemovePart(vtkProp3D *)"
public void RemovePart(vtkProp3D /*(vtkProp3D*)*/ ARG_0) {
	VTK_API.API_vtkAssembly.RemovePart_0(this, ARG_0);
}


// vtkProp3DCollection* GetParts()
// "vtkProp3DCollection *GetParts()"
public vtkProp3DCollection GetParts() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssembly.GetParts_0(out returnPointer, this);
//	return (vtkProp3DCollection)(IntPtr)returnPointer;
	return (vtkProp3DCollection)(IntPtr)returnPointer;
}


// void GetActors(vtkPropCollection * ARG_0)
// "void GetActors(vtkPropCollection *)"
public void GetActors(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkAssembly.GetActors_0(this, ARG_0);
}


// void GetVolumes(vtkPropCollection * ARG_0)
// "void GetVolumes(vtkPropCollection *)"
public void GetVolumes(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkAssembly.GetVolumes_0(this, ARG_0);
}


// int RenderOpaqueGeometry(vtkViewport * ren)
// "int RenderOpaqueGeometry(vtkViewport *ren)"
public int RenderOpaqueGeometry(vtkViewport /*(vtkViewport*)*/ ren) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAssembly.RenderOpaqueGeometry_0(out returnPointer, this, ren);
//	return (int)returnPointer;
	return returnPointer;
}


// int RenderTranslucentPolygonalGeometry(vtkViewport * ren)
// "int RenderTranslucentPolygonalGeometry(vtkViewport *ren)"
public int RenderTranslucentPolygonalGeometry(vtkViewport /*(vtkViewport*)*/ ren) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAssembly.RenderTranslucentPolygonalGeometry_0(out returnPointer, this, ren);
//	return (int)returnPointer;
	return returnPointer;
}


// int RenderVolumetricGeometry(vtkViewport * ren)
// "int RenderVolumetricGeometry(vtkViewport *ren)"
public int RenderVolumetricGeometry(vtkViewport /*(vtkViewport*)*/ ren) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAssembly.RenderVolumetricGeometry_0(out returnPointer, this, ren);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkTypeBool HasTranslucentPolygonalGeometry()
// "vtkTypeBool HasTranslucentPolygonalGeometry()"
public bool HasTranslucentPolygonalGeometry() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAssembly.HasTranslucentPolygonalGeometry_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkAssembly.ReleaseGraphicsResources_0(this, ARG_0);
}


// void InitPathTraversal()
// "void InitPathTraversal()"
public void InitPathTraversal() {
	VTK_API.API_vtkAssembly.InitPathTraversal_0(this);
}


// vtkAssemblyPath* GetNextPath()
// "vtkAssemblyPath *GetNextPath()"
public vtkAssemblyPath GetNextPath() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssembly.GetNextPath_0(out returnPointer, this);
//	return (vtkAssemblyPath)(IntPtr)returnPointer;
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// int GetNumberOfPaths()
// "int GetNumberOfPaths()"
public int GetNumberOfPaths() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAssembly.GetNumberOfPaths_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkAssembly.GetBounds_0(this, bounds);
}


// double* GetBounds()
// "double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAssembly.GetBounds_1(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkAssembly.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void ShallowCopy(vtkProp * prop)
// "void ShallowCopy(vtkProp *prop)"
public void ShallowCopy(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkAssembly.ShallowCopy_0(this, prop);
}


// void BuildPaths(vtkAssemblyPaths * paths, vtkAssemblyPath * path)
// "void BuildPaths(vtkAssemblyPaths *paths, vtkAssemblyPath *path)"
public void BuildPaths(vtkAssemblyPaths /*(vtkAssemblyPaths*)*/ paths, vtkAssemblyPath /*(vtkAssemblyPath*)*/ path) {
	VTK_API.API_vtkAssembly.BuildPaths_0(this, paths, path);
}


}
};
