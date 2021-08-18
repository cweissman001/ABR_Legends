

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkOutEdgeIterator : vtkObject {
		public vtkOutEdgeIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkOutEdgeIterator(IntPtr p) {return new vtkOutEdgeIterator(p);}
		public static implicit operator  IntPtr(vtkOutEdgeIterator o) {return o.GetPtr();}

// static vtkOutEdgeIterator* New()
// "static vtkOutEdgeIterator *New()"
public static vtkOutEdgeIterator New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkOutEdgeIterator.New_0(out returnPointer);
//	return (vtkOutEdgeIterator)(IntPtr)returnPointer;
	return (vtkOutEdgeIterator)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkOutEdgeIterator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkOutEdgeIterator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkOutEdgeIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkOutEdgeIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkOutEdgeIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkOutEdgeIterator.SafeDownCast_0(out returnPointer, o);
//	return (vtkOutEdgeIterator)(IntPtr)returnPointer;
	return (vtkOutEdgeIterator)(IntPtr)returnPointer;
}


// vtkOutEdgeIterator* NewInstance()
// "vtkOutEdgeIterator *NewInstance()"
public vtkOutEdgeIterator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkOutEdgeIterator.NewInstance_0(out returnPointer, this);
//	return (vtkOutEdgeIterator)(IntPtr)returnPointer;
	return (vtkOutEdgeIterator)(IntPtr)returnPointer;
}


// void Initialize(vtkGraph * g, vtkIdType v)
// "void Initialize(vtkGraph *g, vtkIdType v)"
public void Initialize(vtkGraph /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ v) {
	VTK_API.API_vtkOutEdgeIterator.Initialize_0(this, g, v);
}


// virtual vtkGraph* GetGraph()
// "virtual vtkGraph *GetGraph ()"
public vtkGraph GetGraph() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkOutEdgeIterator.GetGraph_0(out returnPointer, this);
//	return (vtkGraph)(IntPtr)returnPointer;
	return (vtkGraph)(IntPtr)returnPointer;
}


// virtual vtkIdType GetVertex()
// "virtual vtkIdType GetVertex ()"
public long GetVertex() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkOutEdgeIterator.GetVertex_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkGraphEdge* NextGraphEdge()
// "vtkGraphEdge *NextGraphEdge()"
public vtkGraphEdge NextGraphEdge() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkOutEdgeIterator.NextGraphEdge_0(out returnPointer, this);
//	return (vtkGraphEdge)(IntPtr)returnPointer;
	return (vtkGraphEdge)(IntPtr)returnPointer;
}


// bool HasNext()
// "bool HasNext()"
public bool HasNext() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkOutEdgeIterator.HasNext_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
