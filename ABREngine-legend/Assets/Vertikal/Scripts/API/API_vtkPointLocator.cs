
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPointLocator {

// static vtkPointLocator* New()
// static vtkPointLocator *New()
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, string /*(char*)*/ type);

// static vtkPointLocator* SafeDownCast(vtkObjectBase * o)
// static vtkPointLocator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPointLocator* NewInstance()
// vtkPointLocator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject);

// virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
// virtual void SetDivisions (int _arg1, int _arg2, int _arg3)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_SetDivisions_0")] public static extern 
bool SetDivisions_0(IntPtr /*(vtkPointLocator*)*/ callingObject, int /*(int)*/ _arg1, int /*(int)*/ _arg2, int /*(int)*/ _arg3);

// virtual void SetDivisions(int _arg[3])
// virtual void SetDivisions (int _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_SetDivisions_1")] public static extern 
bool SetDivisions_1(IntPtr /*(vtkPointLocator*)*/ callingObject, int /*(int[3])*/ []_arg);

// virtual int* GetDivisions()
// virtual int *GetDivisions ()
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_GetDivisions_0")] public static extern 
bool GetDivisions_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject);

// virtual void GetDivisions(int data[3])
// virtual void GetDivisions (int data[3])
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_GetDivisions_1")] public static extern 
bool GetDivisions_1(IntPtr /*(vtkPointLocator*)*/ callingObject, int /*(int[3])*/ []data);

// virtual void SetNumberOfPointsPerBucket(int _arg)
// virtual void SetNumberOfPointsPerBucket (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_SetNumberOfPointsPerBucket_0")] public static extern 
bool SetNumberOfPointsPerBucket_0(IntPtr /*(vtkPointLocator*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetNumberOfPointsPerBucketMinValue()
// virtual int GetNumberOfPointsPerBucketMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_GetNumberOfPointsPerBucketMinValue_0")] public static extern 
bool GetNumberOfPointsPerBucketMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject);

// virtual int GetNumberOfPointsPerBucketMaxValue()
// virtual int GetNumberOfPointsPerBucketMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_GetNumberOfPointsPerBucketMaxValue_0")] public static extern 
bool GetNumberOfPointsPerBucketMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject);

// virtual int GetNumberOfPointsPerBucket()
// virtual int GetNumberOfPointsPerBucket ()
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_GetNumberOfPointsPerBucket_0")] public static extern 
bool GetNumberOfPointsPerBucket_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject);

// vtkIdType FindClosestPoint(const double x[3])
// vtkIdType FindClosestPoint(const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_FindClosestPoint_0")] public static extern 
bool FindClosestPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, double /*(double[3])*/ []x);

// vtkIdType FindClosestPointWithinRadius(double radius, const double x[3], double & dist2)
// vtkIdType FindClosestPointWithinRadius( double radius, const double x[3], double& dist2)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_FindClosestPointWithinRadius_0")] public static extern 
bool FindClosestPointWithinRadius_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, double /*(double)*/ radius, double /*(double[3])*/ []x, IntPtr /*(double&)*/ dist2);

// virtual vtkIdType FindClosestPointWithinRadius(double radius, const double x[3], double inputDataLength, double & dist2)
// virtual vtkIdType FindClosestPointWithinRadius( double radius, const double x[3], double inputDataLength, double& dist2)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_FindClosestPointWithinRadius_1")] public static extern 
bool FindClosestPointWithinRadius_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, double /*(double)*/ radius, double /*(double[3])*/ []x, double /*(double)*/ inputDataLength, IntPtr /*(double&)*/ dist2);

// int InitPointInsertion(vtkPoints * newPts, const double bounds[6])
// int InitPointInsertion(vtkPoints *newPts, const double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_InitPointInsertion_0")] public static extern 
bool InitPointInsertion_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, IntPtr /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds);

// int InitPointInsertion(vtkPoints * newPts, const double bounds[6], vtkIdType estSize)
// int InitPointInsertion(vtkPoints *newPts, const double bounds[6], vtkIdType estSize)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_InitPointInsertion_1")] public static extern 
bool InitPointInsertion_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, IntPtr /*(vtkPoints*)*/ newPts, double /*(double[6])*/ []bounds, long /*(vtkIdType)*/ estSize);

// void InsertPoint(vtkIdType ptId, const double x[3])
// void InsertPoint(vtkIdType ptId, const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_InsertPoint_0")] public static extern 
bool InsertPoint_0(IntPtr /*(vtkPointLocator*)*/ callingObject, long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x);

