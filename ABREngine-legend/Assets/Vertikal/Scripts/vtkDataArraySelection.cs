

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataArraySelection : vtkObject {
		public vtkDataArraySelection(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataArraySelection(IntPtr p) {return new vtkDataArraySelection(p);}
		public static implicit operator  IntPtr(vtkDataArraySelection o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataArraySelection.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataArraySelection.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkDataArraySelection* SafeDownCast(vtkObjectBase * o)
// "static vtkDataArraySelection* SafeDownCast(vtkObjectBase *o)"
public static vtkDataArraySelection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataArraySelection.SafeDownCast_0(out returnPointer, o);
//	return (vtkDataArraySelection)(IntPtr)returnPointer;
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// vtkDataArraySelection* NewInstance()
// "vtkDataArraySelection *NewInstance()"
public vtkDataArraySelection NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataArraySelection.NewInstance_0(out returnPointer, this);
//	return (vtkDataArraySelection)(IntPtr)returnPointer;
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// static vtkDataArraySelection* New()
// "static vtkDataArraySelection* New()"
public static vtkDataArraySelection New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataArraySelection.New_0(out returnPointer);
//	return (vtkDataArraySelection)(IntPtr)returnPointer;
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// void EnableArray(const char * name)
// "void EnableArray(const char* name)"
public void EnableArray(string /*(char*)*/ name) {
	VTK_API.API_vtkDataArraySelection.EnableArray_0(this, name);
}


// void DisableArray(const char * name)
// "void DisableArray(const char* name)"
public void DisableArray(string /*(char*)*/ name) {
	VTK_API.API_vtkDataArraySelection.DisableArray_0(this, name);
}


// int ArrayIsEnabled(const char * name)
// "int ArrayIsEnabled(const char* name)"
public int ArrayIsEnabled(string /*(char*)*/ name) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataArraySelection.ArrayIsEnabled_0(out returnPointer, this, name);
//	return (int)returnPointer;
	return returnPointer;
}


// int ArrayExists(const char * name)
// "int ArrayExists(const char* name)"
public int ArrayExists(string /*(char*)*/ name) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataArraySelection.ArrayExists_0(out returnPointer, this, name);
//	return (int)returnPointer;
	return returnPointer;
}


// void EnableAllArrays()
// "void EnableAllArrays()"
public void EnableAllArrays() {
	VTK_API.API_vtkDataArraySelection.EnableAllArrays_0(this);
}


// void DisableAllArrays()
// "void DisableAllArrays()"
public void DisableAllArrays() {
	VTK_API.API_vtkDataArraySelection.DisableAllArrays_0(this);
}


// int GetNumberOfArrays()
// "int GetNumberOfArrays()"
public int GetNumberOfArrays() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataArraySelection.GetNumberOfArrays_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfArraysEnabled()
// "int GetNumberOfArraysEnabled()"
public int GetNumberOfArraysEnabled() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataArraySelection.GetNumberOfArraysEnabled_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// char* GetArrayName(int index)
// "const char* GetArrayName(int index)"
public string GetArrayName(int /*(int)*/ index) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataArraySelection.GetArrayName_0(out returnPointer, this, index);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// int GetArrayIndex(const char * name)
// "int GetArrayIndex(const char *name)"
public int GetArrayIndex(string /*(char*)*/ name) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataArraySelection.GetArrayIndex_0(out returnPointer, this, name);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetEnabledArrayIndex(const char * name)
// "int GetEnabledArrayIndex(const char* name)"
public int GetEnabledArrayIndex(string /*(char*)*/ name) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataArraySelection.GetEnabledArrayIndex_0(out returnPointer, this, name);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetArraySetting(int index)
// "int GetArraySetting(int index)"
public int GetArraySetting(int /*(int)*/ index) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataArraySelection.GetArraySetting_0(out returnPointer, this, index);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetArraySetting(const char * name)
// "int GetArraySetting(const char* name)"
public int GetArraySetting(string /*(char*)*/ name) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataArraySelection.GetArraySetting_1(out returnPointer, this, name);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetArraySetting(const char * name, int status)
// "void SetArraySetting(const char* name, int status)"
public void SetArraySetting(string /*(char*)*/ name, int /*(int)*/ status) {
	VTK_API.API_vtkDataArraySelection.SetArraySetting_0(this, name, status);
}


// void RemoveAllArrays()
// "void RemoveAllArrays()"
public void RemoveAllArrays() {
	VTK_API.API_vtkDataArraySelection.RemoveAllArrays_0(this);
}


// int AddArray(const char * name, bool state = true)
// "int AddArray(const char* name, bool state=true)"
public int AddArray(string /*(char*)*/ name, bool /*(bool)*/ state) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataArraySelection.AddArray_0(out returnPointer, this, name, state);
//	return (int)returnPointer;
	return returnPointer;
}


// void RemoveArrayByIndex(int index)
// "void RemoveArrayByIndex(int index)"
public void RemoveArrayByIndex(int /*(int)*/ index) {
	VTK_API.API_vtkDataArraySelection.RemoveArrayByIndex_0(this, index);
}


// void RemoveArrayByName(const char * name)
// "void RemoveArrayByName(const char* name)"
public void RemoveArrayByName(string /*(char*)*/ name) {
	VTK_API.API_vtkDataArraySelection.RemoveArrayByName_0(this, name);
}


// void SetArrays(const char *const* names, int numArrays)
// "void SetArrays(const char* const* names, int numArrays)"
public void SetArrays(string /*(char*const*)*/ names, int /*(int)*/ numArrays) {
	VTK_API.API_vtkDataArraySelection.SetArrays_0(this, names, numArrays);
}


// void SetArraysWithDefault(const char *const* names, int numArrays, int defaultStatus)
// "void SetArraysWithDefault(const char* const* names, int numArrays, int defaultStatus)"
public void SetArraysWithDefault(string /*(char*const*)*/ names, int /*(int)*/ numArrays, int /*(int)*/ defaultStatus) {
	VTK_API.API_vtkDataArraySelection.SetArraysWithDefault_0(this, names, numArrays, defaultStatus);
}


// void CopySelections(vtkDataArraySelection * selections)
// "void CopySelections(vtkDataArraySelection* selections)"
public void CopySelections(vtkDataArraySelection /*(vtkDataArraySelection*)*/ selections) {
	VTK_API.API_vtkDataArraySelection.CopySelections_0(this, selections);
}


// void Union(vtkDataArraySelection * other)
// "void Union(vtkDataArraySelection* other)"
public void Union(vtkDataArraySelection /*(vtkDataArraySelection*)*/ other) {
	VTK_API.API_vtkDataArraySelection.Union_0(this, other);
}


}
};
