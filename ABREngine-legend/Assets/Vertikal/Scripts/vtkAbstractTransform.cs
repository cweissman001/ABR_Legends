

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractTransform : vtkObject {
		public vtkAbstractTransform(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractTransform(IntPtr p) {return new vtkAbstractTransform(p);}
		public static implicit operator  IntPtr(vtkAbstractTransform o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractTransform.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractTransform.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAbstractTransform* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractTransform* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractTransform SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractTransform.SafeDownCast_0(out returnPointer, o);
//	return (vtkAbstractTransform)(IntPtr)returnPointer;
	return (vtkAbstractTransform)(IntPtr)returnPointer;
}


// vtkAbstractTransform* NewInstance()
// "vtkAbstractTransform *NewInstance()"
public vtkAbstractTransform NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractTransform.NewInstance_0(out returnPointer, this);
//	return (vtkAbstractTransform)(IntPtr)returnPointer;
	return (vtkAbstractTransform)(IntPtr)returnPointer;
}


// void TransformPoint(const float in[3], float out[3])
// "void TransformPoint(const float in[3], float out[3])"
public void TransformPoint(float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var) {
	VTK_API.API_vtkAbstractTransform.TransformPoint_0(this, in_var, out_var);
}


// void TransformPoint(const double in[3], double out[3])
// "void TransformPoint(const double in[3], double out[3])"
public void TransformPoint(double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var) {
	VTK_API.API_vtkAbstractTransform.TransformPoint_1(this, in_var, out_var);
}


// double* TransformPoint(double x, double y, double z)
// "double *TransformPoint(double x, double y, double z)"
public double[] TransformPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractTransform.TransformPoint_2(out returnPointer, this, x, y, z);
//	return (double)returnPointer;
	return returnPointer;
}


// double* TransformPoint(const double point[3])
// "double *TransformPoint(const double point[3])"
public double[] TransformPoint(double /*(double[3])*/ []point) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractTransform.TransformPoint_3(out returnPointer, this, point);
//	return (double)returnPointer;
	return returnPointer;
}


// float* TransformFloatPoint(float x, float y, float z)
// "float *TransformFloatPoint(float x, float y, float z)"
public float[] TransformFloatPoint(float /*(float)*/ x, float /*(float)*/ y, float /*(float)*/ z) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkAbstractTransform.TransformFloatPoint_0(out returnPointer, this, x, y, z);
//	return (float)returnPointer;
	return returnPointer;
}


// float* TransformFloatPoint(const float point[3])
// "float *TransformFloatPoint(const float point[3])"
public float[] TransformFloatPoint(float /*(float[3])*/ []point) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkAbstractTransform.TransformFloatPoint_1(out returnPointer, this, point);
//	return (float)returnPointer;
	return returnPointer;
}


// double* TransformDoublePoint(double x, double y, double z)
// "double *TransformDoublePoint(double x, double y, double z)"
public double[] TransformDoublePoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractTransform.TransformDoublePoint_0(out returnPointer, this, x, y, z);
//	return (double)returnPointer;
	return returnPointer;
}


// double* TransformDoublePoint(const double point[3])
// "double *TransformDoublePoint(const double point[3])"
public double[] TransformDoublePoint(double /*(double[3])*/ []point) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractTransform.TransformDoublePoint_1(out returnPointer, this, point);
//	return (double)returnPointer;
	return returnPointer;
}


// void TransformNormalAtPoint(const float point[3], const float in[3], float out[3])
// "void TransformNormalAtPoint(const float point[3], const float in[3], float out[3])"
public void TransformNormalAtPoint(float /*(float[3])*/ []point, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var) {
	VTK_API.API_vtkAbstractTransform.TransformNormalAtPoint_0(this, point, in_var, out_var);
}


// void TransformNormalAtPoint(const double point[3], const double in[3], double out[3])
// "void TransformNormalAtPoint(const double point[3], const double in[3], double out[3])"
public void TransformNormalAtPoint(double /*(double[3])*/ []point, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var) {
	VTK_API.API_vtkAbstractTransform.TransformNormalAtPoint_1(this, point, in_var, out_var);
}


