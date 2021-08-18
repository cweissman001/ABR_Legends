

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUndirectedGraph : vtkGraph {
		public vtkUndirectedGraph(IntPtr p) : base(p) {}
		public static implicit operator  vtkUndirectedGraph(IntPtr p) {return new vtkUndirectedGraph(p);}
		public static implicit operator  IntPtr(vtkUndirectedGraph o) {return o.GetPtr();}

// static vtkUndirectedGraph* New()
// "static vtkUndirectedGraph *New()"
public static vtkUndirectedGraph New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUndirectedGraph.New_0(out returnPointer);
//	return (vtkUndirectedGraph)(IntPtr)returnPointer;
	return (vtkUndirectedGraph)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUndirectedGraph.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUndirectedGraph.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkUndirectedGraph* SafeDownCast(vtkObjectBase * o)
// "static vtkUndirectedGraph* SafeDownCast(vtkObjectBase *o)"
public static vtkUndirectedGraph SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUndirectedGraph.SafeDownCast_0(out returnPointer, o);
//	return (vtkUndirectedGraph)(IntPtr)returnPointer;
	return (vtkUndirectedGraph)(IntPtr)returnPointer;
}


// vtkUndirectedGraph* NewInstance()
// "vtkUndirectedGraph *NewInstance()"
public vtkUndirectedGraph NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUndirectedGraph.NewInstance_0(out returnPointer, this);
//	return (vtkUndirectedGraph)(IntPtr)returnPointer;
	return (vtkUndirectedGraph)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUndirectedGraph.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkIdType GetInDegree(vtkIdType v)
// "vtkIdType GetInDegree(vtkIdType v)"
public long GetInDegree(long /*(vtkIdType)*/ v) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkUndirectedGraph.GetInDegree_0(out returnPointer, this, v);
//	return (long)returnPointer;
	return returnPointer;
}


// void GetInEdge(vtkIdType v, vtkIdType i, vtkGraphEdge * e)
// "void GetInEdge(vtkIdType v, vtkIdType i, vtkGraphEdge* e)"
public void GetInEdge(long /*(vtkIdType)*/ v, long /*(vtkIdType)*/ i, vtkGraphEdge /*(vtkGraphEdge*)*/ e) {
	VTK_API.API_vtkUndirectedGraph.GetInEdge_0(this, v, i, e);
}


// void GetInEdges(vtkIdType v, vtkInEdgeIterator * it)
// "void GetInEdges(vtkIdType v, vtkInEdgeIterator *it)"
public void GetInEdges(long /*(vtkIdType)*/ v, vtkInEdgeIterator /*(vtkInEdgeIterator*)*/ it) {
	VTK_API.API_vtkUndirectedGraph.GetInEdges_0(this, v, it);
}


// bool IsStructureValid(vtkGraph * g)
// "bool IsStructureValid(vtkGraph *g)"
public bool IsStructureValid(vtkGraph /*(vtkGraph*)*/ g) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUndirectedGraph.IsStructureValid_0(out returnPointer, this, g);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
