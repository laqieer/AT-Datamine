// Decompiled with JetBrains decompiler
// Type: GameCore.Utility.Security
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Security.Cryptography;

#nullable disable
namespace GameCore.Utility
{
  [Token(Token = "0x2000BD1")]
  public class Security
  {
    [Token(Token = "0x60043A0")]
    [Address(RVA = "0x3642180", Offset = "0x3642180", VA = "0x3642180")]
    public static string GetMD5(byte[] bytes) => (string) null;

    [Token(Token = "0x60043A1")]
    [Address(RVA = "0x3642270", Offset = "0x3642270", VA = "0x3642270")]
    private static RijndaelManaged GetCryptInstance() => (RijndaelManaged) null;

    [Token(Token = "0x60043A2")]
    [Address(RVA = "0x364241C", Offset = "0x364241C", VA = "0x364241C")]
    public static byte[] Encrypt(byte[] src) => (byte[]) null;

    [Token(Token = "0x60043A3")]
    [Address(RVA = "0x3642638", Offset = "0x3642638", VA = "0x3642638")]
    public static byte[] Decrypt(byte[] src) => (byte[]) null;

    [Token(Token = "0x60043A4")]
    [Address(RVA = "0x36428EC", Offset = "0x36428EC", VA = "0x36428EC")]
    public Security()
    {
    }
  }
}
