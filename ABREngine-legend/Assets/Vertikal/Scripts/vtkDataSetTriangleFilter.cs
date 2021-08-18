

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataSetTriangleFilter : vtkUnstructuredGridAlgorithm {
		public vtkDataSetTriangleFilter(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataSetTriangleFilter(IntPtr p) {return new vtkDataSetTriangleFilter(p);}
		public static implicit operator  IntPtr(vtkDataSetTriangleFilter o) {return o.GetPtr();}

// static vtkDataSetTriangleFilter* New()
// "static vtkDataSetTriangleFilter *New()"
public static vtkDataSetTriangleFilter New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSetTriangleFilter.New_0(out returnPointer);
//	return (vtkDataSetTriangleFilter)(IntPtr)returnPointer;
	return (vtkDataSetTriangleFilter)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataSetTriangleFilter.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataSetTriangleFilter.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkDataSetTriangleFilter* SafeDownCast(vtkObjectBase * o)
// "static vtkDataSetTriangleFilter* SafeDownCast(vtkObjectBase *o)"
public static vtkDataSetTriangleFilter SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSetTriangleFilter.SafeDownCast_0(out returnPointer, o);
//	return (vtkDataSetTriangleFilter)(IntPtr)returnPointer;
	return (vtkDataSetTriangleFilter)(IntPtr)returnPointer;
}


// vtkDataSetTriangleFilter* NewInstance()
// "vtkDataSetTriangleFilter *NewInstance()"
public vtkDataSetTriangleFilter NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSetTriangleFilter.NewInstance_0(out returnPointer, this);
//	return (vtkDataSetTriangleFilter)(IntPtr)returnPointer;
	return (vtkDataSetTriangleFilter)(IntPtr)returnPointer;
}


// virtual void SetTetrahedraOnly(vtkTypeBool _arg)
// "virtual void SetTetrahedraOnly (vtkTypeBool _arg)"
public void SetTetrahedraOnly(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkDataSetTriangleFilter.SetTetrahedraOnly_0(this, _arg);
}


// virtual vtkTypeBool GetTetrahedraOnly()
// "virtual vtkTypeBool GetTetrahedraOnly ()"
public bool GetTetrahedraOnly() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataSetTriangleFilter.GetTetrahedraOnly_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void TetrahedraOnlyOn()
// "virtual void TetrahedraOnlyOn ()"
public void TetrahedraOnlyOn() {
	VTK_API.API_vtkDataSetTriangleFilter.TetrahedraOnlyOn_0(this);
}


// virtual void TetrahedraOnlyOff()
// "virtual void TetrahedraOnlyOff ()"
public void TetrahedraOnlyOff() {
	VTK_API.API_vtkDataSetTriangleFilter.TetrahedraOnlyOff_0(this);
}


}
};
