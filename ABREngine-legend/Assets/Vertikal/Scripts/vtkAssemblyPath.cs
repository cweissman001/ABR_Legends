

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAssemblyPath : vtkCollection {
		public vtkAssemblyPath(IntPtr p) : base(p) {}
		public static implicit operator  vtkAssemblyPath(IntPtr p) {return new vtkAssemblyPath(p);}
		public static implicit operator  IntPtr(vtkAssemblyPath o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAssemblyPath.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAssemblyPath.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAssemblyPath* SafeDownCast(vtkObjectBase * o)
// "static vtkAssemblyPath* SafeDownCast(vtkObjectBase *o)"
public static vtkAssemblyPath SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyPath.SafeDownCast_0(out returnPointer, o);
//	return (vtkAssemblyPath)(IntPtr)returnPointer;
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// vtkAssemblyPath* NewInstance()
// "vtkAssemblyPath *NewInstance()"
public vtkAssemblyPath NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyPath.NewInstance_0(out returnPointer, this);
//	return (vtkAssemblyPath)(IntPtr)returnPointer;
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// static vtkAssemblyPath* New()
// "static vtkAssemblyPath *New()"
public static vtkAssemblyPath New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyPath.New_0(out returnPointer);
//	return (vtkAssemblyPath)(IntPtr)returnPointer;
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// void AddNode(vtkProp * p, vtkMatrix4x4 * m)
// "void AddNode(vtkProp *p, vtkMatrix4x4 *m)"
public void AddNode(vtkProp /*(vtkProp*)*/ p, vtkMatrix4x4 /*(vtkMatrix4x4*)*/ m) {
	VTK_API.API_vtkAssemblyPath.AddNode_0(this, p, m);
}


// vtkAssemblyNode* GetNextNode()
// "vtkAssemblyNode *GetNextNode()"
public vtkAssemblyNode GetNextNode() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyPath.GetNextNode_0(out returnPointer, this);
//	return (vtkAssemblyNode)(IntPtr)returnPointer;
	return (vtkAssemblyNode)(IntPtr)returnPointer;
}


// vtkAssemblyNode* GetFirstNode()
// "vtkAssemblyNode *GetFirstNode()"
public vtkAssemblyNode GetFirstNode() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyPath.GetFirstNode_0(out returnPointer, this);
//	return (vtkAssemblyNode)(IntPtr)returnPointer;
	return (vtkAssemblyNode)(IntPtr)returnPointer;
}


// vtkAssemblyNode* GetLastNode()
// "vtkAssemblyNode *GetLastNode()"
public vtkAssemblyNode GetLastNode() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyPath.GetLastNode_0(out returnPointer, this);
//	return (vtkAssemblyNode)(IntPtr)returnPointer;
	return (vtkAssemblyNode)(IntPtr)returnPointer;
}


// void DeleteLastNode()
// "void DeleteLastNode()"
public void DeleteLastNode() {
	VTK_API.API_vtkAssemblyPath.DeleteLastNode_0(this);
}


// void ShallowCopy(vtkAssemblyPath * path)
// "void ShallowCopy(vtkAssemblyPath *path)"
public void ShallowCopy(vtkAssemblyPath /*(vtkAssemblyPath*)*/ path) {
	VTK_API.API_vtkAssemblyPath.ShallowCopy_0(this, path);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkAssemblyPath.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


}
};
