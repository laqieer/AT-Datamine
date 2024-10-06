// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013E1")]
  public class FileReader : BinaryReader
  {
    [Token(Token = "0x4005CD0")]
    [FieldOffset(Offset = "0x0")]
    public static byte[] Magic;
    [Token(Token = "0x4005CD1")]
    [FieldOffset(Offset = "0x48")]
    public List<FileDeclaration> DeclarationStack;
    [Token(Token = "0x4005CD2")]
    [FieldOffset(Offset = "0x50")]
    public List<FileInitDeclarator> InitDeclaratorStack;
    [Token(Token = "0x4005CD3")]
    [FieldOffset(Offset = "0x58")]
    private uint Version;
    [Token(Token = "0x4005CD4")]
    [FieldOffset(Offset = "0x5C")]
    private int DeclarationNum;

    [Token(Token = "0x170010BA")]
    public FileDeclaration Declaration
    {
      [Token(Token = "0x6006F7F"), Address(RVA = "0x4206074", Offset = "0x4206074", VA = "0x4206074")] get
      {
        return (FileDeclaration) null;
      }
    }

    [Token(Token = "0x170010BB")]
    public FileInitDeclarator InitDeclarator
    {
      [Token(Token = "0x6006F80"), Address(RVA = "0x42060D8", Offset = "0x42060D8", VA = "0x42060D8")] get
      {
        return (FileInitDeclarator) null;
      }
    }

    [Token(Token = "0x6006F81")]
    [Address(RVA = "0x4206144", Offset = "0x4206144", VA = "0x4206144")]
    public FileReader(Stream stream)
    {
    }

    [Token(Token = "0x6006F82")]
    [Address(RVA = "0x4206214", Offset = "0x4206214", VA = "0x4206214")]
    public string ReadUnicodeString() => (string) null;

    [Token(Token = "0x6006F83")]
    [Address(RVA = "0x4206270", Offset = "0x4206270", VA = "0x4206270")]
    public FileHeader ReadHeader() => (FileHeader) null;

    [Token(Token = "0x6006F84")]
    [Address(RVA = "0x4205BAC", Offset = "0x4205BAC", VA = "0x4205BAC")]
    public FileSpecifier ReadSpecifier() => (FileSpecifier) null;

    [Token(Token = "0x6006F85")]
    [Address(RVA = "0x4205414", Offset = "0x4205414", VA = "0x4205414")]
    public FileDeclarator ReadDeclarator() => (FileDeclarator) null;

    [Token(Token = "0x6006F86")]
    [Address(RVA = "0x42053F8", Offset = "0x42053F8", VA = "0x42053F8")]
    public FileExpression ReadExpression() => (FileExpression) null;

    [Token(Token = "0x6006F87")]
    [Address(RVA = "0x42062DC", Offset = "0x42062DC", VA = "0x42062DC", Slot = "28")]
    public virtual FileInitializer ReadInitializer() => (FileInitializer) null;

    [Token(Token = "0x6006F88")]
    [Address(RVA = "0x4205C70", Offset = "0x4205C70", VA = "0x4205C70")]
    public FileInitDeclarator ReadInitDeclarator() => (FileInitDeclarator) null;

    [Token(Token = "0x6006F89")]
    [Address(RVA = "0x4205014", Offset = "0x4205014", VA = "0x4205014")]
    public FileDeclaration ReadDeclaration() => (FileDeclaration) null;

    [Token(Token = "0x6006F8A")]
    [Address(RVA = "0x4206394", Offset = "0x4206394", VA = "0x4206394")]
    static FileReader()
    {
    }
  }
}
