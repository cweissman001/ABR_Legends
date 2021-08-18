

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLightCollection : vtkCollection {
		public vtkLightCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkLightCollection(IntPtr p) {return new vtkLightCollection(p);}
		public static implicit operator  IntPtr(vtkLightCollection o) {return o.GetPtr();}

// static vtkLightCollection* New()
// "static vtkLightCollection *New()"
public static vtkLightCollection New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkLightCollection.New_0(out returnPointer);
//	return (vtkLightCollection)(IntPtr)returnPointer;
	return (vtkLightCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkLightCollection.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkLightCollection.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkLightCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkLightCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkLightCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkLightCollection.SafeDownCast_0(out returnPointer, o);
//	return (vtkLightCollection)(IntPtr)returnPointer;
	return (vtkLightCollection)(IntPtr)returnPointer;
}


// vtkLightCollection* NewInstance()
// "vtkLightCollection *NewInstance()"
public vtkLightCollection NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkLightCollection.NewInstance_0(out returnPointer, this);
//	return (vtkLightCollection)(IntPtr)returnPointer;
	return (vtkLightCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkLight * a)
// "void AddItem(vtkLight *a)"
public void AddItem(vtkLight /*(vtkLight*)*/ a) {
	VTK_API.API_vtkLightCollection.AddItem_0(this, a);
}


// vtkLight* GetNextItem()
// "vtkLight *GetNextItem()"
public vtkLight GetNextItem() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkLightCollection.GetNextItem_0(out returnPointer, this);
//	return (vtkLight)(IntPtr)returnPointer;
	return (vtkLight)(IntPtr)returnPointer;
}


}
};
