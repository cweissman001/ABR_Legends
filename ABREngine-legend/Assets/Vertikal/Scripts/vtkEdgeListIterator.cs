

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkEdgeListIterator : vtkObject {
		public vtkEdgeListIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkEdgeListIterator(IntPtr p) {return new vtkEdgeListIterator(p);}
		public static implicit operator  IntPtr(vtkEdgeListIterator o) {return o.GetPtr();}

// static vtkEdgeListIterator* New()
// "static vtkEdgeListIterator *New()"
public static vtkEdgeListIterator New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkEdgeListIterator.New_0(out returnPointer);
//	return (vtkEdgeListIterator)(IntPtr)returnPointer;
	return (vtkEdgeListIterator)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkEdgeListIterator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkEdgeListIterator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkEdgeListIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkEdgeListIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkEdgeListIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkEdgeListIterator.SafeDownCast_0(out returnPointer, o);
//	return (vtkEdgeListIterator)(IntPtr)returnPointer;
	return (vtkEdgeListIterator)(IntPtr)returnPointer;
}


// vtkEdgeListIterator* NewInstance()
// "vtkEdgeListIterator *NewInstance()"
public vtkEdgeListIterator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkEdgeListIterator.NewInstance_0(out returnPointer, this);
//	return (vtkEdgeListIterator)(IntPtr)returnPointer;
	return (vtkEdgeListIterator)(IntPtr)returnPointer;
}


// virtual vtkGraph* GetGraph()
// "virtual vtkGraph *GetGraph ()"
public vtkGraph GetGraph() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkEdgeListIterator.GetGraph_0(out returnPointer, this);
//	return (vtkGraph)(IntPtr)returnPointer;
	return (vtkGraph)(IntPtr)returnPointer;
}


// virtual void SetGraph(vtkGraph * graph)
// "virtual void SetGraph(vtkGraph *graph)"
public void SetGraph(vtkGraph /*(vtkGraph*)*/ graph) {
	VTK_API.API_vtkEdgeListIterator.SetGraph_0(this, graph);
}


// vtkGraphEdge* NextGraphEdge()
// "vtkGraphEdge *NextGraphEdge()"
public vtkGraphEdge NextGraphEdge() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkEdgeListIterator.NextGraphEdge_0(out returnPointer, this);
//	return (vtkGraphEdge)(IntPtr)returnPointer;
	return (vtkGraphEdge)(IntPtr)returnPointer;
}


// bool HasNext()
// "bool HasNext()"
public bool HasNext() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkEdgeListIterator.HasNext_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
