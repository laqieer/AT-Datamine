// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.AddDevicePopupPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace DataLinkage.IDPassword
{
  [Token(Token = "0x2001F98")]
  public class AddDevicePopupPresenter : IAddDevicePopupPresenter
  {
    [Token(Token = "0x4008711")]
    [FieldOffset(Offset = "0x10")]
    private IDPasswordLinkageModel model;
    [Token(Token = "0x4008712")]
    [FieldOffset(Offset = "0x18")]
    private AddDevicePopup view;

    [Token(Token = "0x600BB96")]
    [Address(RVA = "0x1E4D880", Offset = "0x1E4D880", VA = "0x1E4D880")]
    public AddDevicePopupPresenter(IDPasswordLinkageModel model, AddDevicePopup view)
    {
    }

    [Token(Token = "0x600BB97")]
    [Address(RVA = "0x1E4E2BC", Offset = "0x1E4E2BC", VA = "0x1E4E2BC", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BB98")]
    [Address(RVA = "0x1E4E318", Offset = "0x1E4E318", VA = "0x1E4E318", Slot = "5")]
    public void Release()
    {
    }

    [Token(Token = "0x600BB99")]
    [Address(RVA = "0x1E4E31C", Offset = "0x1E4E31C", VA = "0x1E4E31C", Slot = "6")]
    public void Decide()
    {
    }

    [Token(Token = "0x600BB9A")]
    [Address(RVA = "0x1E4E8B0", Offset = "0x1E4E8B0", VA = "0x1E4E8B0", Slot = "7")]
    public void Cancel()
    {
    }

    [Token(Token = "0x600BB9B")]
    [Address(RVA = "0x1E4E8D0", Offset = "0x1E4E8D0", VA = "0x1E4E8D0")]
    private void OnAddDeviceSuccess()
    {
    }

    [Token(Token = "0x600BB9C")]
    [Address(RVA = "0x1E4E944", Offset = "0x1E4E944", VA = "0x1E4E944")]
    private IEnumerator OnAddDeviceError(string errorCode) => (IEnumerator) null;
  }
}
