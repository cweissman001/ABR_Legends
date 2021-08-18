

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkVersion : vtkObject {
		public vtkVersion(IntPtr p) : base(p) {}
		public static implicit operator  vtkVersion(IntPtr p) {return new vtkVersion(p);}
		public static implicit operator  IntPtr(vtkVersion o) {return o.GetPtr();}

// static vtkVersion* New()
// "static vtkVersion *New()"
public static vtkVersion New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVersion.New_0(out returnPointer);
//	return (vtkVersion)(IntPtr)returnPointer;
	return (vtkVersion)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkVersion.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkVersion.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkVersion* SafeDownCast(vtkObjectBase * o)
// "static vtkVersion* SafeDownCast(vtkObjectBase *o)"
public static vtkVersion SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVersion.SafeDownCast_0(out returnPointer, o);
//	return (vtkVersion)(IntPtr)returnPointer;
	return (vtkVersion)(IntPtr)returnPointer;
}


// vtkVersion* NewInstance()
// "vtkVersion *NewInstance()"
public vtkVersion NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkVersion.NewInstance_0(out returnPointer, this);
//	return (vtkVersion)(IntPtr)returnPointer;
	return (vtkVersion)(IntPtr)returnPointer;
}


// static char* GetVTKVersion()
// "static const char *GetVTKVersion()"
public static string GetVTKVersion() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkVersion.GetVTKVersion_0(out returnPointer);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// static int GetVTKMajorVersion()
// "static int GetVTKMajorVersion()"
public static int GetVTKMajorVersion() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkVersion.GetVTKMajorVersion_0(out returnPointer);
//	return (int)returnPointer;
	return returnPointer;
}


// static int GetVTKMinorVersion()
// "static int GetVTKMinorVersion()"
public static int GetVTKMinorVersion() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkVersion.GetVTKMinorVersion_0(out returnPointer);
//	return (int)returnPointer;
	return returnPointer;
}


// static int GetVTKBuildVersion()
// "static int GetVTKBuildVersion()"
public static int GetVTKBuildVersion() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkVersion.GetVTKBuildVersion_0(out returnPointer);
//	return (int)returnPointer;
	return returnPointer;
}


// static char* GetVTKSourceVersion()
// "static const char *GetVTKSourceVersion()"
public static string GetVTKSourceVersion() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkVersion.GetVTKSourceVersion_0(out returnPointer);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


}
};
