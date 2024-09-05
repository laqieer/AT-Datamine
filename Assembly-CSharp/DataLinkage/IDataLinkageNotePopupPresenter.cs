// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDataLinkageNotePopupPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F75")]
  public interface IDataLinkageNotePopupPresenter
  {
    [Token(Token = "0x600BAC7")]
    void Initialize();

    [Token(Token = "0x600BAC8")]
    void Release();

    [Token(Token = "0x600BAC9")]
    void Agree();

    [Token(Token = "0x600BACA")]
    void NotAgree();

    [Token(Token = "0x600BACB")]
    void Cancel();
  }
}
