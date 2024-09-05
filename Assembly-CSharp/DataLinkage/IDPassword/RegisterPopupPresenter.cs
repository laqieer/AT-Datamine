// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.RegisterPopupPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace DataLinkage.IDPassword
{
  [Token(Token = "0x2001FB6")]
  public class RegisterPopupPresenter : IRegisterPopupPresenter
  {
    [Token(Token = "0x4008777")]
    [FieldOffset(Offset = "0x10")]
    private IDPasswordLinkageModel model;
    [Token(Token = "0x4008778")]
    [FieldOffset(Offset = "0x18")]
    private RegisterPopup view;

    [Token(Token = "0x600BC3D")]
    [Address(RVA = "0x1E5132C", Offset = "0x1E5132C", VA = "0x1E5132C")]
    public RegisterPopupPresenter(IDPasswordLinkageModel model, RegisterPopup view)
    {
    }

    [Token(Token = "0x600BC3E")]
    [Address(RVA = "0x1E51ADC", Offset = "0x1E51ADC", VA = "0x1E51ADC", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BC3F")]
    [Address(RVA = "0x1E51B40", Offset = "0x1E51B40", VA = "0x1E51B40", Slot = "5")]
    public void Release()
    {
    }

    [Token(Token = "0x600BC40")]
    [Address(RVA = "0x1E51B44", Offset = "0x1E51B44", VA = "0x1E51B44", Slot = "6")]
    public void Decide()
    {
    }

    [Token(Token = "0x600BC41")]
    [Address(RVA = "0x1E51DA0", Offset = "0x1E51DA0", VA = "0x1E51DA0", Slot = "7")]
    public void Cancel()
    {
    }

    [Token(Token = "0x600BC42")]
    [Address(RVA = "0x1E51DC0", Offset = "0x1E51DC0", VA = "0x1E51DC0")]
    private void OnRegisterSuccess()
    {
    }

    [Token(Token = "0x600BC43")]
    [Address(RVA = "0x1E51E68", Offset = "0x1E51E68", VA = "0x1E51E68")]
    private IEnumerator OnRegisterError(string errorCode) => (IEnumerator) null;
  }
}
