

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDistributedGraphHelper : vtkObject {
		public vtkDistributedGraphHelper(IntPtr p) : base(p) {}
		public static implicit operator  vtkDistributedGraphHelper(IntPtr p) {return new vtkDistributedGraphHelper(p);}
		public static implicit operator  IntPtr(vtkDistributedGraphHelper o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDistributedGraphHelper.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDistributedGraphHelper.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkDistributedGraphHelper* SafeDownCast(vtkObjectBase * o)
// "static vtkDistributedGraphHelper* SafeDownCast(vtkObjectBase *o)"
public static vtkDistributedGraphHelper SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDistributedGraphHelper.SafeDownCast_0(out returnPointer, o);
//	return (vtkDistributedGraphHelper)(IntPtr)returnPointer;
	return (vtkDistributedGraphHelper)(IntPtr)returnPointer;
}


// vtkDistributedGraphHelper* NewInstance()
// "vtkDistributedGraphHelper *NewInstance()"
public vtkDistributedGraphHelper NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDistributedGraphHelper.NewInstance_0(out returnPointer, this);
//	return (vtkDistributedGraphHelper)(IntPtr)returnPointer;
	return (vtkDistributedGraphHelper)(IntPtr)returnPointer;
}


// vtkIdType GetVertexOwner(vtkIdType v)
// "vtkIdType GetVertexOwner(vtkIdType v)"
public long GetVertexOwner(long /*(vtkIdType)*/ v) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDistributedGraphHelper.GetVertexOwner_0(out returnPointer, this, v);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetVertexIndex(vtkIdType v)
// "vtkIdType GetVertexIndex(vtkIdType v)"
public long GetVertexIndex(long /*(vtkIdType)*/ v) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDistributedGraphHelper.GetVertexIndex_0(out returnPointer, this, v);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetEdgeOwner(vtkIdType e_id)
// "vtkIdType GetEdgeOwner(vtkIdType e_id)"
public long GetEdgeOwner(long /*(vtkIdType)*/ e_id) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDistributedGraphHelper.GetEdgeOwner_0(out returnPointer, this, e_id);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetEdgeIndex(vtkIdType e_id)
// "vtkIdType GetEdgeIndex(vtkIdType e_id)"
public long GetEdgeIndex(long /*(vtkIdType)*/ e_id) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDistributedGraphHelper.GetEdgeIndex_0(out returnPointer, this, e_id);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType MakeDistributedId(int owner, vtkIdType local)
// "vtkIdType MakeDistributedId(int owner, vtkIdType local)"
public long MakeDistributedId(int /*(int)*/ owner, long /*(vtkIdType)*/ local) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDistributedGraphHelper.MakeDistributedId_0(out returnPointer, this, owner, local);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void Synchronize()
// "virtual void Synchronize()"
public void Synchronize() {
	VTK_API.API_vtkDistributedGraphHelper.Synchronize_0(this);
}


// virtual vtkDistributedGraphHelper* Clone()
// "virtual vtkDistributedGraphHelper *Clone()"
public vtkDistributedGraphHelper Clone() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDistributedGraphHelper.Clone_0(out returnPointer, this);
//	return (vtkDistributedGraphHelper)(IntPtr)returnPointer;
	return (vtkDistributedGraphHelper)(IntPtr)returnPointer;
}


}
};
