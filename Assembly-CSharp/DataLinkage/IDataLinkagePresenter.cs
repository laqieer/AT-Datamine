// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDataLinkagePresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F8F")]
  public interface IDataLinkagePresenter
  {
    [Token(Token = "0x600BB56")]
    void RequestLinkage();

    [Token(Token = "0x600BB57")]
    void RequestDisconnect();

    [Token(Token = "0x600BB58")]
    void Initialize();

    [Token(Token = "0x600BB59")]
    void Release();

    [Token(Token = "0x600BB5A")]
    void LinkedButtonClicked();
  }
}
