

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractPointLocator : vtkLocator {
		public vtkAbstractPointLocator(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractPointLocator(IntPtr p) {return new vtkAbstractPointLocator(p);}
		public static implicit operator  IntPtr(vtkAbstractPointLocator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractPointLocator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractPointLocator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAbstractPointLocator* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractPointLocator* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractPointLocator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPointLocator.SafeDownCast_0(out returnPointer, o);
//	return (vtkAbstractPointLocator)(IntPtr)returnPointer;
	return (vtkAbstractPointLocator)(IntPtr)returnPointer;
}


// vtkAbstractPointLocator* NewInstance()
// "vtkAbstractPointLocator *NewInstance()"
public vtkAbstractPointLocator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPointLocator.NewInstance_0(out returnPointer, this);
//	return (vtkAbstractPointLocator)(IntPtr)returnPointer;
	return (vtkAbstractPointLocator)(IntPtr)returnPointer;
}


// virtual vtkIdType FindClosestPoint(const double x[3])
// "virtual vtkIdType FindClosestPoint(const double x[3])"
public long FindClosestPoint(double /*(double[3])*/ []x) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAbstractPointLocator.FindClosestPoint_0(out returnPointer, this, x);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType FindClosestPoint(double x, double y, double z)
// "vtkIdType FindClosestPoint(double x, double y, double z)"
public long FindClosestPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAbstractPointLocator.FindClosestPoint_1(out returnPointer, this, x, y, z);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType FindClosestPointWithinRadius(double radius, const double x[3], double & dist2)
// "virtual vtkIdType FindClosestPointWithinRadius( double radius, const double x[3], double& dist2)"
public long FindClosestPointWithinRadius(double /*(double)*/ radius, double /*(double[3])*/ []x, IntPtr /*(double&)*/ dist2) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAbstractPointLocator.FindClosestPointWithinRadius_0(out returnPointer, this, radius, x, dist2);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void FindClosestNPoints(int N, const double x[3], vtkIdList * result)
// "virtual void FindClosestNPoints( int N, const double x[3], vtkIdList *result)"
public void FindClosestNPoints(int /*(int)*/ N, double /*(double[3])*/ []x, vtkIdList /*(vtkIdList*)*/ result) {
	VTK_API.API_vtkAbstractPointLocator.FindClosestNPoints_0(this, N, x, result);
}


// void FindClosestNPoints(int N, double x, double y, double z, vtkIdList * result)
// "void FindClosestNPoints(int N, double x, double y, double z, vtkIdList *result)"
public void FindClosestNPoints(int /*(int)*/ N, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, vtkIdList /*(vtkIdList*)*/ result) {
	VTK_API.API_vtkAbstractPointLocator.FindClosestNPoints_1(this, N, x, y, z, result);
}


// virtual void FindPointsWithinRadius(double R, const double x[3], vtkIdList * result)
// "virtual void FindPointsWithinRadius(double R, const double x[3], vtkIdList *result)"
public void FindPointsWithinRadius(double /*(double)*/ R, double /*(double[3])*/ []x, vtkIdList /*(vtkIdList*)*/ result) {
	VTK_API.API_vtkAbstractPointLocator.FindPointsWithinRadius_0(this, R, x, result);
}


// void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList * result)
// "void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList *result)"
public void FindPointsWithinRadius(double /*(double)*/ R, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, vtkIdList /*(vtkIdList*)*/ result) {
	VTK_API.API_vtkAbstractPointLocator.FindPointsWithinRadius_1(this, R, x, y, z, result);
}


// virtual double* GetBounds()
// "virtual double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractPointLocator.GetBounds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetBounds(double * ARG_0)
// "virtual void GetBounds(double*)"
public void GetBounds(double /*(double*)*/ []ARG_0) {
	VTK_API.API_vtkAbstractPointLocator.GetBounds_1(this, ARG_0);
}


// virtual vtkIdType GetNumberOfBuckets()
// "virtual vtkIdType GetNumberOfBuckets ()"
public long GetNumberOfBuckets() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAbstractPointLocator.GetNumberOfBuckets_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
