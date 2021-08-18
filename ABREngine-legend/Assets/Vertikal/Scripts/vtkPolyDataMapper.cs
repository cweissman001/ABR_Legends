

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPolyDataMapper : vtkMapper {
		public vtkPolyDataMapper(IntPtr p) : base(p) {}
		public static implicit operator  vtkPolyDataMapper(IntPtr p) {return new vtkPolyDataMapper(p);}
		public static implicit operator  IntPtr(vtkPolyDataMapper o) {return o.GetPtr();}

// static vtkPolyDataMapper* New()
// "static vtkPolyDataMapper *New()"
public static vtkPolyDataMapper New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyDataMapper.New_0(out returnPointer);
//	return (vtkPolyDataMapper)(IntPtr)returnPointer;
	return (vtkPolyDataMapper)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataMapper.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataMapper.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkPolyDataMapper* SafeDownCast(vtkObjectBase * o)
// "static vtkPolyDataMapper* SafeDownCast(vtkObjectBase *o)"
public static vtkPolyDataMapper SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyDataMapper.SafeDownCast_0(out returnPointer, o);
//	return (vtkPolyDataMapper)(IntPtr)returnPointer;
	return (vtkPolyDataMapper)(IntPtr)returnPointer;
}


// vtkPolyDataMapper* NewInstance()
// "vtkPolyDataMapper *NewInstance()"
public vtkPolyDataMapper NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyDataMapper.NewInstance_0(out returnPointer, this);
//	return (vtkPolyDataMapper)(IntPtr)returnPointer;
	return (vtkPolyDataMapper)(IntPtr)returnPointer;
}


// virtual void RenderPiece(vtkRenderer * ren, vtkActor * act)
// "virtual void RenderPiece(vtkRenderer *ren, vtkActor *act)"
public void RenderPiece(vtkRenderer /*(vtkRenderer*)*/ ren, vtkActor /*(vtkActor*)*/ act) {
	VTK_API.API_vtkPolyDataMapper.RenderPiece_0(this, ren, act);
}


// void Render(vtkRenderer * ren, vtkActor * act)
// "void Render(vtkRenderer *ren, vtkActor *act)"
public void Render(vtkRenderer /*(vtkRenderer*)*/ ren, vtkActor /*(vtkActor*)*/ act) {
	VTK_API.API_vtkPolyDataMapper.Render_0(this, ren, act);
}


// void SetInputData(vtkPolyData * in)
// "void SetInputData(vtkPolyData *in)"
public void SetInputData(vtkPolyData /*(vtkPolyData*)*/ in_var) {
	VTK_API.API_vtkPolyDataMapper.SetInputData_0(this, in_var);
}


// vtkPolyData* GetInput()
// "vtkPolyData *GetInput()"
public vtkPolyData GetInput() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyDataMapper.GetInput_0(out returnPointer, this);
//	return (vtkPolyData)(IntPtr)returnPointer;
	return (vtkPolyData)(IntPtr)returnPointer;
}


// void Update(int port)
// "void Update(int port)"
public void Update(int /*(int)*/ port) {
	VTK_API.API_vtkPolyDataMapper.Update_0(this, port);
}


// void Update()
// "void Update()"
public void Update() {
	VTK_API.API_vtkPolyDataMapper.Update_1(this);
}


// virtual void SetPiece(int _arg)
// "virtual void SetPiece (int _arg)"
public void SetPiece(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataMapper.SetPiece_0(this, _arg);
}


// virtual int GetPiece()
// "virtual int GetPiece ()"
public int GetPiece() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyDataMapper.GetPiece_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetNumberOfPieces(int _arg)
// "virtual void SetNumberOfPieces (int _arg)"
public void SetNumberOfPieces(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataMapper.SetNumberOfPieces_0(this, _arg);
}


// virtual int GetNumberOfPieces()
// "virtual int GetNumberOfPieces ()"
public int GetNumberOfPieces() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyDataMapper.GetNumberOfPieces_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetNumberOfSubPieces(int _arg)
// "virtual void SetNumberOfSubPieces (int _arg)"
public void SetNumberOfSubPieces(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataMapper.SetNumberOfSubPieces_0(this, _arg);
}


// virtual int GetNumberOfSubPieces()
// "virtual int GetNumberOfSubPieces ()"
public int GetNumberOfSubPieces() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyDataMapper.GetNumberOfSubPieces_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetGhostLevel(int _arg)
// "virtual void SetGhostLevel (int _arg)"
public void SetGhostLevel(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataMapper.SetGhostLevel_0(this, _arg);
}


// virtual int GetGhostLevel()
// "virtual int GetGhostLevel ()"
public int GetGhostLevel() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyDataMapper.GetGhostLevel_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// double* GetBounds()
// "double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkPolyDataMapper.GetBounds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkPolyDataMapper.GetBounds_1(this, bounds);
}


// void ShallowCopy(vtkAbstractMapper * m)
// "void ShallowCopy(vtkAbstractMapper *m)"
public void ShallowCopy(vtkAbstractMapper /*(vtkAbstractMapper*)*/ m) {
	VTK_API.API_vtkPolyDataMapper.ShallowCopy_0(this, m);
}


// virtual void RemoveVertexAttributeMapping(const char * vertexAttributeName)
// "virtual void RemoveVertexAttributeMapping(const char* vertexAttributeName)"
public void RemoveVertexAttributeMapping(string /*(char*)*/ vertexAttributeName) {
	VTK_API.API_vtkPolyDataMapper.RemoveVertexAttributeMapping_0(this, vertexAttributeName);
}


// virtual void RemoveAllVertexAttributeMappings()
// "virtual void RemoveAllVertexAttributeMappings()"
public void RemoveAllVertexAttributeMappings() {
	VTK_API.API_vtkPolyDataMapper.RemoveAllVertexAttributeMappings_0(this);
}


}
};
