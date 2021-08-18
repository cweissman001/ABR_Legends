

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPointSet : vtkDataSet {
		public vtkPointSet(IntPtr p) : base(p) {}
		public static implicit operator  vtkPointSet(IntPtr p) {return new vtkPointSet(p);}
		public static implicit operator  IntPtr(vtkPointSet o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPointSet.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPointSet.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkPointSet* SafeDownCast(vtkObjectBase * o)
// "static vtkPointSet* SafeDownCast(vtkObjectBase *o)"
public static vtkPointSet SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPointSet.SafeDownCast_0(out returnPointer, o);
//	return (vtkPointSet)(IntPtr)returnPointer;
	return (vtkPointSet)(IntPtr)returnPointer;
}


// vtkPointSet* NewInstance()
// "vtkPointSet *NewInstance()"
public vtkPointSet NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPointSet.NewInstance_0(out returnPointer, this);
//	return (vtkPointSet)(IntPtr)returnPointer;
	return (vtkPointSet)(IntPtr)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkPointSet.Initialize_0(this);
}


// void CopyStructure(vtkDataSet * pd)
// "void CopyStructure(vtkDataSet *pd)"
public void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ pd) {
	VTK_API.API_vtkPointSet.CopyStructure_0(this, pd);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPointSet.GetNumberOfPoints_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void GetPoint(vtkIdType ptId, double x[3])
// "void GetPoint(vtkIdType ptId, double x[3])"
public void GetPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x) {
	VTK_API.API_vtkPointSet.GetPoint_0(this, ptId, x);
}


// vtkIdType FindPoint(double x[3])
// "vtkIdType FindPoint(double x[3])"
public long FindPoint(double /*(double[3])*/ []x) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPointSet.FindPoint_0(out returnPointer, this, x);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType FindPoint(double x, double y, double z)
// "vtkIdType FindPoint(double x, double y, double z)"
public long FindPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPointSet.FindPoint_1(out returnPointer, this, x, y, z);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "vtkIdType FindCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPointSet.FindCell_0(out returnPointer, this, x, cell, cellId, tol2, subId, pcoords, weights);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "vtkIdType FindCell(double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, vtkGenericCell /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPointSet.FindCell_1(out returnPointer, this, x, cell, gencell, cellId, tol2, subId, pcoords, weights);
//	return (long)returnPointer;
	return returnPointer;
}


// double* GetPoint(vtkIdType ptId)
// "double *GetPoint(vtkIdType ptId)"
public double[] GetPoint(long /*(vtkIdType)*/ ptId) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkPointSet.GetPoint_1(out returnPointer, this, ptId);
//	return (double)returnPointer;
	return returnPointer;
}


// vtkCellIterator* NewCellIterator()
// "vtkCellIterator* NewCellIterator()"
public vtkCellIterator NewCellIterator() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPointSet.NewCellIterator_0(out returnPointer, this);
//	return (vtkCellIterator)(IntPtr)returnPointer;
	return (vtkCellIterator)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkPointSet.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void ComputeBounds()
// "void ComputeBounds()"
public void ComputeBounds() {
	VTK_API.API_vtkPointSet.ComputeBounds_0(this);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkPointSet.Squeeze_0(this);
}


// virtual void SetPoints(vtkPoints * ARG_0)
// "virtual void SetPoints(vtkPoints*)"
public void SetPoints(vtkPoints /*(vtkPoints*)*/ ARG_0) {
	VTK_API.API_vtkPointSet.SetPoints_0(this, ARG_0);
}


// virtual vtkPoints* GetPoints()
// "virtual vtkPoints *GetPoints ()"
public vtkPoints GetPoints() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPointSet.GetPoints_0(out returnPointer, this);
//	return (vtkPoints)(IntPtr)returnPointer;
	return (vtkPoints)(IntPtr)returnPointer;
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkPointSet.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkPointSet.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkPointSet.DeepCopy_0(this, src);
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase* o)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkPointSet.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase* o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkPointSet.UnRegister_0(this, o);
}


}
};
