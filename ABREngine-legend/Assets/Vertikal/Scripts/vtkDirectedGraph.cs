

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDirectedGraph : vtkGraph {
		public vtkDirectedGraph(IntPtr p) : base(p) {}
		public static implicit operator  vtkDirectedGraph(IntPtr p) {return new vtkDirectedGraph(p);}
		public static implicit operator  IntPtr(vtkDirectedGraph o) {return o.GetPtr();}

// static vtkDirectedGraph* New()
// "static vtkDirectedGraph *New()"
public static vtkDirectedGraph New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDirectedGraph.New_0(out returnPointer);
//	return (vtkDirectedGraph)(IntPtr)returnPointer;
	return (vtkDirectedGraph)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDirectedGraph.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDirectedGraph.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkDirectedGraph* SafeDownCast(vtkObjectBase * o)
// "static vtkDirectedGraph* SafeDownCast(vtkObjectBase *o)"
public static vtkDirectedGraph SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDirectedGraph.SafeDownCast_0(out returnPointer, o);
//	return (vtkDirectedGraph)(IntPtr)returnPointer;
	return (vtkDirectedGraph)(IntPtr)returnPointer;
}


// vtkDirectedGraph* NewInstance()
// "vtkDirectedGraph *NewInstance()"
public vtkDirectedGraph NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDirectedGraph.NewInstance_0(out returnPointer, this);
//	return (vtkDirectedGraph)(IntPtr)returnPointer;
	return (vtkDirectedGraph)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDirectedGraph.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// bool IsStructureValid(vtkGraph * g)
// "bool IsStructureValid(vtkGraph *g)"
public bool IsStructureValid(vtkGraph /*(vtkGraph*)*/ g) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDirectedGraph.IsStructureValid_0(out returnPointer, this, g);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
