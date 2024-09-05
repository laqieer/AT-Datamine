// Decompiled with JetBrains decompiler
// Type: Network.Encrypt.APICypher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Network.Encrypt
{
  [Token(Token = "0x2001B1B")]
  public class APICypher
  {
    [Token(Token = "0x4007485")]
    private const string SHARED_KEY = "doTuocj5+oyEA6hFsNAwSFibNo5xrew/p6/KjRXc/Zw=";
    [Token(Token = "0x4007486")]
    private const int AESKeyLength = 16;
    [Token(Token = "0x4007487")]
    [FieldOffset(Offset = "0x10")]
    private readonly byte[] _aesKey;

    [Token(Token = "0x6009F54")]
    [Address(RVA = "0x46BE774", Offset = "0x46BE774", VA = "0x46BE774")]
    public static byte[] GetAESKey(
      string path,
      string requestId,
      string deviceId,
      int requestTime)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x6009F55")]
    [Address(RVA = "0x46BEA48", Offset = "0x46BEA48", VA = "0x46BEA48")]
    public APICypher(byte[] aesKey)
    {
    }

    [Token(Token = "0x6009F56")]
    [Address(RVA = "0x46BEA70", Offset = "0x46BEA70", VA = "0x46BEA70")]
    public byte[] Encrypt(string content) => (byte[]) null;

    [Token(Token = "0x6009F57")]
    [Address(RVA = "0x46BF1D0", Offset = "0x46BF1D0", VA = "0x46BF1D0")]
    public string Decrypt(byte[] data) => (string) null;
  }
}