// double* TransformNormalAtPoint(const double point[3], const double normal[3])
// "double *TransformNormalAtPoint(const double point[3], const double normal[3])"
public double[] TransformNormalAtPoint(double /*(double[3])*/ []point, double /*(double[3])*/ []normal) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractTransform.TransformNormalAtPoint_2(out returnPointer, this, point, normal);
//	return (double)returnPointer;
	return returnPointer;
}


// double* TransformDoubleNormalAtPoint(const double point[3], const double normal[3])
// "double *TransformDoubleNormalAtPoint(const double point[3], const double normal[3])"
public double[] TransformDoubleNormalAtPoint(double /*(double[3])*/ []point, double /*(double[3])*/ []normal) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractTransform.TransformDoubleNormalAtPoint_0(out returnPointer, this, point, normal);
//	return (double)returnPointer;
	return returnPointer;
}


// float* TransformFloatNormalAtPoint(const float point[3], const float normal[3])
// "float *TransformFloatNormalAtPoint(const float point[3], const float normal[3])"
public float[] TransformFloatNormalAtPoint(float /*(float[3])*/ []point, float /*(float[3])*/ []normal) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkAbstractTransform.TransformFloatNormalAtPoint_0(out returnPointer, this, point, normal);
//	return (float)returnPointer;
	return returnPointer;
}


// void TransformVectorAtPoint(const float point[3], const float in[3], float out[3])
// "void TransformVectorAtPoint(const float point[3], const float in[3], float out[3])"
public void TransformVectorAtPoint(float /*(float[3])*/ []point, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var) {
	VTK_API.API_vtkAbstractTransform.TransformVectorAtPoint_0(this, point, in_var, out_var);
}


// void TransformVectorAtPoint(const double point[3], const double in[3], double out[3])
// "void TransformVectorAtPoint(const double point[3], const double in[3], double out[3])"
public void TransformVectorAtPoint(double /*(double[3])*/ []point, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var) {
	VTK_API.API_vtkAbstractTransform.TransformVectorAtPoint_1(this, point, in_var, out_var);
}


// double* TransformVectorAtPoint(const double point[3], const double vector[3])
// "double *TransformVectorAtPoint(const double point[3], const double vector[3])"
public double[] TransformVectorAtPoint(double /*(double[3])*/ []point, double /*(double[3])*/ []vector) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractTransform.TransformVectorAtPoint_2(out returnPointer, this, point, vector);
//	return (double)returnPointer;
	return returnPointer;
}


// double* TransformDoubleVectorAtPoint(const double point[3], const double vector[3])
// "double *TransformDoubleVectorAtPoint(const double point[3], const double vector[3])"
public double[] TransformDoubleVectorAtPoint(double /*(double[3])*/ []point, double /*(double[3])*/ []vector) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractTransform.TransformDoubleVectorAtPoint_0(out returnPointer, this, point, vector);
//	return (double)returnPointer;
	return returnPointer;
}


// float* TransformFloatVectorAtPoint(const float point[3], const float vector[3])
// "float *TransformFloatVectorAtPoint(const float point[3], const float vector[3])"
public float[] TransformFloatVectorAtPoint(float /*(float[3])*/ []point, float /*(float[3])*/ []vector) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkAbstractTransform.TransformFloatVectorAtPoint_0(out returnPointer, this, point, vector);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual void TransformPoints(vtkPoints * inPts, vtkPoints * outPts)
// "virtual void TransformPoints(vtkPoints *inPts, vtkPoints *outPts)"
public void TransformPoints(vtkPoints /*(vtkPoints*)*/ inPts, vtkPoints /*(vtkPoints*)*/ outPts) {
	VTK_API.API_vtkAbstractTransform.TransformPoints_0(this, inPts, outPts);
}


