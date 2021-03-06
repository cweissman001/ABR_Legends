

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkTriangleFilter : vtkPolyDataAlgorithm {
		public vtkTriangleFilter(IntPtr p) : base(p) {}
		public static implicit operator  vtkTriangleFilter(IntPtr p) {return new vtkTriangleFilter(p);}
		public static implicit operator  IntPtr(vtkTriangleFilter o) {return o.GetPtr();}

// static vtkTriangleFilter* New()
// "static vtkTriangleFilter *New()"
public static vtkTriangleFilter New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTriangleFilter.New_0(out returnPointer);
//	return (vtkTriangleFilter)(IntPtr)returnPointer;
	return (vtkTriangleFilter)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTriangleFilter.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTriangleFilter.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkTriangleFilter* SafeDownCast(vtkObjectBase * o)
// "static vtkTriangleFilter* SafeDownCast(vtkObjectBase *o)"
public static vtkTriangleFilter SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTriangleFilter.SafeDownCast_0(out returnPointer, o);
//	return (vtkTriangleFilter)(IntPtr)returnPointer;
	return (vtkTriangleFilter)(IntPtr)returnPointer;
}


// vtkTriangleFilter* NewInstance()
// "vtkTriangleFilter *NewInstance()"
public vtkTriangleFilter NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTriangleFilter.NewInstance_0(out returnPointer, this);
//	return (vtkTriangleFilter)(IntPtr)returnPointer;
	return (vtkTriangleFilter)(IntPtr)returnPointer;
}


// virtual void PassVertsOn()
// "virtual void PassVertsOn ()"
public void PassVertsOn() {
	VTK_API.API_vtkTriangleFilter.PassVertsOn_0(this);
}


// virtual void PassVertsOff()
// "virtual void PassVertsOff ()"
public void PassVertsOff() {
	VTK_API.API_vtkTriangleFilter.PassVertsOff_0(this);
}


// virtual void SetPassVerts(vtkTypeBool _arg)
// "virtual void SetPassVerts (vtkTypeBool _arg)"
public void SetPassVerts(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkTriangleFilter.SetPassVerts_0(this, _arg);
}


// virtual vtkTypeBool GetPassVerts()
// "virtual vtkTypeBool GetPassVerts ()"
public bool GetPassVerts() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTriangleFilter.GetPassVerts_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void PassLinesOn()
// "virtual void PassLinesOn ()"
public void PassLinesOn() {
	VTK_API.API_vtkTriangleFilter.PassLinesOn_0(this);
}


// virtual void PassLinesOff()
// "virtual void PassLinesOff ()"
public void PassLinesOff() {
	VTK_API.API_vtkTriangleFilter.PassLinesOff_0(this);
}


// virtual void SetPassLines(vtkTypeBool _arg)
// "virtual void SetPassLines (vtkTypeBool _arg)"
public void SetPassLines(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkTriangleFilter.SetPassLines_0(this, _arg);
}


// virtual vtkTypeBool GetPassLines()
// "virtual vtkTypeBool GetPassLines ()"
public bool GetPassLines() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTriangleFilter.GetPassLines_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
