

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInEdgeIterator : vtkObject {
		public vtkInEdgeIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkInEdgeIterator(IntPtr p) {return new vtkInEdgeIterator(p);}
		public static implicit operator  IntPtr(vtkInEdgeIterator o) {return o.GetPtr();}

// static vtkInEdgeIterator* New()
// "static vtkInEdgeIterator *New()"
public static vtkInEdgeIterator New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkInEdgeIterator.New_0(out returnPointer);
//	return (vtkInEdgeIterator)(IntPtr)returnPointer;
	return (vtkInEdgeIterator)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkInEdgeIterator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkInEdgeIterator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkInEdgeIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkInEdgeIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkInEdgeIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkInEdgeIterator.SafeDownCast_0(out returnPointer, o);
//	return (vtkInEdgeIterator)(IntPtr)returnPointer;
	return (vtkInEdgeIterator)(IntPtr)returnPointer;
}


// vtkInEdgeIterator* NewInstance()
// "vtkInEdgeIterator *NewInstance()"
public vtkInEdgeIterator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkInEdgeIterator.NewInstance_0(out returnPointer, this);
//	return (vtkInEdgeIterator)(IntPtr)returnPointer;
	return (vtkInEdgeIterator)(IntPtr)returnPointer;
}


// void Initialize(vtkGraph * g, vtkIdType v)
// "void Initialize(vtkGraph *g, vtkIdType v)"
public void Initialize(vtkGraph /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ v) {
	VTK_API.API_vtkInEdgeIterator.Initialize_0(this, g, v);
}


// virtual vtkGraph* GetGraph()
// "virtual vtkGraph *GetGraph ()"
public vtkGraph GetGraph() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkInEdgeIterator.GetGraph_0(out returnPointer, this);
//	return (vtkGraph)(IntPtr)returnPointer;
	return (vtkGraph)(IntPtr)returnPointer;
}


// virtual vtkIdType GetVertex()
// "virtual vtkIdType GetVertex ()"
public long GetVertex() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkInEdgeIterator.GetVertex_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkGraphEdge* NextGraphEdge()
// "vtkGraphEdge *NextGraphEdge()"
public vtkGraphEdge NextGraphEdge() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkInEdgeIterator.NextGraphEdge_0(out returnPointer, this);
//	return (vtkGraphEdge)(IntPtr)returnPointer;
	return (vtkGraphEdge)(IntPtr)returnPointer;
}


// bool HasNext()
// "bool HasNext()"
public bool HasNext() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkInEdgeIterator.HasNext_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
