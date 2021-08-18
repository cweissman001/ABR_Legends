
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkQuadricClustering {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject, string /*(char*)*/ type);

// static vtkQuadricClustering* SafeDownCast(vtkObjectBase * o)
// static vtkQuadricClustering* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkQuadricClustering*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkQuadricClustering* NewInstance()
// vtkQuadricClustering *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkQuadricClustering*)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// static vtkQuadricClustering* New()
// static vtkQuadricClustering *New()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkQuadricClustering*)*/ return_value);

// void SetNumberOfXDivisions(int num)
// void SetNumberOfXDivisions(int num)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetNumberOfXDivisions_0")] public static extern 
bool SetNumberOfXDivisions_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, int /*(int)*/ num);

// void SetNumberOfYDivisions(int num)
// void SetNumberOfYDivisions(int num)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetNumberOfYDivisions_0")] public static extern 
bool SetNumberOfYDivisions_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, int /*(int)*/ num);

// void SetNumberOfZDivisions(int num)
// void SetNumberOfZDivisions(int num)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetNumberOfZDivisions_0")] public static extern 
bool SetNumberOfZDivisions_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, int /*(int)*/ num);

// virtual int GetNumberOfXDivisions()
// virtual int GetNumberOfXDivisions ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetNumberOfXDivisions_0")] public static extern 
bool GetNumberOfXDivisions_0(out int /*(int)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual int GetNumberOfYDivisions()
// virtual int GetNumberOfYDivisions ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetNumberOfYDivisions_0")] public static extern 
bool GetNumberOfYDivisions_0(out int /*(int)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual int GetNumberOfZDivisions()
// virtual int GetNumberOfZDivisions ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetNumberOfZDivisions_0")] public static extern 
bool GetNumberOfZDivisions_0(out int /*(int)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// void SetNumberOfDivisions(int div[3])
// void SetNumberOfDivisions(int div[3])
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetNumberOfDivisions_0")] public static extern 
bool SetNumberOfDivisions_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, int /*(int[3])*/ []div);

// void SetNumberOfDivisions(int div0, int div1, int div2)
// void SetNumberOfDivisions(int div0, int div1, int div2)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetNumberOfDivisions_1")] public static extern 
bool SetNumberOfDivisions_1(IntPtr /*(vtkQuadricClustering*)*/ callingObject, int /*(int)*/ div0, int /*(int)*/ div1, int /*(int)*/ div2);

// int* GetNumberOfDivisions()
// int *GetNumberOfDivisions()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetNumberOfDivisions_0")] public static extern 
bool GetNumberOfDivisions_0(out int[] /*(int*)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// void GetNumberOfDivisions(int div[3])
// void GetNumberOfDivisions(int div[3])
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetNumberOfDivisions_1")] public static extern 
bool GetNumberOfDivisions_1(IntPtr /*(vtkQuadricClustering*)*/ callingObject, int /*(int[3])*/ []div);

// virtual void SetAutoAdjustNumberOfDivisions(vtkTypeBool _arg)
// virtual void SetAutoAdjustNumberOfDivisions (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetAutoAdjustNumberOfDivisions_0")] public static extern 
bool SetAutoAdjustNumberOfDivisions_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetAutoAdjustNumberOfDivisions()
// virtual vtkTypeBool GetAutoAdjustNumberOfDivisions ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetAutoAdjustNumberOfDivisions_0")] public static extern 
bool GetAutoAdjustNumberOfDivisions_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void AutoAdjustNumberOfDivisionsOn()
// virtual void AutoAdjustNumberOfDivisionsOn ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_AutoAdjustNumberOfDivisionsOn_0")] public static extern 
bool AutoAdjustNumberOfDivisionsOn_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void AutoAdjustNumberOfDivisionsOff()
// virtual void AutoAdjustNumberOfDivisionsOff ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_AutoAdjustNumberOfDivisionsOff_0")] public static extern 
bool AutoAdjustNumberOfDivisionsOff_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// void SetDivisionOrigin(double x, double y, double z)
// void SetDivisionOrigin(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetDivisionOrigin_0")] public static extern 
bool SetDivisionOrigin_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void SetDivisionOrigin(double o[3])
// void SetDivisionOrigin(double o[3])
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetDivisionOrigin_1")] public static extern 
bool SetDivisionOrigin_1(IntPtr /*(vtkQuadricClustering*)*/ callingObject, double /*(double[3])*/ []o);

