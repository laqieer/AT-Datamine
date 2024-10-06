// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileWriter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013E0")]
  public class FileWriter : BinaryWriter
  {
    [Token(Token = "0x6006F7C")]
    [Address(RVA = "0x4205FD4", Offset = "0x4205FD4", VA = "0x4205FD4")]
    public FileWriter(Stream stream)
    {
    }

    [Token(Token = "0x6006F7D")]
    [Address(RVA = "0x420603C", Offset = "0x420603C", VA = "0x420603C")]
    public void Write(FileHeader header)
    {
    }

    [Token(Token = "0x6006F7E")]
    [Address(RVA = "0x4206058", Offset = "0x4206058", VA = "0x4206058")]
    public void Write(FileDeclaration declaration)
    {
    }
  }
}
