// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkageDataModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F6D")]
  public class DataLinkageDataModel
  {
    [Token(Token = "0x170026B2")]
    public DataLinkageNoteStatusType DataLinkageNoteStatusType
    {
      [Token(Token = "0x600BA86"), Address(RVA = "0x1E47298", Offset = "0x1E47298", VA = "0x1E47298")] get
      {
        return new DataLinkageNoteStatusType();
      }
      [Token(Token = "0x600BA87"), Address(RVA = "0x1E472A0", Offset = "0x1E472A0", VA = "0x1E472A0")] private set
      {
      }
    }

    [Token(Token = "0x170026B3")]
    public bool IsNoteConfirmed
    {
      [Token(Token = "0x600BA88"), Address(RVA = "0x1E472A8", Offset = "0x1E472A8", VA = "0x1E472A8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170026B4")]
    public bool IsNoteAgreed
    {
      [Token(Token = "0x600BA89"), Address(RVA = "0x1E472B8", Offset = "0x1E472B8", VA = "0x1E472B8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170026B5")]
    public bool IsNoteNotAgreed
    {
      [Token(Token = "0x600BA8A"), Address(RVA = "0x1E472C8", Offset = "0x1E472C8", VA = "0x1E472C8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BA8B")]
    [Address(RVA = "0x1E472D8", Offset = "0x1E472D8", VA = "0x1E472D8")]
    public DataLinkageDataModel()
    {
    }

    [Token(Token = "0x600BA8C")]
    [Address(RVA = "0x1E47370", Offset = "0x1E47370", VA = "0x1E47370")]
    public void ApplyDataLinkageNoteAgreeChanged(bool isAgree)
    {
    }
  }
}