// virtual double* GetDivisionOrigin()
// virtual double *GetDivisionOrigin ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetDivisionOrigin_0")] public static extern 
bool GetDivisionOrigin_0(out double[] /*(double*)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void GetDivisionOrigin(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetDivisionOrigin (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetDivisionOrigin_1")] public static extern 
bool GetDivisionOrigin_1(IntPtr /*(vtkQuadricClustering*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetDivisionOrigin(double _arg[3])
// virtual void GetDivisionOrigin (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetDivisionOrigin_2")] public static extern 
bool GetDivisionOrigin_2(IntPtr /*(vtkQuadricClustering*)*/ callingObject, double /*(double[3])*/ []_arg);

// void SetDivisionSpacing(double x, double y, double z)
// void SetDivisionSpacing(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetDivisionSpacing_0")] public static extern 
bool SetDivisionSpacing_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void SetDivisionSpacing(double s[3])
// void SetDivisionSpacing(double s[3])
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetDivisionSpacing_1")] public static extern 
bool SetDivisionSpacing_1(IntPtr /*(vtkQuadricClustering*)*/ callingObject, double /*(double[3])*/ []s);

// virtual double* GetDivisionSpacing()
// virtual double *GetDivisionSpacing ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetDivisionSpacing_0")] public static extern 
bool GetDivisionSpacing_0(out double[] /*(double*)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void GetDivisionSpacing(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetDivisionSpacing (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetDivisionSpacing_1")] public static extern 
bool GetDivisionSpacing_1(IntPtr /*(vtkQuadricClustering*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetDivisionSpacing(double _arg[3])
// virtual void GetDivisionSpacing (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetDivisionSpacing_2")] public static extern 
bool GetDivisionSpacing_2(IntPtr /*(vtkQuadricClustering*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetUseInputPoints(vtkTypeBool _arg)
// virtual void SetUseInputPoints (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetUseInputPoints_0")] public static extern 
bool SetUseInputPoints_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetUseInputPoints()
// virtual vtkTypeBool GetUseInputPoints ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetUseInputPoints_0")] public static extern 
bool GetUseInputPoints_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void UseInputPointsOn()
// virtual void UseInputPointsOn ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_UseInputPointsOn_0")] public static extern 
bool UseInputPointsOn_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void UseInputPointsOff()
// virtual void UseInputPointsOff ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_UseInputPointsOff_0")] public static extern 
bool UseInputPointsOff_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void SetUseFeatureEdges(vtkTypeBool _arg)
// virtual void SetUseFeatureEdges (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetUseFeatureEdges_0")] public static extern 
bool SetUseFeatureEdges_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetUseFeatureEdges()
// virtual vtkTypeBool GetUseFeatureEdges ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetUseFeatureEdges_0")] public static extern 
bool GetUseFeatureEdges_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void UseFeatureEdgesOn()
// virtual void UseFeatureEdgesOn ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_UseFeatureEdgesOn_0")] public static extern 
bool UseFeatureEdgesOn_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void UseFeatureEdgesOff()
// virtual void UseFeatureEdgesOff ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_UseFeatureEdgesOff_0")] public static extern 
bool UseFeatureEdgesOff_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// vtkFeatureEdges* GetFeatureEdges()
// vtkFeatureEdges *GetFeatureEdges()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetFeatureEdges_0")] public static extern 
bool GetFeatureEdges_0(out IntPtr /*(vtkFeatureEdges*)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void SetUseFeaturePoints(vtkTypeBool _arg)
// virtual void SetUseFeaturePoints (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetUseFeaturePoints_0")] public static extern 
bool SetUseFeaturePoints_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetUseFeaturePoints()
// virtual vtkTypeBool GetUseFeaturePoints ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetUseFeaturePoints_0")] public static extern 
bool GetUseFeaturePoints_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void UseFeaturePointsOn()
// virtual void UseFeaturePointsOn ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_UseFeaturePointsOn_0")] public static extern 
bool UseFeaturePointsOn_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void UseFeaturePointsOff()
// virtual void UseFeaturePointsOff ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_UseFeaturePointsOff_0")] public static extern 
bool UseFeaturePointsOff_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void SetFeaturePointsAngle(double _arg)
// virtual void SetFeaturePointsAngle (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetFeaturePointsAngle_0")] public static extern 
bool SetFeaturePointsAngle_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetFeaturePointsAngleMinValue()
// virtual double GetFeaturePointsAngleMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetFeaturePointsAngleMinValue_0")] public static extern 
bool GetFeaturePointsAngleMinValue_0(out double /*(double)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual double GetFeaturePointsAngleMaxValue()
// virtual double GetFeaturePointsAngleMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetFeaturePointsAngleMaxValue_0")] public static extern 
bool GetFeaturePointsAngleMaxValue_0(out double /*(double)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual double GetFeaturePointsAngle()
// virtual double GetFeaturePointsAngle ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetFeaturePointsAngle_0")] public static extern 
bool GetFeaturePointsAngle_0(out double /*(double)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void SetUseInternalTriangles(vtkTypeBool _arg)
// virtual void SetUseInternalTriangles (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetUseInternalTriangles_0")] public static extern 
bool SetUseInternalTriangles_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetUseInternalTriangles()
// virtual vtkTypeBool GetUseInternalTriangles ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetUseInternalTriangles_0")] public static extern 
bool GetUseInternalTriangles_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void UseInternalTrianglesOn()
// virtual void UseInternalTrianglesOn ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_UseInternalTrianglesOn_0")] public static extern 
bool UseInternalTrianglesOn_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void UseInternalTrianglesOff()
// virtual void UseInternalTrianglesOff ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_UseInternalTrianglesOff_0")] public static extern 
bool UseInternalTrianglesOff_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// void StartAppend(double * bounds)
// void StartAppend(double *bounds)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_StartAppend_0")] public static extern 
bool StartAppend_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, double[] /*(double*)*/ bounds);

