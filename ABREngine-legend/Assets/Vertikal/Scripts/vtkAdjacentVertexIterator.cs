

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAdjacentVertexIterator : vtkObject {
		public vtkAdjacentVertexIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkAdjacentVertexIterator(IntPtr p) {return new vtkAdjacentVertexIterator(p);}
		public static implicit operator  IntPtr(vtkAdjacentVertexIterator o) {return o.GetPtr();}

// static vtkAdjacentVertexIterator* New()
// "static vtkAdjacentVertexIterator *New()"
public static vtkAdjacentVertexIterator New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAdjacentVertexIterator.New_0(out returnPointer);
//	return (vtkAdjacentVertexIterator)(IntPtr)returnPointer;
	return (vtkAdjacentVertexIterator)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAdjacentVertexIterator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAdjacentVertexIterator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAdjacentVertexIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkAdjacentVertexIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkAdjacentVertexIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAdjacentVertexIterator.SafeDownCast_0(out returnPointer, o);
//	return (vtkAdjacentVertexIterator)(IntPtr)returnPointer;
	return (vtkAdjacentVertexIterator)(IntPtr)returnPointer;
}


// vtkAdjacentVertexIterator* NewInstance()
// "vtkAdjacentVertexIterator *NewInstance()"
public vtkAdjacentVertexIterator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAdjacentVertexIterator.NewInstance_0(out returnPointer, this);
//	return (vtkAdjacentVertexIterator)(IntPtr)returnPointer;
	return (vtkAdjacentVertexIterator)(IntPtr)returnPointer;
}


// void Initialize(vtkGraph * g, vtkIdType v)
// "void Initialize(vtkGraph *g, vtkIdType v)"
public void Initialize(vtkGraph /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ v) {
	VTK_API.API_vtkAdjacentVertexIterator.Initialize_0(this, g, v);
}


// virtual vtkGraph* GetGraph()
// "virtual vtkGraph *GetGraph ()"
public vtkGraph GetGraph() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAdjacentVertexIterator.GetGraph_0(out returnPointer, this);
//	return (vtkGraph)(IntPtr)returnPointer;
	return (vtkGraph)(IntPtr)returnPointer;
}


// virtual vtkIdType GetVertex()
// "virtual vtkIdType GetVertex ()"
public long GetVertex() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAdjacentVertexIterator.GetVertex_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType Next()
// "vtkIdType Next()"
public long Next() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAdjacentVertexIterator.Next_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// bool HasNext()
// "bool HasNext()"
public bool HasNext() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAdjacentVertexIterator.HasNext_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
