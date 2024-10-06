// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013DF")]
  public class FileHeader
  {
    [Token(Token = "0x4005CCB")]
    [FieldOffset(Offset = "0x0")]
    public static byte[] MagicNumber;
    [Token(Token = "0x4005CCC")]
    [FieldOffset(Offset = "0x8")]
    public static uint CurrentVersion;
    [Token(Token = "0x4005CCD")]
    [FieldOffset(Offset = "0x10")]
    public byte[] Magic;
    [Token(Token = "0x4005CCE")]
    [FieldOffset(Offset = "0x18")]
    private uint Version;
    [Token(Token = "0x4005CCF")]
    [FieldOffset(Offset = "0x1C")]
    private int DeclarationNum;

    [Token(Token = "0x6006F76")]
    [Address(RVA = "0x4205CDC", Offset = "0x4205CDC", VA = "0x4205CDC")]
    public FileHeader(int declarationNum = 0)
    {
    }

    [Token(Token = "0x6006F77")]
    [Address(RVA = "0x4205D5C", Offset = "0x4205D5C", VA = "0x4205D5C")]
    public FileHeader(FileReader reader)
    {
    }

    [Token(Token = "0x6006F78")]
    [Address(RVA = "0x4205DFC", Offset = "0x4205DFC", VA = "0x4205DFC")]
    public void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F79")]
    [Address(RVA = "0x4205D88", Offset = "0x4205D88", VA = "0x4205D88")]
    public void Read(FileReader reader)
    {
    }

    [Token(Token = "0x6006F7A")]
    [Address(RVA = "0x4205E60", Offset = "0x4205E60", VA = "0x4205E60")]
    public void CheckMagicNumber()
    {
    }

    [Token(Token = "0x6006F7B")]
    [Address(RVA = "0x4205F30", Offset = "0x4205F30", VA = "0x4205F30")]
    static FileHeader()
    {
    }
  }
}
