// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileArrayDeclarator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013D8")]
  public class FileArrayDeclarator : FileDeclarator
  {
    [Token(Token = "0x4005CC1")]
    [FieldOffset(Offset = "0x10")]
    public FileDeclarator Declarator;
    [Token(Token = "0x4005CC2")]
    [FieldOffset(Offset = "0x18")]
    public FileExpression Subscript;

    [Token(Token = "0x6006F5B")]
    [Address(RVA = "0x42052D8", Offset = "0x42052D8", VA = "0x42052D8")]
    public FileArrayDeclarator(FileReader reader)
    {
    }

    [Token(Token = "0x6006F5C")]
    [Address(RVA = "0x420530C", Offset = "0x420530C", VA = "0x420530C")]
    public FileArrayDeclarator(FileDeclarator declarator, FileExpression subscript = null)
    {
    }

    [Token(Token = "0x6006F5D")]
    [Address(RVA = "0x4205338", Offset = "0x4205338", VA = "0x4205338", Slot = "4")]
    public override void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F5E")]
    [Address(RVA = "0x42053B4", Offset = "0x42053B4", VA = "0x42053B4", Slot = "5")]
    public override void Read(FileReader reader)
    {
    }
  }
}
