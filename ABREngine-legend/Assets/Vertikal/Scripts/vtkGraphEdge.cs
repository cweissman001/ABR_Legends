

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkGraphEdge : vtkObject {
		public vtkGraphEdge(IntPtr p) : base(p) {}
		public static implicit operator  vtkGraphEdge(IntPtr p) {return new vtkGraphEdge(p);}
		public static implicit operator  IntPtr(vtkGraphEdge o) {return o.GetPtr();}

// static vtkGraphEdge* New()
// "static vtkGraphEdge *New()"
public static vtkGraphEdge New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraphEdge.New_0(out returnPointer);
//	return (vtkGraphEdge)(IntPtr)returnPointer;
	return (vtkGraphEdge)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraphEdge.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraphEdge.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkGraphEdge* SafeDownCast(vtkObjectBase * o)
// "static vtkGraphEdge* SafeDownCast(vtkObjectBase *o)"
public static vtkGraphEdge SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraphEdge.SafeDownCast_0(out returnPointer, o);
//	return (vtkGraphEdge)(IntPtr)returnPointer;
	return (vtkGraphEdge)(IntPtr)returnPointer;
}


// vtkGraphEdge* NewInstance()
// "vtkGraphEdge *NewInstance()"
public vtkGraphEdge NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraphEdge.NewInstance_0(out returnPointer, this);
//	return (vtkGraphEdge)(IntPtr)returnPointer;
	return (vtkGraphEdge)(IntPtr)returnPointer;
}


// virtual void SetSource(vtkIdType _arg)
// "virtual void SetSource (vtkIdType _arg)"
public void SetSource(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkGraphEdge.SetSource_0(this, _arg);
}


// virtual vtkIdType GetSource()
// "virtual vtkIdType GetSource ()"
public long GetSource() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraphEdge.GetSource_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetTarget(vtkIdType _arg)
// "virtual void SetTarget (vtkIdType _arg)"
public void SetTarget(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkGraphEdge.SetTarget_0(this, _arg);
}


// virtual vtkIdType GetTarget()
// "virtual vtkIdType GetTarget ()"
public long GetTarget() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraphEdge.GetTarget_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetId(vtkIdType _arg)
// "virtual void SetId (vtkIdType _arg)"
public void SetId(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkGraphEdge.SetId_0(this, _arg);
}


// virtual vtkIdType GetId()
// "virtual vtkIdType GetId ()"
public long GetId() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraphEdge.GetId_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
