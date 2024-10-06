// Decompiled with JetBrains decompiler
// Type: DataLinkage.FgGID.ILinkStatusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage.FgGID
{
  [Token(Token = "0x2001FD1")]
  public interface ILinkStatusView
  {
    [Token(Token = "0x17002704")]
    ILinkStatusPresenter Presenter { [Token(Token = "0x600BCCF")] set; }

    [Token(Token = "0x600BCD0")]
    void SetUserDataIsValid(bool isValid);

    [Token(Token = "0x600BCD1")]
    void SetIsLinked(bool isLinked);
  }
}
