using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;


namespace VTK
{
    class vtkCompound
    {
        [DllImport("vtkplugin")] unsafe public static extern void free_data(IntPtr h);
    }
}

public class ReturnPointer
{
    protected IntPtr data_;

    public ReturnPointer(object t, int count = 1) {
        data_ = Marshal.AllocHGlobal(Marshal.SizeOf(t)*count);
    }
    ~ReturnPointer() {
        Marshal.FreeHGlobal(data_);
    }
    public IntPtr GetPtr() {
        return data_;
    }
    public static implicit operator IntPtr(ReturnPointer p)
    {
        IntPtr result;
        unsafe { result = new IntPtr(*(void**)p.data_.ToPointer()); }
        return result;
    }

    public static implicit operator int(ReturnPointer p)
    {
        return Marshal.ReadInt32(p.data_);
    }

    public static implicit operator long (ReturnPointer p)
    {
        return Marshal.ReadInt64(p.data_);
    }
    public static implicit operator ulong(ReturnPointer p)
    {
        return (ulong)Marshal.ReadInt64(p.data_);
    }
    public static implicit operator string( ReturnPointer p)
    {
        return Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p.data_));;
    }

    public static implicit operator bool(ReturnPointer p)
    {
        return Marshal.ReadByte(p.data_) == (byte)1; ;
    }
    public static implicit operator char(ReturnPointer p)
    {
        return (char)Marshal.ReadByte(p.data_) ;
    }
    public static implicit operator double(ReturnPointer p)
    {
        double v = 0;
        if (p.data_ != IntPtr.Zero)
        {
            byte[] ba = new byte[sizeof(double)];

            for (int i = 0; i < ba.Length; i++)
                ba[i] = Marshal.ReadByte(p.data_, i);
            v = BitConverter.ToDouble(ba, 0);
           
        }

        return v;
    }
    public static implicit operator float(ReturnPointer p)
    {
        float v = 0;
        if (p.data_ != IntPtr.Zero)
        {
            byte[] ba = new byte[sizeof(float)];

            for (int i = 0; i < ba.Length; i++)
                ba[i] = Marshal.ReadByte(p.data_, i);
            v = BitConverter.ToSingle(ba, 0);

        }

        return v;
    }
    public static implicit operator VTK.vtkObject( ReturnPointer p)
    {


        return (VTK.vtkObject)(IntPtr)p;

    }

}

namespace VTK
{

    public enum VTKCellType
    {
        // Linear cells
        VTK_EMPTY_CELL       = 0,
        VTK_VERTEX           = 1,
        VTK_POLY_VERTEX      = 2,
        VTK_LINE             = 3,
        VTK_POLY_LINE        = 4,
        VTK_TRIANGLE         = 5,
        VTK_TRIANGLE_STRIP   = 6,
        VTK_POLYGON          = 7,
        VTK_PIXEL            = 8,
        VTK_QUAD             = 9,
        VTK_TETRA            = 10,
        VTK_VOXEL            = 11,
        VTK_HEXAHEDRON       = 12,
        VTK_WEDGE            = 13,
        VTK_PYRAMID          = 14,
        VTK_PENTAGONAL_PRISM = 15,
        VTK_HEXAGONAL_PRISM  = 16,

        // Quadratic, isoparametric cells
        VTK_QUADRATIC_EDGE                   = 21,
        VTK_QUADRATIC_TRIANGLE               = 22,
        VTK_QUADRATIC_QUAD                   = 23,
        VTK_QUADRATIC_POLYGON                = 36,
        VTK_QUADRATIC_TETRA                  = 24,
        VTK_QUADRATIC_HEXAHEDRON             = 25,
        VTK_QUADRATIC_WEDGE                  = 26,
        VTK_QUADRATIC_PYRAMID                = 27,
        VTK_BIQUADRATIC_QUAD                 = 28,
        VTK_TRIQUADRATIC_HEXAHEDRON          = 29,
        VTK_QUADRATIC_LINEAR_QUAD            = 30,
        VTK_QUADRATIC_LINEAR_WEDGE           = 31,
        VTK_BIQUADRATIC_QUADRATIC_WEDGE      = 32,
        VTK_BIQUADRATIC_QUADRATIC_HEXAHEDRON = 33,
        VTK_BIQUADRATIC_TRIANGLE             = 34,

