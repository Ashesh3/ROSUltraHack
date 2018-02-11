 
using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Whynot
{
  public class Mem
  {
    public static int m_iNumberOfBytesRead = 0;
    public static int m_iNumberOfBytesWritten = 0;
    public static Process m_Process;
    public static IntPtr m_pProcessHandle;
    public static int BaseAddress;
    private const int PROCESS_VM_OPERATION = 8;
    private const int PROCESS_VM_READ = 16;
    private const int PROCESS_VM_WRITE = 32;

    public static void Initialize(string ProcessName)
    {
      if ((uint) Process.GetProcessesByName(ProcessName).Length > 0U)
      {
        Mem.m_Process = Process.GetProcessesByName(ProcessName)[0];
        Mem.BaseAddress = Process.GetProcessesByName(ProcessName)[0].MainModule.BaseAddress.ToInt32();
      }
      else
      {
        int num = (int) MessageBox.Show("Open Ros.exe first");
        Environment.Exit(1);
      }
      Mem.m_pProcessHandle = Mem.OpenProcess(56, false, Mem.m_Process.Id);
    }

    public static int GetModuleAdress(string ModuleName)
    {
      int num;
      try
      {
        foreach (ProcessModule module in (ReadOnlyCollectionBase) Mem.m_Process.Modules)
        {
          if (!ModuleName.Contains(".dll"))
            ModuleName = ModuleName.Insert(ModuleName.Length, ".dll");
          if (ModuleName == module.ModuleName)
          {
            num = (int) module.BaseAddress;
            goto label_13;
          }
        }
      }
      catch
      {
      }
      num = -1;
label_13:
      return num;
    }

    public static string ReadString(int address, int _Size)
    {
      byte[] numArray = new byte[_Size];
      Mem.ReadProcessMemory((int) Mem.m_pProcessHandle, address, numArray, _Size, ref Mem.m_iNumberOfBytesRead);
      return Encoding.ASCII.GetString(numArray);
    }

    public static T ReadMemory<T>(int Adress) where T : struct
    {
      byte[] numArray = new byte[Marshal.SizeOf(typeof (T))];
      Mem.ReadProcessMemory((int) Mem.m_pProcessHandle, Adress, numArray, numArray.Length, ref Mem.m_iNumberOfBytesRead);
      return Mem.ByteArrayToStructure<T>(numArray);
    }

    public static float[] ReadMatrix<T>(int Adress, int MatrixSize) where T : struct
    {
      byte[] numArray = new byte[Marshal.SizeOf(typeof (T)) * MatrixSize];
      Mem.ReadProcessMemory((int) Mem.m_pProcessHandle, Adress, numArray, numArray.Length, ref Mem.m_iNumberOfBytesRead);
      return Mem.ConvertToFloatArray(numArray);
    }

    public static void WriteMemory<T>(int Adress, object Value) where T : struct
    {
      byte[] byteArray = Mem.StructureToByteArray(Value);
      Mem.WriteProcessMemory((int) Mem.m_pProcessHandle, Adress, byteArray, byteArray.Length, out Mem.m_iNumberOfBytesWritten);
    }

    public static float[] ConvertToFloatArray(byte[] bytes)
    {
      if ((uint) (bytes.Length % 4) > 0U)
        throw new ArgumentException();
      float[] numArray = new float[bytes.Length / 4];
      for (int index = 0; index < numArray.Length; ++index)
        numArray[index] = BitConverter.ToSingle(bytes, index * 4);
      return numArray;
    }

    private static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
    {
      GCHandle gcHandle = GCHandle.Alloc((object) bytes, GCHandleType.Pinned);
      try
      {
        return (T) Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject(), typeof (T));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    private static byte[] StructureToByteArray(object obj)
    {
      int length = Marshal.SizeOf(obj);
      byte[] destination = new byte[length];
      IntPtr num = Marshal.AllocHGlobal(length);
      Marshal.StructureToPtr(obj, num, true);
      Marshal.Copy(num, destination, 0, length);
      Marshal.FreeHGlobal(num);
      return destination;
    }

    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll")]
    private static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, ref int lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    private static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, out int lpNumberOfBytesWritten);
  }
}
