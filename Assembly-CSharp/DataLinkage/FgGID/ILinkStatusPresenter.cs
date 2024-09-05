// Decompiled with JetBrains decompiler
// Type: DataLinkage.FgGID.ILinkStatusPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage.FgGID
{
  [Token(Token = "0x2001FD0")]
  public interface ILinkStatusPresenter
  {
    [Token(Token = "0x600BCCC")]
    void Initialize();

    [Token(Token = "0x600BCCD")]
    void Release();

    [Token(Token = "0x600BCCE")]
    void StatusButtonClicked();
  }
}
