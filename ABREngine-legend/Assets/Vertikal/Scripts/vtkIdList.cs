

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIdList : vtkObject {
		public vtkIdList(IntPtr p) : base(p) {}
		public static implicit operator  vtkIdList(IntPtr p) {return new vtkIdList(p);}
		public static implicit operator  IntPtr(vtkIdList o) {return o.GetPtr();}

// static vtkIdList* New()
// "static vtkIdList *New()"
public static vtkIdList New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIdList.New_0(out returnPointer);
//	return (vtkIdList)(IntPtr)returnPointer;
	return (vtkIdList)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkIdList.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkIdList.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkIdList* SafeDownCast(vtkObjectBase * o)
// "static vtkIdList* SafeDownCast(vtkObjectBase *o)"
public static vtkIdList SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIdList.SafeDownCast_0(out returnPointer, o);
//	return (vtkIdList)(IntPtr)returnPointer;
	return (vtkIdList)(IntPtr)returnPointer;
}


// vtkIdList* NewInstance()
// "vtkIdList *NewInstance()"
public vtkIdList NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIdList.NewInstance_0(out returnPointer, this);
//	return (vtkIdList)(IntPtr)returnPointer;
	return (vtkIdList)(IntPtr)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkIdList.Initialize_0(this);
}


// int Allocate(const vtkIdType sz, const int strategy = 0)
// "int Allocate(const vtkIdType sz, const int strategy=0)"
public int Allocate(long /*(vtkIdType)*/ sz, int /*(int)*/ strategy) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkIdList.Allocate_0(out returnPointer, this, sz, strategy);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfIds()
// "vtkIdType GetNumberOfIds()"
public long GetNumberOfIds() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIdList.GetNumberOfIds_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetId(const vtkIdType i)
// "vtkIdType GetId(const vtkIdType i)"
public long GetId(long /*(vtkIdType)*/ i) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIdList.GetId_0(out returnPointer, this, i);
//	return (long)returnPointer;
	return returnPointer;
}


// void SetNumberOfIds(const vtkIdType number)
// "void SetNumberOfIds(const vtkIdType number)"
public void SetNumberOfIds(long /*(vtkIdType)*/ number) {
	VTK_API.API_vtkIdList.SetNumberOfIds_0(this, number);
}


// void SetId(const vtkIdType i, const vtkIdType vtkid)
// "void SetId(const vtkIdType i, const vtkIdType vtkid)"
public void SetId(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ vtkid) {
	VTK_API.API_vtkIdList.SetId_0(this, i, vtkid);
}


// void InsertId(const vtkIdType i, const vtkIdType vtkid)
// "void InsertId(const vtkIdType i, const vtkIdType vtkid)"
public void InsertId(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ vtkid) {
	VTK_API.API_vtkIdList.InsertId_0(this, i, vtkid);
}


// vtkIdType InsertNextId(const vtkIdType vtkid)
// "vtkIdType InsertNextId(const vtkIdType vtkid)"
public long InsertNextId(long /*(vtkIdType)*/ vtkid) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIdList.InsertNextId_0(out returnPointer, this, vtkid);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType InsertUniqueId(const vtkIdType vtkid)
// "vtkIdType InsertUniqueId(const vtkIdType vtkid)"
public long InsertUniqueId(long /*(vtkIdType)*/ vtkid) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIdList.InsertUniqueId_0(out returnPointer, this, vtkid);
//	return (long)returnPointer;
	return returnPointer;
}


// void Sort()
// "void Sort()"
public void Sort() {
	VTK_API.API_vtkIdList.Sort_0(this);
}


// vtkIdType* GetPointer(const vtkIdType i)
// "vtkIdType *GetPointer(const vtkIdType i)"
public long[] GetPointer(long /*(vtkIdType)*/ i) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long[] returnPointer = new long[1];
	VTK_API.API_vtkIdList.GetPointer_0(out returnPointer, this, i);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType* WritePointer(const vtkIdType i, const vtkIdType number)
// "vtkIdType *WritePointer(const vtkIdType i, const vtkIdType number)"
public long[] WritePointer(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ number) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long[] returnPointer = new long[1];
	VTK_API.API_vtkIdList.WritePointer_0(out returnPointer, this, i, number);
//	return (long)returnPointer;
	return returnPointer;
}


// void SetArray(vtkIdType * array, vtkIdType size)
// "void SetArray(vtkIdType *array, vtkIdType size)"
public void SetArray(long /*(vtkIdType*)*/ []array, long /*(vtkIdType)*/ size) {
	VTK_API.API_vtkIdList.SetArray_0(this, array, size);
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkIdList.Reset_0(this);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkIdList.Squeeze_0(this);
}


// void DeepCopy(vtkIdList * ids)
// "void DeepCopy(vtkIdList *ids)"
public void DeepCopy(vtkIdList /*(vtkIdList*)*/ ids) {
	VTK_API.API_vtkIdList.DeepCopy_0(this, ids);
}


// void DeleteId(vtkIdType vtkid)
// "void DeleteId(vtkIdType vtkid)"
public void DeleteId(long /*(vtkIdType)*/ vtkid) {
	VTK_API.API_vtkIdList.DeleteId_0(this, vtkid);
}


// vtkIdType IsId(vtkIdType vtkid)
// "vtkIdType IsId(vtkIdType vtkid)"
public long IsId(long /*(vtkIdType)*/ vtkid) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIdList.IsId_0(out returnPointer, this, vtkid);
//	return (long)returnPointer;
	return returnPointer;
}


// void IntersectWith(vtkIdList * otherIds)
// "void IntersectWith(vtkIdList* otherIds)"
public void IntersectWith(vtkIdList /*(vtkIdList*)*/ otherIds) {
	VTK_API.API_vtkIdList.IntersectWith_0(this, otherIds);
}


// vtkIdType* Resize(const vtkIdType sz)
// "vtkIdType *Resize(const vtkIdType sz)"
public long[] Resize(long /*(vtkIdType)*/ sz) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long[] returnPointer = new long[1];
	VTK_API.API_vtkIdList.Resize_0(out returnPointer, this, sz);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
