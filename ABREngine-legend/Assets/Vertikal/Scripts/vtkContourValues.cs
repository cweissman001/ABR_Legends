

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkContourValues : vtkObject {
		public vtkContourValues(IntPtr p) : base(p) {}
		public static implicit operator  vtkContourValues(IntPtr p) {return new vtkContourValues(p);}
		public static implicit operator  IntPtr(vtkContourValues o) {return o.GetPtr();}

// static vtkContourValues* New()
// "static vtkContourValues *New()"
public static vtkContourValues New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkContourValues.New_0(returnPointer.GetPtr());
	return (vtkContourValues)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkContourValues.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkContourValues.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkContourValues* SafeDownCast(vtkObjectBase * o)
// "static vtkContourValues* SafeDownCast(vtkObjectBase *o)"
public static vtkContourValues SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkContourValues.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkContourValues)(IntPtr)returnPointer;
}


// vtkContourValues* NewInstance()
// "vtkContourValues *NewInstance()"
public vtkContourValues NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkContourValues.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkContourValues)(IntPtr)returnPointer;
}


// void SetValue(int i, double value)
// "void SetValue(int i, double value)"
public void SetValue(int /*(int)*/ i, double /*(double)*/ value) {
	VTK_API.API_vtkContourValues.SetValue_0(this, i, value);
}


// double GetValue(int i)
// "double GetValue(int i)"
public double GetValue(int /*(int)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkContourValues.GetValue_0(returnPointer.GetPtr(), this, i);
	return (double)returnPointer;
}


// double* GetValues()
// "double *GetValues()"
public IntPtr GetValues() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkContourValues.GetValues_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetValues(double * contourValues)
// "void GetValues(double *contourValues)"
public void GetValues(IntPtr /*(double*)*/ contourValues) {
	VTK_API.API_vtkContourValues.GetValues_1(this, contourValues);
}


// void SetNumberOfContours(const int number)
// "void SetNumberOfContours(const int number)"
public void SetNumberOfContours(int /*(int)*/ number) {
	VTK_API.API_vtkContourValues.SetNumberOfContours_0(this, number);
}


// int GetNumberOfContours()
// "int GetNumberOfContours()"
public int GetNumberOfContours() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkContourValues.GetNumberOfContours_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void GenerateValues(int numContours, double range[2])
// "void GenerateValues(int numContours, double range[2])"
public void GenerateValues(int /*(int)*/ numContours, double /*(double[2])*/ []range) {
	VTK_API.API_vtkContourValues.GenerateValues_0(this, numContours, range);
}


// void GenerateValues(int numContours, double rangeStart, double rangeEnd)
// "void GenerateValues(int numContours, double rangeStart, double rangeEnd)"
public void GenerateValues(int /*(int)*/ numContours, double /*(double)*/ rangeStart, double /*(double)*/ rangeEnd) {
	VTK_API.API_vtkContourValues.GenerateValues_1(this, numContours, rangeStart, rangeEnd);
}


// void DeepCopy(vtkContourValues * other)
// "void DeepCopy(vtkContourValues* other)"
public void DeepCopy(vtkContourValues /*(vtkContourValues*)*/ other) {
	VTK_API.API_vtkContourValues.DeepCopy_0(this, other);
}


}
};
