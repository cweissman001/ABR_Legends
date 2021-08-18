

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractMapper3D : vtkAbstractMapper {
		public vtkAbstractMapper3D(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractMapper3D(IntPtr p) {return new vtkAbstractMapper3D(p);}
		public static implicit operator  IntPtr(vtkAbstractMapper3D o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractMapper3D.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractMapper3D.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAbstractMapper3D* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractMapper3D* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractMapper3D SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractMapper3D.SafeDownCast_0(out returnPointer, o);
//	return (vtkAbstractMapper3D)(IntPtr)returnPointer;
	return (vtkAbstractMapper3D)(IntPtr)returnPointer;
}


// vtkAbstractMapper3D* NewInstance()
// "vtkAbstractMapper3D *NewInstance()"
public vtkAbstractMapper3D NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractMapper3D.NewInstance_0(out returnPointer, this);
//	return (vtkAbstractMapper3D)(IntPtr)returnPointer;
	return (vtkAbstractMapper3D)(IntPtr)returnPointer;
}


// virtual double* GetBounds()
// "virtual double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractMapper3D.GetBounds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetBounds(double bounds[6])
// "virtual void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkAbstractMapper3D.GetBounds_1(this, bounds);
}


// double* GetCenter()
// "double *GetCenter()"
public double[] GetCenter() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractMapper3D.GetCenter_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetCenter(double center[3])
// "void GetCenter(double center[3])"
public void GetCenter(double /*(double[3])*/ []center) {
	VTK_API.API_vtkAbstractMapper3D.GetCenter_1(this, center);
}


// double GetLength()
// "double GetLength()"
public double GetLength() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkAbstractMapper3D.GetLength_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual vtkTypeBool IsARayCastMapper()
// "virtual vtkTypeBool IsARayCastMapper()"
public bool IsARayCastMapper() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractMapper3D.IsARayCastMapper_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual vtkTypeBool IsARenderIntoImageMapper()
// "virtual vtkTypeBool IsARenderIntoImageMapper()"
public bool IsARenderIntoImageMapper() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractMapper3D.IsARenderIntoImageMapper_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// void GetClippingPlaneInDataCoords(vtkMatrix4x4 * propMatrix, int i, double planeEquation[4])
// "void GetClippingPlaneInDataCoords( vtkMatrix4x4 *propMatrix, int i, double planeEquation[4])"
public void GetClippingPlaneInDataCoords(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ propMatrix, int /*(int)*/ i, double /*(double[4])*/ []planeEquation) {
	VTK_API.API_vtkAbstractMapper3D.GetClippingPlaneInDataCoords_0(this, propMatrix, i, planeEquation);
}


}
};
