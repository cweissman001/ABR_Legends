

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkTable : vtkDataObject {
		public vtkTable(IntPtr p) : base(p) {}
		public static implicit operator  vtkTable(IntPtr p) {return new vtkTable(p);}
		public static implicit operator  IntPtr(vtkTable o) {return o.GetPtr();}

// static vtkTable* New()
// "static vtkTable* New()"
public static vtkTable New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTable.New_0(out returnPointer);
//	return (vtkTable)(IntPtr)returnPointer;
	return (vtkTable)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTable.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTable.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkTable* SafeDownCast(vtkObjectBase * o)
// "static vtkTable* SafeDownCast(vtkObjectBase *o)"
public static vtkTable SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTable.SafeDownCast_0(out returnPointer, o);
//	return (vtkTable)(IntPtr)returnPointer;
	return (vtkTable)(IntPtr)returnPointer;
}


// vtkTable* NewInstance()
// "vtkTable *NewInstance()"
public vtkTable NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTable.NewInstance_0(out returnPointer, this);
//	return (vtkTable)(IntPtr)returnPointer;
	return (vtkTable)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkTable.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkTable.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual vtkDataSetAttributes* GetRowData()
// "virtual vtkDataSetAttributes *GetRowData ()"
public vtkDataSetAttributes GetRowData() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTable.GetRowData_0(out returnPointer, this);
//	return (vtkDataSetAttributes)(IntPtr)returnPointer;
	return (vtkDataSetAttributes)(IntPtr)returnPointer;
}


// virtual void SetRowData(vtkDataSetAttributes * data)
// "virtual void SetRowData(vtkDataSetAttributes* data)"
public void SetRowData(vtkDataSetAttributes /*(vtkDataSetAttributes*)*/ data) {
	VTK_API.API_vtkTable.SetRowData_0(this, data);
}


// vtkIdType GetNumberOfRows()
// "vtkIdType GetNumberOfRows()"
public long GetNumberOfRows() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkTable.GetNumberOfRows_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void SetNumberOfRows(const vtkIdType ARG_0)
// "void SetNumberOfRows(const vtkIdType )"
public void SetNumberOfRows(long /*(vtkIdType)*/ ARG_0) {
	VTK_API.API_vtkTable.SetNumberOfRows_0(this, ARG_0);
}


// void RemoveRow(vtkIdType row)
// "void RemoveRow(vtkIdType row)"
public void RemoveRow(long /*(vtkIdType)*/ row) {
	VTK_API.API_vtkTable.RemoveRow_0(this, row);
}


// vtkIdType GetNumberOfColumns()
// "vtkIdType GetNumberOfColumns()"
public long GetNumberOfColumns() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkTable.GetNumberOfColumns_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// char* GetColumnName(vtkIdType col)
// "const char* GetColumnName(vtkIdType col)"
public string GetColumnName(long /*(vtkIdType)*/ col) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkTable.GetColumnName_0(out returnPointer, this, col);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// vtkAbstractArray* GetColumnByName(const char * name)
// "vtkAbstractArray* GetColumnByName(const char* name)"
public vtkAbstractArray GetColumnByName(string /*(char*)*/ name) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTable.GetColumnByName_0(out returnPointer, this, name);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* GetColumn(vtkIdType col)
// "vtkAbstractArray* GetColumn(vtkIdType col)"
public vtkAbstractArray GetColumn(long /*(vtkIdType)*/ col) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTable.GetColumn_0(out returnPointer, this, col);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// void AddColumn(vtkAbstractArray * arr)
// "void AddColumn(vtkAbstractArray* arr)"
public void AddColumn(vtkAbstractArray /*(vtkAbstractArray*)*/ arr) {
	VTK_API.API_vtkTable.AddColumn_0(this, arr);
}


// void RemoveColumnByName(const char * name)
// "void RemoveColumnByName(const char* name)"
public void RemoveColumnByName(string /*(char*)*/ name) {
	VTK_API.API_vtkTable.RemoveColumnByName_0(this, name);
}


// void RemoveColumn(vtkIdType col)
// "void RemoveColumn(vtkIdType col)"
public void RemoveColumn(long /*(vtkIdType)*/ col) {
	VTK_API.API_vtkTable.RemoveColumn_0(this, col);
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkTable.Initialize_0(this);
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject* src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkTable.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject* src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkTable.DeepCopy_0(this, src);
}


// vtkFieldData* GetAttributesAsFieldData(int type)
// "vtkFieldData* GetAttributesAsFieldData(int type)"
public vtkFieldData GetAttributesAsFieldData(int /*(int)*/ type) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTable.GetAttributesAsFieldData_0(out returnPointer, this, type);
//	return (vtkFieldData)(IntPtr)returnPointer;
	return (vtkFieldData)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfElements(int type)
// "vtkIdType GetNumberOfElements(int type)"
public long GetNumberOfElements(int /*(int)*/ type) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkTable.GetNumberOfElements_0(out returnPointer, this, type);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