// virtual void TransformPointsNormalsVectors(vtkPoints * inPts, vtkPoints * outPts, vtkDataArray * inNms, vtkDataArray * outNms, vtkDataArray * inVrs, vtkDataArray * outVrs, int nOptionalVectors = 0, vtkDataArray ** inVrsArr = nullptr, vtkDataArray ** outVrsArr = nullptr)
// "virtual void TransformPointsNormalsVectors(vtkPoints *inPts, vtkPoints *outPts, vtkDataArray *inNms, vtkDataArray *outNms, vtkDataArray *inVrs, vtkDataArray *outVrs, int nOptionalVectors = 0, vtkDataArray** inVrsArr = nullptr, vtkDataArray** outVrsArr = nullptr)"
public void TransformPointsNormalsVectors(vtkPoints /*(vtkPoints*)*/ inPts, vtkPoints /*(vtkPoints*)*/ outPts, vtkDataArray /*(vtkDataArray*)*/ inNms, vtkDataArray /*(vtkDataArray*)*/ outNms, vtkDataArray /*(vtkDataArray*)*/ inVrs, vtkDataArray /*(vtkDataArray*)*/ outVrs, int /*(int)*/ nOptionalVectors, vtkDataArray /*(vtkDataArray**)*/ inVrsArr, vtkDataArray /*(vtkDataArray**)*/ outVrsArr) {
	VTK_API.API_vtkAbstractTransform.TransformPointsNormalsVectors_0(this, inPts, outPts, inNms, outNms, inVrs, outVrs, nOptionalVectors, inVrsArr, outVrsArr);
}


// vtkAbstractTransform* GetInverse()
// "vtkAbstractTransform *GetInverse()"
public vtkAbstractTransform GetInverse() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractTransform.GetInverse_0(out returnPointer, this);
//	return (vtkAbstractTransform)(IntPtr)returnPointer;
	return (vtkAbstractTransform)(IntPtr)returnPointer;
}


// void SetInverse(vtkAbstractTransform * transform)
// "void SetInverse(vtkAbstractTransform *transform)"
public void SetInverse(vtkAbstractTransform /*(vtkAbstractTransform*)*/ transform) {
	VTK_API.API_vtkAbstractTransform.SetInverse_0(this, transform);
}


// virtual void Inverse()
// "virtual void Inverse()"
public void Inverse() {
	VTK_API.API_vtkAbstractTransform.Inverse_0(this);
}


// void DeepCopy(vtkAbstractTransform * ARG_0)
// "void DeepCopy(vtkAbstractTransform *)"
public void DeepCopy(vtkAbstractTransform /*(vtkAbstractTransform*)*/ ARG_0) {
	VTK_API.API_vtkAbstractTransform.DeepCopy_0(this, ARG_0);
}


// void Update()
// "void Update()"
public void Update() {
	VTK_API.API_vtkAbstractTransform.Update_0(this);
}


// virtual void InternalTransformPoint(const float in[3], float out[3])
// "virtual void InternalTransformPoint(const float in[3], float out[3])"
public void InternalTransformPoint(float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var) {
	VTK_API.API_vtkAbstractTransform.InternalTransformPoint_0(this, in_var, out_var);
}


// virtual void InternalTransformPoint(const double in[3], double out[3])
// "virtual void InternalTransformPoint(const double in[3], double out[3])"
public void InternalTransformPoint(double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var) {
	VTK_API.API_vtkAbstractTransform.InternalTransformPoint_1(this, in_var, out_var);
}


// virtual vtkAbstractTransform* MakeTransform()
// "virtual vtkAbstractTransform *MakeTransform()"
public vtkAbstractTransform MakeTransform() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractTransform.MakeTransform_0(out returnPointer, this);
//	return (vtkAbstractTransform)(IntPtr)returnPointer;
	return (vtkAbstractTransform)(IntPtr)returnPointer;
}


// virtual int CircuitCheck(vtkAbstractTransform * transform)
// "virtual int CircuitCheck(vtkAbstractTransform *transform)"
public int CircuitCheck(vtkAbstractTransform /*(vtkAbstractTransform*)*/ transform) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractTransform.CircuitCheck_0(out returnPointer, this, transform);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkAbstractTransform.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void UnRegister(vtkObjectBase * O)
// "void UnRegister(vtkObjectBase *O)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ O) {
	VTK_API.API_vtkAbstractTransform.UnRegister_0(this, O);
}


}
};