// void StartAppend(double x0, double x1, double y0, double y1, double z0, double z1)
// void StartAppend(double x0,double x1,double y0,double y1,double z0,double z1)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_StartAppend_1")] public static extern 
bool StartAppend_1(IntPtr /*(vtkQuadricClustering*)*/ callingObject, double /*(double)*/ x0, double /*(double)*/ x1, double /*(double)*/ y0, double /*(double)*/ y1, double /*(double)*/ z0, double /*(double)*/ z1);

// void Append(vtkPolyData * piece)
// void Append(vtkPolyData *piece)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_Append_0")] public static extern 
bool Append_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, IntPtr /*(vtkPolyData*)*/ piece);

// void EndAppend()
// void EndAppend()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_EndAppend_0")] public static extern 
bool EndAppend_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void SetCopyCellData(vtkTypeBool _arg)
// virtual void SetCopyCellData (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetCopyCellData_0")] public static extern 
bool SetCopyCellData_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetCopyCellData()
// virtual vtkTypeBool GetCopyCellData ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetCopyCellData_0")] public static extern 
bool GetCopyCellData_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void CopyCellDataOn()
// virtual void CopyCellDataOn ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_CopyCellDataOn_0")] public static extern 
bool CopyCellDataOn_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void CopyCellDataOff()
// virtual void CopyCellDataOff ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_CopyCellDataOff_0")] public static extern 
bool CopyCellDataOff_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void SetPreventDuplicateCells(vtkTypeBool _arg)
// virtual void SetPreventDuplicateCells (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_SetPreventDuplicateCells_0")] public static extern 
bool SetPreventDuplicateCells_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetPreventDuplicateCells()
// virtual vtkTypeBool GetPreventDuplicateCells ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_GetPreventDuplicateCells_0")] public static extern 
bool GetPreventDuplicateCells_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void PreventDuplicateCellsOn()
// virtual void PreventDuplicateCellsOn ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_PreventDuplicateCellsOn_0")] public static extern 
bool PreventDuplicateCellsOn_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

// virtual void PreventDuplicateCellsOff()
// virtual void PreventDuplicateCellsOff ()
[DllImport("vtkplugin", EntryPoint="vtkQuadricClustering_PreventDuplicateCellsOff_0")] public static extern 
bool PreventDuplicateCellsOff_0(IntPtr /*(vtkQuadricClustering*)*/ callingObject);

}
};
