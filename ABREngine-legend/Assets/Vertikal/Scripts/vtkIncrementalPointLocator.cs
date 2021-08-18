

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIncrementalPointLocator : vtkAbstractPointLocator {
		public vtkIncrementalPointLocator(IntPtr p) : base(p) {}
		public static implicit operator  vtkIncrementalPointLocator(IntPtr p) {return new vtkIncrementalPointLocator(p);}
		public static implicit operator  IntPtr(vtkIncrementalPointLocator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkIncrementalPointLocator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkIncrementalPointLocator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkIncrementalPointLocator* SafeDownCast(vtkObjectBase * o)
// "static vtkIncrementalPointLocator* SafeDownCast(vtkObjectBase *o)"
public static vtkIncrementalPointLocator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIncrementalPointLocator.SafeDownCast_0(out returnPointer, o);
//	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
}


// vtkIncrementalPointLocator* NewInstance()
// "vtkIncrementalPointLocator *NewInstance()"
public vtkIncrementalPointLocator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIncrementalPointLocator.NewInstance_0(out returnPointer, this);
//	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
}


// virtual vtkIdType FindClosestInsertedPoint(const double x[3])
// "virtual vtkIdType FindClosestInsertedPoint( const double x[3] )"
public long FindClosestInsertedPoint(double /*(double[3])*/ []x) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIncrementalPointLocator.FindClosestInsertedPoint_0(out returnPointer, this, x);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual int InitPointInsertion(vtkPoints * newPts, const double bounds[6])
// "virtual int InitPointInsertion( vtkPoints * newPts, const double bounds[6] )"
public int InitPointInsertion(vtkPoints /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkIncrementalPointLocator.InitPointInsertion_0(out returnPointer, this, newPts, bounds);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int InitPointInsertion(vtkPoints * newPts, const double bounds[6], vtkIdType estSize)
// "virtual int InitPointInsertion( vtkPoints * newPts, const double bounds[6], vtkIdType estSize )"
public int InitPointInsertion(vtkPoints /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds, long /*(vtkIdType)*/ estSize) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkIncrementalPointLocator.InitPointInsertion_1(out returnPointer, this, newPts, bounds, estSize);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkIdType IsInsertedPoint(double x, double y, double z)
// "virtual vtkIdType IsInsertedPoint( double x, double y, double z )"
public long IsInsertedPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIncrementalPointLocator.IsInsertedPoint_0(out returnPointer, this, x, y, z);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType IsInsertedPoint(const double x[3])
// "virtual vtkIdType IsInsertedPoint( const double x[3] )"
public long IsInsertedPoint(double /*(double[3])*/ []x) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIncrementalPointLocator.IsInsertedPoint_1(out returnPointer, this, x);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual int InsertUniquePoint(const double x[3], vtkIdType & ptId)
// "virtual int InsertUniquePoint( const double x[3], vtkIdType & ptId )"
public int InsertUniquePoint(double /*(double[3])*/ []x, IntPtr /*(vtkIdType&)*/ ptId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkIncrementalPointLocator.InsertUniquePoint_0(out returnPointer, this, x, ptId);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void InsertPoint(vtkIdType ptId, const double x[3])
// "virtual void InsertPoint( vtkIdType ptId, const double x[3] )"
public void InsertPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x) {
	VTK_API.API_vtkIncrementalPointLocator.InsertPoint_0(this, ptId, x);
}


// virtual vtkIdType InsertNextPoint(const double x[3])
// "virtual vtkIdType InsertNextPoint( const double x[3] )"
public long InsertNextPoint(double /*(double[3])*/ []x) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIncrementalPointLocator.InsertNextPoint_0(out returnPointer, this, x);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
