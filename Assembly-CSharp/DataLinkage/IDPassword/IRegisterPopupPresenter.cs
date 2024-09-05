// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.IRegisterPopupPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage.IDPassword
{
  [Token(Token = "0x2001FB1")]
  public interface IRegisterPopupPresenter
  {
    [Token(Token = "0x600BC15")]
    void Initialize();

    [Token(Token = "0x600BC16")]
    void Release();

    [Token(Token = "0x600BC17")]
    void Decide();

    [Token(Token = "0x600BC18")]
    void Cancel();
  }
}
