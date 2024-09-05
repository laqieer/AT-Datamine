// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.IAddDevicePopupPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage.IDPassword
{
  [Token(Token = "0x2001FA5")]
  public interface IAddDevicePopupPresenter
  {
    [Token(Token = "0x600BBDE")]
    void Initialize();

    [Token(Token = "0x600BBDF")]
    void Release();

    [Token(Token = "0x600BBE0")]
    void Decide();

    [Token(Token = "0x600BBE1")]
    void Cancel();
  }
}
