

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellTypes : vtkObject {
		public vtkCellTypes(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellTypes(IntPtr p) {return new vtkCellTypes(p);}
		public static implicit operator  IntPtr(vtkCellTypes o) {return o.GetPtr();}

// static vtkCellTypes* New()
// "static vtkCellTypes *New()"
public static vtkCellTypes New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellTypes.New_0(out returnPointer);
//	return (vtkCellTypes)(IntPtr)returnPointer;
	return (vtkCellTypes)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCellTypes.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCellTypes.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCellTypes* SafeDownCast(vtkObjectBase * o)
// "static vtkCellTypes* SafeDownCast(vtkObjectBase *o)"
public static vtkCellTypes SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellTypes.SafeDownCast_0(out returnPointer, o);
//	return (vtkCellTypes)(IntPtr)returnPointer;
	return (vtkCellTypes)(IntPtr)returnPointer;
}


// vtkCellTypes* NewInstance()
// "vtkCellTypes *NewInstance()"
public vtkCellTypes NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellTypes.NewInstance_0(out returnPointer, this);
//	return (vtkCellTypes)(IntPtr)returnPointer;
	return (vtkCellTypes)(IntPtr)returnPointer;
}


// int Allocate(int sz = 512, int ext = 1000)
// "int Allocate(int sz=512, int ext=1000)"
public int Allocate(int /*(int)*/ sz, int /*(int)*/ ext) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCellTypes.Allocate_0(out returnPointer, this, sz, ext);
//	return (int)returnPointer;
	return returnPointer;
}


// void InsertCell(vtkIdType id, unsigned char type, vtkIdType loc)
// "void InsertCell(vtkIdType id, unsigned char type, vtkIdType loc)"
public void InsertCell(long /*(vtkIdType)*/ id, char /*(unsigned char)*/ type, long /*(vtkIdType)*/ loc) {
	VTK_API.API_vtkCellTypes.InsertCell_0(this, id, type, loc);
}


// void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray * cellTypes, vtkIdTypeArray * cellLocations)
// "void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray *cellTypes, vtkIdTypeArray *cellLocations)"
public void SetCellTypes(long /*(vtkIdType)*/ ncells, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ cellTypes, vtkIdTypeArray /*(vtkIdTypeArray*)*/ cellLocations) {
	VTK_API.API_vtkCellTypes.SetCellTypes_0(this, ncells, cellTypes, cellLocations);
}


// void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray * cellTypes, vtkIntArray * cellLocations)
// "void SetCellTypes(vtkIdType ncells, vtkUnsignedCharArray *cellTypes, vtkIntArray *cellLocations)"
public void SetCellTypes(long /*(vtkIdType)*/ ncells, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ cellTypes, vtkIntArray /*(vtkIntArray*)*/ cellLocations) {
	VTK_API.API_vtkCellTypes.SetCellTypes_1(this, ncells, cellTypes, cellLocations);
}


// vtkIdType GetCellLocation(vtkIdType cellId)
// "vtkIdType GetCellLocation(vtkIdType cellId)"
public long GetCellLocation(long /*(vtkIdType)*/ cellId) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellTypes.GetCellLocation_0(out returnPointer, this, cellId);
//	return (long)returnPointer;
	return returnPointer;
}


// void DeleteCell(vtkIdType cellId)
// "void DeleteCell(vtkIdType cellId)"
public void DeleteCell(long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkCellTypes.DeleteCell_0(this, cellId);
}


// vtkIdType GetNumberOfTypes()
// "vtkIdType GetNumberOfTypes()"
public long GetNumberOfTypes() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellTypes.GetNumberOfTypes_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// int IsType(unsigned char type)
// "int IsType(unsigned char type)"
public int IsType(char /*(unsigned char)*/ type) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCellTypes.IsType_0(out returnPointer, this, type);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkIdType InsertNextType(unsigned char type)
// "vtkIdType InsertNextType(unsigned char type)"
public long InsertNextType(char /*(unsigned char)*/ type) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellTypes.InsertNextType_0(out returnPointer, this, type);
//	return (long)returnPointer;
	return returnPointer;
}


// char GetCellType(vtkIdType cellId)
// "unsigned char GetCellType(vtkIdType cellId)"
public char GetCellType(long /*(vtkIdType)*/ cellId) {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkCellTypes.GetCellType_0(out returnPointer, this, cellId);
//	return (char)returnPointer;
	return returnPointer;
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkCellTypes.Squeeze_0(this);
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkCellTypes.Reset_0(this);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkCellTypes.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void DeepCopy(vtkCellTypes * src)
// "void DeepCopy(vtkCellTypes *src)"
public void DeepCopy(vtkCellTypes /*(vtkCellTypes*)*/ src) {
	VTK_API.API_vtkCellTypes.DeepCopy_0(this, src);
}


// static char* GetClassNameFromTypeId(int typeId)
// "static const char* GetClassNameFromTypeId(int typeId)"
public static string GetClassNameFromTypeId(int /*(int)*/ typeId) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkCellTypes.GetClassNameFromTypeId_0(out returnPointer, typeId);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// static int GetTypeIdFromClassName(const char * classname)
// "static int GetTypeIdFromClassName(const char* classname)"
public static int GetTypeIdFromClassName(string /*(char*)*/ classname) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCellTypes.GetTypeIdFromClassName_0(out returnPointer, classname);
//	return (int)returnPointer;
	return returnPointer;
}


// static int IsLinear(unsigned char type)
// "static int IsLinear(unsigned char type)"
public static int IsLinear(char /*(unsigned char)*/ type) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCellTypes.IsLinear_0(out returnPointer, type);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