        // Cubic, isoparametric cell
        VTK_CUBIC_LINE                       = 35,

        // Special class of cells formed by convex group of points
        VTK_CONVEX_POINT_SET = 41,

        // Polyhedron cell (consisting of polygonal faces)
        VTK_POLYHEDRON = 42,

        // Higher order cells in parametric form
        VTK_PARAMETRIC_CURVE        = 51,
        VTK_PARAMETRIC_SURFACE      = 52,
        VTK_PARAMETRIC_TRI_SURFACE  = 53,
        VTK_PARAMETRIC_QUAD_SURFACE = 54,
        VTK_PARAMETRIC_TETRA_REGION = 55,
        VTK_PARAMETRIC_HEX_REGION   = 56,

        // Higher order cells
        VTK_HIGHER_ORDER_EDGE        = 60,
        VTK_HIGHER_ORDER_TRIANGLE    = 61,
        VTK_HIGHER_ORDER_QUAD        = 62,
        VTK_HIGHER_ORDER_POLYGON     = 63,
        VTK_HIGHER_ORDER_TETRAHEDRON = 64,
        VTK_HIGHER_ORDER_WEDGE       = 65,
        VTK_HIGHER_ORDER_PYRAMID     = 66,
        VTK_HIGHER_ORDER_HEXAHEDRON  = 67,

        // Arbitrary order Lagrange elements (formulated separated from generic higher order cells)
        VTK_LAGRANGE_CURVE           = 68,
        VTK_LAGRANGE_TRIANGLE        = 69,
        VTK_LAGRANGE_QUADRILATERAL   = 70,
        VTK_LAGRANGE_TETRAHEDRON     = 71,
        VTK_LAGRANGE_HEXAHEDRON      = 72,
        VTK_LAGRANGE_WEDGE           = 73,
        VTK_LAGRANGE_PYRAMID         = 74,

        VTK_NUMBER_OF_CELL_TYPES
    }
    
	public partial class  vtkObject : vtkObjectBase {

	}

    public class Link
    {
        ushort ncells;
        IntPtr cells;
    };

    public partial class vtkObjectBase
    {

        public vtkObjectBase(IntPtr p) { SetPtr(p); }
        protected void SetPtr(IntPtr d)
        {
            data_ = d;
        }
        private IntPtr data_;
        public IntPtr GetPtr() { return data_; }

        public bool IsVoid() {
            return data_ == IntPtr.Zero;
        }

        public override string ToString()
        {
            if(GetPtr() == IntPtr.Zero) {
                return "Null VTK Object";
            } else {
                return GetClassName() + " object at address " + GetPtr().ToString();
            }
             
        }
    }


    public partial class vtkDataArray {

        public Vector3 GetVector(long id)
        {
            double[] v = new double[3];

            //GetTuple_1(id, v);
            GetTuple(id, v);
            return new Vector3((float)v[0], (float)v[1], -(float)v[2]);
        }
    }


    public partial class vtkDataSet {
        public Bounds GetBounds() {
            double[] b = new double[6];
            GetBounds(b);
            Bounds result = new Bounds();
            result.SetMinMax(new Vector3((float)b[0], (float)b[2], -(float)b[5]), new Vector3((float)b[1], (float)b[3], -(float)b[4]));
            return result;
        }


        public Bounds GetCellBounds(long cellId)
        {
            double[] b = new double[6];
            GetCellBounds(cellId,b);
            Bounds result = new Bounds();
            result.SetMinMax(new Vector3((float)b[0], (float)b[2], -(float)b[5]), new Vector3((float)b[1], (float)b[3], -(float)b[4]));
            return result;
        }

    }

    public partial class vtkPoints {

        public Vector3 GetPoint(long pointId)
        {
            double[] p = new double[3];
            GetPoint_1(pointId,p);
            return new Vector3((float)p[0], (float)p[1], -(float)p[2]);
        }

        public void InsertNextPoint(Vector3 v)
        {
            double[] d = new double[] { v.x, v.y, v.z };
            InsertNextPoint(d);
        }

    }

    public partial class vtkDataSet {
        double[] p = new double[3];
        public Vector3 GetPoint(long pointId)
        {
            // double[] p = new double[3];
            GetPoint_1(pointId,p);
            return new Vector3((float)p[0], (float)p[1], -(float)p[2]);
        }
    }
}



