

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractMapper : vtkAlgorithm {
		public vtkAbstractMapper(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractMapper(IntPtr p) {return new vtkAbstractMapper(p);}
		public static implicit operator  IntPtr(vtkAbstractMapper o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractMapper.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractMapper.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAbstractMapper* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractMapper* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractMapper SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractMapper.SafeDownCast_0(out returnPointer, o);
//	return (vtkAbstractMapper)(IntPtr)returnPointer;
	return (vtkAbstractMapper)(IntPtr)returnPointer;
}


// vtkAbstractMapper* NewInstance()
// "vtkAbstractMapper *NewInstance()"
public vtkAbstractMapper NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractMapper.NewInstance_0(out returnPointer, this);
//	return (vtkAbstractMapper)(IntPtr)returnPointer;
	return (vtkAbstractMapper)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkAbstractMapper.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "virtual void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkAbstractMapper.ReleaseGraphicsResources_0(this, ARG_0);
}


// virtual double GetTimeToDraw()
// "virtual double GetTimeToDraw ()"
public double GetTimeToDraw() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkAbstractMapper.GetTimeToDraw_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void AddClippingPlane(vtkPlane * plane)
// "void AddClippingPlane(vtkPlane *plane)"
public void AddClippingPlane(vtkPlane /*(vtkPlane*)*/ plane) {
	VTK_API.API_vtkAbstractMapper.AddClippingPlane_0(this, plane);
}


// void RemoveClippingPlane(vtkPlane * plane)
// "void RemoveClippingPlane(vtkPlane *plane)"
public void RemoveClippingPlane(vtkPlane /*(vtkPlane*)*/ plane) {
	VTK_API.API_vtkAbstractMapper.RemoveClippingPlane_0(this, plane);
}


// void RemoveAllClippingPlanes()
// "void RemoveAllClippingPlanes()"
public void RemoveAllClippingPlanes() {
	VTK_API.API_vtkAbstractMapper.RemoveAllClippingPlanes_0(this);
}


// virtual void SetClippingPlanes(vtkPlaneCollection * ARG_0)
// "virtual void SetClippingPlanes(vtkPlaneCollection*)"
public void SetClippingPlanes(vtkPlaneCollection /*(vtkPlaneCollection*)*/ ARG_0) {
	VTK_API.API_vtkAbstractMapper.SetClippingPlanes_0(this, ARG_0);
}


// virtual vtkPlaneCollection* GetClippingPlanes()
// "virtual vtkPlaneCollection *GetClippingPlanes ()"
public vtkPlaneCollection GetClippingPlanes() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractMapper.GetClippingPlanes_0(out returnPointer, this);
//	return (vtkPlaneCollection)(IntPtr)returnPointer;
	return (vtkPlaneCollection)(IntPtr)returnPointer;
}


// void SetClippingPlanes(vtkPlanes * planes)
// "void SetClippingPlanes(vtkPlanes *planes)"
public void SetClippingPlanes(vtkPlanes /*(vtkPlanes*)*/ planes) {
	VTK_API.API_vtkAbstractMapper.SetClippingPlanes_1(this, planes);
}


// virtual void ShallowCopy(vtkAbstractMapper * m)
// "virtual void ShallowCopy(vtkAbstractMapper *m)"
public void ShallowCopy(vtkAbstractMapper /*(vtkAbstractMapper*)*/ m) {
	VTK_API.API_vtkAbstractMapper.ShallowCopy_0(this, m);
}


// static vtkDataArray* GetScalars(vtkDataSet * input, int scalarMode, int arrayAccessMode, int arrayId, const char * arrayName, int & cellFlag)
// "static vtkDataArray *GetScalars(vtkDataSet *input, int scalarMode, int arrayAccessMode, int arrayId, const char *arrayName, int& cellFlag)"
public static vtkDataArray GetScalars(vtkDataSet /*(vtkDataSet*)*/ input, int /*(int)*/ scalarMode, int /*(int)*/ arrayAccessMode, int /*(int)*/ arrayId, string /*(char*)*/ arrayName, IntPtr /*(int&)*/ cellFlag) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractMapper.GetScalars_0(out returnPointer, input, scalarMode, arrayAccessMode, arrayId, arrayName, cellFlag);
//	return (vtkDataArray)(IntPtr)returnPointer;
	return (vtkDataArray)(IntPtr)returnPointer;
}


// static vtkAbstractArray* GetAbstractScalars(vtkDataSet * input, int scalarMode, int arrayAccessMode, int arrayId, const char * arrayName, int & cellFlag)
// "static vtkAbstractArray *GetAbstractScalars(vtkDataSet *input, int scalarMode, int arrayAccessMode, int arrayId, const char *arrayName, int& cellFlag)"
public static vtkAbstractArray GetAbstractScalars(vtkDataSet /*(vtkDataSet*)*/ input, int /*(int)*/ scalarMode, int /*(int)*/ arrayAccessMode, int /*(int)*/ arrayId, string /*(char*)*/ arrayName, IntPtr /*(int&)*/ cellFlag) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractMapper.GetAbstractScalars_0(out returnPointer, input, scalarMode, arrayAccessMode, arrayId, arrayName, cellFlag);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// int GetNumberOfClippingPlanes()
// "int GetNumberOfClippingPlanes()"
public int GetNumberOfClippingPlanes() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractMapper.GetNumberOfClippingPlanes_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