// vtkIdType InsertNextPoint(const double x[3])
// vtkIdType InsertNextPoint(const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_InsertNextPoint_0")] public static extern 
bool InsertNextPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, double /*(double[3])*/ []x);

// vtkIdType IsInsertedPoint(double x, double y, double z)
// vtkIdType IsInsertedPoint(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_IsInsertedPoint_0")] public static extern 
bool IsInsertedPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// vtkIdType IsInsertedPoint(const double x[3])
// vtkIdType IsInsertedPoint(const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_IsInsertedPoint_1")] public static extern 
bool IsInsertedPoint_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, double /*(double[3])*/ []x);

// int InsertUniquePoint(const double x[3], vtkIdType & ptId)
// int InsertUniquePoint(const double x[3], vtkIdType &ptId)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_InsertUniquePoint_0")] public static extern 
bool InsertUniquePoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkIdType&)*/ ptId);

// vtkIdType FindClosestInsertedPoint(const double x[3])
// vtkIdType FindClosestInsertedPoint(const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_FindClosestInsertedPoint_0")] public static extern 
bool FindClosestInsertedPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, double /*(double[3])*/ []x);

// void FindClosestNPoints(int N, const double x[3], vtkIdList * result)
// void FindClosestNPoints(int N, const double x[3], vtkIdList *result)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_FindClosestNPoints_0")] public static extern 
bool FindClosestNPoints_0(IntPtr /*(vtkPointLocator*)*/ callingObject, int /*(int)*/ N, double /*(double[3])*/ []x, IntPtr /*(vtkIdList*)*/ result);

// virtual void FindDistributedPoints(int N, const double x[3], vtkIdList * result, int M)
// virtual void FindDistributedPoints(int N, const double x[3], vtkIdList *result, int M)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_FindDistributedPoints_0")] public static extern 
bool FindDistributedPoints_0(IntPtr /*(vtkPointLocator*)*/ callingObject, int /*(int)*/ N, double /*(double[3])*/ []x, IntPtr /*(vtkIdList*)*/ result, int /*(int)*/ M);

// virtual void FindDistributedPoints(int N, double x, double y, double z, vtkIdList * result, int M)
// virtual void FindDistributedPoints(int N, double x, double y, double z, vtkIdList *result, int M)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_FindDistributedPoints_1")] public static extern 
bool FindDistributedPoints_1(IntPtr /*(vtkPointLocator*)*/ callingObject, int /*(int)*/ N, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, IntPtr /*(vtkIdList*)*/ result, int /*(int)*/ M);

// void FindPointsWithinRadius(double R, const double x[3], vtkIdList * result)
// void FindPointsWithinRadius(double R, const double x[3], vtkIdList *result)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_FindPointsWithinRadius_0")] public static extern 
bool FindPointsWithinRadius_0(IntPtr /*(vtkPointLocator*)*/ callingObject, double /*(double)*/ R, double /*(double[3])*/ []x, IntPtr /*(vtkIdList*)*/ result);

// virtual vtkIdList* GetPointsInBucket(const double x[3], int ijk[3])
// virtual vtkIdList *GetPointsInBucket(const double x[3], int ijk[3])
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_GetPointsInBucket_0")] public static extern 
bool GetPointsInBucket_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject, double /*(double[3])*/ []x, int /*(int[3])*/ []ijk);

// virtual vtkPoints* GetPoints()
// virtual vtkPoints *GetPoints ()
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_GetPoints_0")] public static extern 
bool GetPoints_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPointLocator*)*/ callingObject);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkPointLocator*)*/ callingObject);

// void FreeSearchStructure()
// void FreeSearchStructure()
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_FreeSearchStructure_0")] public static extern 
bool FreeSearchStructure_0(IntPtr /*(vtkPointLocator*)*/ callingObject);

// void BuildLocator()
// void BuildLocator()
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_BuildLocator_0")] public static extern 
bool BuildLocator_0(IntPtr /*(vtkPointLocator*)*/ callingObject);

// void GenerateRepresentation(int level, vtkPolyData * pd)
// void GenerateRepresentation(int level, vtkPolyData *pd)
[DllImport("vtkplugin", EntryPoint="vtkPointLocator_GenerateRepresentation_0")] public static extern 
bool GenerateRepresentation_0(IntPtr /*(vtkPointLocator*)*/ callingObject, int /*(int)*/ level, IntPtr /*(vtkPolyData*)*/ pd);

}
};
