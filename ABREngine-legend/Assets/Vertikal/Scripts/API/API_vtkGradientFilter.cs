
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkGradientFilter {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject, string /*(char*)*/ type);

// static vtkGradientFilter* SafeDownCast(vtkObjectBase * o)
// static vtkGradientFilter* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkGradientFilter*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkGradientFilter* NewInstance()
// vtkGradientFilter *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkGradientFilter*)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// static vtkGradientFilter* New()
// static vtkGradientFilter *New()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkGradientFilter*)*/ return_value);

// virtual void SetInputScalars(int fieldAssociation, const char * name)
// virtual void SetInputScalars(int fieldAssociation, const char *name)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetInputScalars_0")] public static extern 
bool SetInputScalars_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, int /*(int)*/ fieldAssociation, string /*(char*)*/ name);

// virtual void SetInputScalars(int fieldAssociation, int fieldAttributeType)
// virtual void SetInputScalars(int fieldAssociation, int fieldAttributeType)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetInputScalars_1")] public static extern 
bool SetInputScalars_1(IntPtr /*(vtkGradientFilter*)*/ callingObject, int /*(int)*/ fieldAssociation, int /*(int)*/ fieldAttributeType);

// virtual char* GetResultArrayName()
// virtual char* GetResultArrayName ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetResultArrayName_0")] public static extern 
bool GetResultArrayName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetResultArrayName(const char * _arg)
// virtual void SetResultArrayName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetResultArrayName_0")] public static extern 
bool SetResultArrayName_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetDivergenceArrayName()
// virtual char* GetDivergenceArrayName ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetDivergenceArrayName_0")] public static extern 
bool GetDivergenceArrayName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetDivergenceArrayName(const char * _arg)
// virtual void SetDivergenceArrayName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetDivergenceArrayName_0")] public static extern 
bool SetDivergenceArrayName_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetVorticityArrayName()
// virtual char* GetVorticityArrayName ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetVorticityArrayName_0")] public static extern 
bool GetVorticityArrayName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetVorticityArrayName(const char * _arg)
// virtual void SetVorticityArrayName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetVorticityArrayName_0")] public static extern 
bool SetVorticityArrayName_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetQCriterionArrayName()
// virtual char* GetQCriterionArrayName ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetQCriterionArrayName_0")] public static extern 
bool GetQCriterionArrayName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetQCriterionArrayName(const char * _arg)
// virtual void SetQCriterionArrayName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetQCriterionArrayName_0")] public static extern 
bool SetQCriterionArrayName_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, string /*(char*)*/ _arg);

