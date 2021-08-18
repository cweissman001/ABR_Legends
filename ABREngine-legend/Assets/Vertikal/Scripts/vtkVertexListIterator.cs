

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkVertexListIterator : vtkObject {
		public vtkVertexListIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkVertexListIterator(IntPtr p) {return new vtkVertexListIterator(p);}
		public static implicit operator  IntPtr(vtkVertexListIterator o) {return o.GetPtr();}

// static vtkVertexListIterator* New()
// "static vtkVertexListIterator *New()"
public static vtkVertexListIterator New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVertexListIterator.New_0(out returnPointer);
//	return (vtkVertexListIterator)(IntPtr)returnPointer;
	return (vtkVertexListIterator)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkVertexListIterator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkVertexListIterator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkVertexListIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkVertexListIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkVertexListIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVertexListIterator.SafeDownCast_0(out returnPointer, o);
//	return (vtkVertexListIterator)(IntPtr)returnPointer;
	return (vtkVertexListIterator)(IntPtr)returnPointer;
}


// vtkVertexListIterator* NewInstance()
// "vtkVertexListIterator *NewInstance()"
public vtkVertexListIterator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVertexListIterator.NewInstance_0(out returnPointer, this);
//	return (vtkVertexListIterator)(IntPtr)returnPointer;
	return (vtkVertexListIterator)(IntPtr)returnPointer;
}


// virtual void SetGraph(vtkGraph * graph)
// "virtual void SetGraph(vtkGraph *graph)"
public void SetGraph(vtkGraph /*(vtkGraph*)*/ graph) {
	VTK_API.API_vtkVertexListIterator.SetGraph_0(this, graph);
}


// virtual vtkGraph* GetGraph()
// "virtual vtkGraph *GetGraph ()"
public vtkGraph GetGraph() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVertexListIterator.GetGraph_0(out returnPointer, this);
//	return (vtkGraph)(IntPtr)returnPointer;
	return (vtkGraph)(IntPtr)returnPointer;
}


// vtkIdType Next()
// "vtkIdType Next()"
public long Next() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkVertexListIterator.Next_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// bool HasNext()
// "bool HasNext()"
public bool HasNext() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkVertexListIterator.HasNext_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
