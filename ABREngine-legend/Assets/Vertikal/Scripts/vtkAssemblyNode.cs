

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAssemblyNode : vtkObject {
		public vtkAssemblyNode(IntPtr p) : base(p) {}
		public static implicit operator  vtkAssemblyNode(IntPtr p) {return new vtkAssemblyNode(p);}
		public static implicit operator  IntPtr(vtkAssemblyNode o) {return o.GetPtr();}

// static vtkAssemblyNode* New()
// "static vtkAssemblyNode *New()"
public static vtkAssemblyNode New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyNode.New_0(out returnPointer);
//	return (vtkAssemblyNode)(IntPtr)returnPointer;
	return (vtkAssemblyNode)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAssemblyNode.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAssemblyNode.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAssemblyNode* SafeDownCast(vtkObjectBase * o)
// "static vtkAssemblyNode* SafeDownCast(vtkObjectBase *o)"
public static vtkAssemblyNode SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyNode.SafeDownCast_0(out returnPointer, o);
//	return (vtkAssemblyNode)(IntPtr)returnPointer;
	return (vtkAssemblyNode)(IntPtr)returnPointer;
}


// vtkAssemblyNode* NewInstance()
// "vtkAssemblyNode *NewInstance()"
public vtkAssemblyNode NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyNode.NewInstance_0(out returnPointer, this);
//	return (vtkAssemblyNode)(IntPtr)returnPointer;
	return (vtkAssemblyNode)(IntPtr)returnPointer;
}


// virtual void SetViewProp(vtkProp * prop)
// "virtual void SetViewProp(vtkProp* prop)"
public void SetViewProp(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkAssemblyNode.SetViewProp_0(this, prop);
}


// virtual vtkProp* GetViewProp()
// "virtual vtkProp *GetViewProp ()"
public vtkProp GetViewProp() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyNode.GetViewProp_0(out returnPointer, this);
//	return (vtkProp)(IntPtr)returnPointer;
	return (vtkProp)(IntPtr)returnPointer;
}


// void SetMatrix(vtkMatrix4x4 * matrix)
// "void SetMatrix(vtkMatrix4x4 *matrix)"
public void SetMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkAssemblyNode.SetMatrix_0(this, matrix);
}


// virtual vtkMatrix4x4* GetMatrix()
// "virtual vtkMatrix4x4 *GetMatrix ()"
public vtkMatrix4x4 GetMatrix() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyNode.GetMatrix_0(out returnPointer, this);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkAssemblyNode.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


}
};
