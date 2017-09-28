using System;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;

namespace GamelolCenterServer
{
    class Program
    {
        public static PerformanceCounter cpu;
        //public static ComputerInfo cif;  
        static void Main(string[] args)
        {
            cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            // cif = new ComputerInfo();  
            MEMORY_INFO MemInfo;
            MemInfo = new MEMORY_INFO();
            while (true)
            {
                GlobalMemoryStatus(ref MemInfo);
                Console.WriteLine(MemInfo.dwMemoryLoad.ToString() + "%的内存正在使用");
                var percentage = cpu.NextValue();
                Console.WriteLine(percentage + "%的CPU正在使用\n");
                System.Threading.Thread.Sleep(2000);
            }


        }
        [DllImport("kernel32")]
        public static extern void GetSystemDirectory(StringBuilder SysDir, int count);
        [DllImport("kernel32")]
        public static extern void GetSystemInfo(ref CPU_INFO cpuinfo);
        [DllImport("kernel32")]
        public static extern void GlobalMemoryStatus(ref MEMORY_INFO meminfo);
        [DllImport("kernel32")]
        public static extern void GetSystemTime(ref SYSTEMTIME_INFO stinfo);
    }

    //定义CPU的信息结构    
    [StructLayout(LayoutKind.Sequential)]
    public struct CPU_INFO
    {
        public uint dwOemId;
        public uint dwPageSize;
        public uint lpMinimumApplicationAddress;
        public uint lpMaximumApplicationAddress;
        public uint dwActiveProcessorMask;
        public uint dwNumberOfProcessors;
        public uint dwProcessorType;
        public uint dwAllocationGranularity;
        public uint dwProcessorLevel;
        public uint dwProcessorRevision;
    }


    //定义内存的信息结构    
    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_INFO
    {
        public uint dwLength;
        public uint dwMemoryLoad;
        public uint dwTotalPhys;
        public uint dwAvailPhys;
        public uint dwTotalPageFile;
        public uint dwAvailPageFile;
        public uint dwTotalVirtual;
        public uint dwAvailVirtual;
    }


    //定义系统时间的信息结构    
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEMTIME_INFO
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }
}
