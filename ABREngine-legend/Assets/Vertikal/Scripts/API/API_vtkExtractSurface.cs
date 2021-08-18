
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkExtractSurface {

// static vtkExtractSurface* New()
// static vtkExtractSurface *New()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkExtractSurface*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkExtractSurface*)*/ callingObject, string /*(char*)*/ type);

// static vtkExtractSurface* SafeDownCast(vtkObjectBase * o)
// static vtkExtractSurface* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkExtractSurface*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkExtractSurface* NewInstance()
// vtkExtractSurface *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkExtractSurface*)*/ return_value, IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual void SetRadius(double _arg)
// virtual void SetRadius (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_SetRadius_0")] public static extern 
bool SetRadius_0(IntPtr /*(vtkExtractSurface*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetRadiusMinValue()
// virtual double GetRadiusMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_GetRadiusMinValue_0")] public static extern 
bool GetRadiusMinValue_0(out double /*(double)*/ return_value, IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual double GetRadiusMaxValue()
// virtual double GetRadiusMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_GetRadiusMaxValue_0")] public static extern 
bool GetRadiusMaxValue_0(out double /*(double)*/ return_value, IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual double GetRadius()
// virtual double GetRadius ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_GetRadius_0")] public static extern 
bool GetRadius_0(out double /*(double)*/ return_value, IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual void SetHoleFilling(bool _arg)
// virtual void SetHoleFilling (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_SetHoleFilling_0")] public static extern 
bool SetHoleFilling_0(IntPtr /*(vtkExtractSurface*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetHoleFilling()
// virtual bool GetHoleFilling ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_GetHoleFilling_0")] public static extern 
bool GetHoleFilling_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual void HoleFillingOn()
// virtual void HoleFillingOn ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_HoleFillingOn_0")] public static extern 
bool HoleFillingOn_0(IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual void HoleFillingOff()
// virtual void HoleFillingOff ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_HoleFillingOff_0")] public static extern 
bool HoleFillingOff_0(IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual void SetComputeNormals(vtkTypeBool _arg)
// virtual void SetComputeNormals (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_SetComputeNormals_0")] public static extern 
bool SetComputeNormals_0(IntPtr /*(vtkExtractSurface*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetComputeNormals()
// virtual vtkTypeBool GetComputeNormals ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_GetComputeNormals_0")] public static extern 
bool GetComputeNormals_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual void ComputeNormalsOn()
// virtual void ComputeNormalsOn ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_ComputeNormalsOn_0")] public static extern 
bool ComputeNormalsOn_0(IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual void ComputeNormalsOff()
// virtual void ComputeNormalsOff ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_ComputeNormalsOff_0")] public static extern 
bool ComputeNormalsOff_0(IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual void SetComputeGradients(vtkTypeBool _arg)
// virtual void SetComputeGradients (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_SetComputeGradients_0")] public static extern 
bool SetComputeGradients_0(IntPtr /*(vtkExtractSurface*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetComputeGradients()
// virtual vtkTypeBool GetComputeGradients ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_GetComputeGradients_0")] public static extern 
bool GetComputeGradients_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual void ComputeGradientsOn()
// virtual void ComputeGradientsOn ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_ComputeGradientsOn_0")] public static extern 
bool ComputeGradientsOn_0(IntPtr /*(vtkExtractSurface*)*/ callingObject);

// virtual void ComputeGradientsOff()
// virtual void ComputeGradientsOff ()
[DllImport("vtkplugin", EntryPoint="vtkExtractSurface_ComputeGradientsOff_0")] public static extern 
bool ComputeGradientsOff_0(IntPtr /*(vtkExtractSurface*)*/ callingObject);

}
};