// virtual vtkTypeBool GetFasterApproximation()
// virtual vtkTypeBool GetFasterApproximation ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetFasterApproximation_0")] public static extern 
bool GetFasterApproximation_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetFasterApproximation(vtkTypeBool _arg)
// virtual void SetFasterApproximation (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetFasterApproximation_0")] public static extern 
bool SetFasterApproximation_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual void FasterApproximationOn()
// virtual void FasterApproximationOn ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_FasterApproximationOn_0")] public static extern 
bool FasterApproximationOn_0(IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void FasterApproximationOff()
// virtual void FasterApproximationOff ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_FasterApproximationOff_0")] public static extern 
bool FasterApproximationOff_0(IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetComputeGradient(vtkTypeBool _arg)
// virtual void SetComputeGradient (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetComputeGradient_0")] public static extern 
bool SetComputeGradient_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetComputeGradient()
// virtual vtkTypeBool GetComputeGradient ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetComputeGradient_0")] public static extern 
bool GetComputeGradient_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void ComputeGradientOn()
// virtual void ComputeGradientOn ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_ComputeGradientOn_0")] public static extern 
bool ComputeGradientOn_0(IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void ComputeGradientOff()
// virtual void ComputeGradientOff ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_ComputeGradientOff_0")] public static extern 
bool ComputeGradientOff_0(IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetComputeDivergence(vtkTypeBool _arg)
// virtual void SetComputeDivergence (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetComputeDivergence_0")] public static extern 
bool SetComputeDivergence_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetComputeDivergence()
// virtual vtkTypeBool GetComputeDivergence ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetComputeDivergence_0")] public static extern 
bool GetComputeDivergence_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void ComputeDivergenceOn()
// virtual void ComputeDivergenceOn ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_ComputeDivergenceOn_0")] public static extern 
bool ComputeDivergenceOn_0(IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void ComputeDivergenceOff()
// virtual void ComputeDivergenceOff ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_ComputeDivergenceOff_0")] public static extern 
bool ComputeDivergenceOff_0(IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetComputeVorticity(vtkTypeBool _arg)
// virtual void SetComputeVorticity (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetComputeVorticity_0")] public static extern 
bool SetComputeVorticity_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetComputeVorticity()
// virtual vtkTypeBool GetComputeVorticity ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetComputeVorticity_0")] public static extern 
bool GetComputeVorticity_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void ComputeVorticityOn()
// virtual void ComputeVorticityOn ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_ComputeVorticityOn_0")] public static extern 
bool ComputeVorticityOn_0(IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void ComputeVorticityOff()
// virtual void ComputeVorticityOff ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_ComputeVorticityOff_0")] public static extern 
bool ComputeVorticityOff_0(IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetComputeQCriterion(vtkTypeBool _arg)
// virtual void SetComputeQCriterion (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetComputeQCriterion_0")] public static extern 
bool SetComputeQCriterion_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetComputeQCriterion()
// virtual vtkTypeBool GetComputeQCriterion ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetComputeQCriterion_0")] public static extern 
bool GetComputeQCriterion_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void ComputeQCriterionOn()
// virtual void ComputeQCriterionOn ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_ComputeQCriterionOn_0")] public static extern 
bool ComputeQCriterionOn_0(IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void ComputeQCriterionOff()
// virtual void ComputeQCriterionOff ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_ComputeQCriterionOff_0")] public static extern 
bool ComputeQCriterionOff_0(IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetContributingCellOption(int _arg)
// virtual void SetContributingCellOption (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetContributingCellOption_0")] public static extern 
bool SetContributingCellOption_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetContributingCellOptionMinValue()
// virtual int GetContributingCellOptionMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetContributingCellOptionMinValue_0")] public static extern 
bool GetContributingCellOptionMinValue_0(out int /*(int)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual int GetContributingCellOptionMaxValue()
// virtual int GetContributingCellOptionMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetContributingCellOptionMaxValue_0")] public static extern 
bool GetContributingCellOptionMaxValue_0(out int /*(int)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual int GetContributingCellOption()
// virtual int GetContributingCellOption ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetContributingCellOption_0")] public static extern 
bool GetContributingCellOption_0(out int /*(int)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual void SetReplacementValueOption(int _arg)
// virtual void SetReplacementValueOption (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_SetReplacementValueOption_0")] public static extern 
bool SetReplacementValueOption_0(IntPtr /*(vtkGradientFilter*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetReplacementValueOptionMinValue()
// virtual int GetReplacementValueOptionMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetReplacementValueOptionMinValue_0")] public static extern 
bool GetReplacementValueOptionMinValue_0(out int /*(int)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual int GetReplacementValueOptionMaxValue()
// virtual int GetReplacementValueOptionMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetReplacementValueOptionMaxValue_0")] public static extern 
bool GetReplacementValueOptionMaxValue_0(out int /*(int)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

// virtual int GetReplacementValueOption()
// virtual int GetReplacementValueOption ()
[DllImport("vtkplugin", EntryPoint="vtkGradientFilter_GetReplacementValueOption_0")] public static extern 
bool GetReplacementValueOption_0(out int /*(int)*/ return_value, IntPtr /*(vtkGradientFilter*)*/ callingObject);

}
};
