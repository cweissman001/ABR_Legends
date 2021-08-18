

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkObjectBase {
		public static implicit operator  vtkObjectBase(IntPtr p) {return new vtkObjectBase(p);}
		public static implicit operator  IntPtr(vtkObjectBase o) {return o.GetPtr();}

// char* GetClassName()
// "const char* GetClassName()"
public string GetClassName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkObjectBase.GetClassName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// static vtkTypeBool IsTypeOf(const char * name)
// "static vtkTypeBool IsTypeOf(const char *name)"
public static bool IsTypeOf(string /*(char*)*/ name) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkObjectBase.IsTypeOf_0(out returnPointer, name);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual vtkTypeBool IsA(const char * name)
// "virtual vtkTypeBool IsA(const char *name)"
public bool IsA(string /*(char*)*/ name) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkObjectBase.IsA_0(out returnPointer, this, name);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void Delete()
// "virtual void Delete()"
public void Delete() {
	VTK_API.API_vtkObjectBase.Delete_0(this);
}


// virtual void FastDelete()
// "virtual void FastDelete()"
public void FastDelete() {
	VTK_API.API_vtkObjectBase.FastDelete_0(this);
}


// static vtkObjectBase* New()
// "static vtkObjectBase *New()"
public static vtkObjectBase New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkObjectBase.New_0(out returnPointer);
//	return (vtkObjectBase)(IntPtr)returnPointer;
	return (vtkObjectBase)(IntPtr)returnPointer;
}


// void InitializeObjectBase()
// "void InitializeObjectBase()"
public void InitializeObjectBase() {
	VTK_API.API_vtkObjectBase.InitializeObjectBase_0(this);
}


// virtual void Register(vtkObjectBase * o)
// "virtual void Register(vtkObjectBase* o)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkObjectBase.Register_0(this, o);
}


// virtual void UnRegister(vtkObjectBase * o)
// "virtual void UnRegister(vtkObjectBase* o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkObjectBase.UnRegister_0(this, o);
}


// int GetReferenceCount()
// "int GetReferenceCount()"
public int GetReferenceCount() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkObjectBase.GetReferenceCount_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetReferenceCount(int ARG_0)
// "void SetReferenceCount(int)"
public void SetReferenceCount(int /*(int)*/ ARG_0) {
	VTK_API.API_vtkObjectBase.SetReferenceCount_0(this, ARG_0);
}


}
};
