
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPolyDataNormals {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject, string /*(char*)*/ type);

// static vtkPolyDataNormals* SafeDownCast(vtkObjectBase * o)
// static vtkPolyDataNormals* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkPolyDataNormals*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPolyDataNormals* NewInstance()
// vtkPolyDataNormals *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkPolyDataNormals*)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// static vtkPolyDataNormals* New()
// static vtkPolyDataNormals *New()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkPolyDataNormals*)*/ return_value);

// virtual void SetFeatureAngle(double _arg)
// virtual void SetFeatureAngle (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SetFeatureAngle_0")] public static extern 
bool SetFeatureAngle_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetFeatureAngleMinValue()
// virtual double GetFeatureAngleMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetFeatureAngleMinValue_0")] public static extern 
bool GetFeatureAngleMinValue_0(out double /*(double)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual double GetFeatureAngleMaxValue()
// virtual double GetFeatureAngleMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetFeatureAngleMaxValue_0")] public static extern 
bool GetFeatureAngleMaxValue_0(out double /*(double)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual double GetFeatureAngle()
// virtual double GetFeatureAngle ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetFeatureAngle_0")] public static extern 
bool GetFeatureAngle_0(out double /*(double)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void SetSplitting(vtkTypeBool _arg)
// virtual void SetSplitting (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SetSplitting_0")] public static extern 
bool SetSplitting_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetSplitting()
// virtual vtkTypeBool GetSplitting ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetSplitting_0")] public static extern 
bool GetSplitting_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void SplittingOn()
// virtual void SplittingOn ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SplittingOn_0")] public static extern 
bool SplittingOn_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void SplittingOff()
// virtual void SplittingOff ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SplittingOff_0")] public static extern 
bool SplittingOff_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void SetConsistency(vtkTypeBool _arg)
// virtual void SetConsistency (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SetConsistency_0")] public static extern 
bool SetConsistency_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetConsistency()
// virtual vtkTypeBool GetConsistency ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetConsistency_0")] public static extern 
bool GetConsistency_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void ConsistencyOn()
// virtual void ConsistencyOn ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_ConsistencyOn_0")] public static extern 
bool ConsistencyOn_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void ConsistencyOff()
// virtual void ConsistencyOff ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_ConsistencyOff_0")] public static extern 
bool ConsistencyOff_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void SetAutoOrientNormals(vtkTypeBool _arg)
// virtual void SetAutoOrientNormals (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SetAutoOrientNormals_0")] public static extern 
bool SetAutoOrientNormals_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetAutoOrientNormals()
// virtual vtkTypeBool GetAutoOrientNormals ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetAutoOrientNormals_0")] public static extern 
bool GetAutoOrientNormals_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void AutoOrientNormalsOn()
// virtual void AutoOrientNormalsOn ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_AutoOrientNormalsOn_0")] public static extern 
bool AutoOrientNormalsOn_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void AutoOrientNormalsOff()
// virtual void AutoOrientNormalsOff ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_AutoOrientNormalsOff_0")] public static extern 
bool AutoOrientNormalsOff_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void SetComputePointNormals(vtkTypeBool _arg)
// virtual void SetComputePointNormals (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SetComputePointNormals_0")] public static extern 
bool SetComputePointNormals_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetComputePointNormals()
// virtual vtkTypeBool GetComputePointNormals ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetComputePointNormals_0")] public static extern 
bool GetComputePointNormals_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void ComputePointNormalsOn()
// virtual void ComputePointNormalsOn ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_ComputePointNormalsOn_0")] public static extern 
bool ComputePointNormalsOn_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void ComputePointNormalsOff()
// virtual void ComputePointNormalsOff ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_ComputePointNormalsOff_0")] public static extern 
bool ComputePointNormalsOff_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void SetComputeCellNormals(vtkTypeBool _arg)
// virtual void SetComputeCellNormals (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SetComputeCellNormals_0")] public static extern 
bool SetComputeCellNormals_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetComputeCellNormals()
// virtual vtkTypeBool GetComputeCellNormals ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetComputeCellNormals_0")] public static extern 
bool GetComputeCellNormals_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void ComputeCellNormalsOn()
// virtual void ComputeCellNormalsOn ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_ComputeCellNormalsOn_0")] public static extern 
bool ComputeCellNormalsOn_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void ComputeCellNormalsOff()
// virtual void ComputeCellNormalsOff ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_ComputeCellNormalsOff_0")] public static extern 
bool ComputeCellNormalsOff_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void SetFlipNormals(vtkTypeBool _arg)
// virtual void SetFlipNormals (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SetFlipNormals_0")] public static extern 
bool SetFlipNormals_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetFlipNormals()
// virtual vtkTypeBool GetFlipNormals ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetFlipNormals_0")] public static extern 
bool GetFlipNormals_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void FlipNormalsOn()
// virtual void FlipNormalsOn ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_FlipNormalsOn_0")] public static extern 
bool FlipNormalsOn_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void FlipNormalsOff()
// virtual void FlipNormalsOff ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_FlipNormalsOff_0")] public static extern 
bool FlipNormalsOff_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void SetNonManifoldTraversal(vtkTypeBool _arg)
// virtual void SetNonManifoldTraversal (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SetNonManifoldTraversal_0")] public static extern 
bool SetNonManifoldTraversal_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetNonManifoldTraversal()
// virtual vtkTypeBool GetNonManifoldTraversal ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetNonManifoldTraversal_0")] public static extern 
bool GetNonManifoldTraversal_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void NonManifoldTraversalOn()
// virtual void NonManifoldTraversalOn ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_NonManifoldTraversalOn_0")] public static extern 
bool NonManifoldTraversalOn_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void NonManifoldTraversalOff()
// virtual void NonManifoldTraversalOff ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_NonManifoldTraversalOff_0")] public static extern 
bool NonManifoldTraversalOff_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual void SetOutputPointsPrecision(int _arg)
// virtual void SetOutputPointsPrecision (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_SetOutputPointsPrecision_0")] public static extern 
bool SetOutputPointsPrecision_0(IntPtr /*(vtkPolyDataNormals*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetOutputPointsPrecisionMinValue()
// virtual int GetOutputPointsPrecisionMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetOutputPointsPrecisionMinValue_0")] public static extern 
bool GetOutputPointsPrecisionMinValue_0(out int /*(int)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual int GetOutputPointsPrecisionMaxValue()
// virtual int GetOutputPointsPrecisionMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetOutputPointsPrecisionMaxValue_0")] public static extern 
bool GetOutputPointsPrecisionMaxValue_0(out int /*(int)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

// virtual int GetOutputPointsPrecision()
// virtual int GetOutputPointsPrecision ()
[DllImport("vtkplugin", EntryPoint="vtkPolyDataNormals_GetOutputPointsPrecision_0")] public static extern 
bool GetOutputPointsPrecision_0(out int /*(int)*/ return_value, IntPtr /*(vtkPolyDataNormals*)*/ callingObject);

}
};
