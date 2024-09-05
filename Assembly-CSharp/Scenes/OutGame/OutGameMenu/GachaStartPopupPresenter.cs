// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GachaStartPopupPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha;
using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039E4")]
  internal class GachaStartPopupPresenter : IGachaStartPopupPresenter
  {
    [Token(Token = "0x400FD45")]
    [FieldOffset(Offset = "0x10")]
    private GachaStartPopup view;
    [Token(Token = "0x400FD46")]
    [FieldOffset(Offset = "0x18")]
    private GachaPaymentModel paymentModel;
    [Token(Token = "0x400FD47")]
    [FieldOffset(Offset = "0x20")]
    private IGachaLogoTextureProvider logoTextureProvider;
    [Token(Token = "0x400FD48")]
    [FieldOffset(Offset = "0x28")]
    public Action<GachaPaymentModel> PayButtonClicked;
    [Token(Token = "0x400FD49")]
    [FieldOffset(Offset = "0x30")]
    public Action CancelButtonClicked;

    [Token(Token = "0x6016BB6")]
    [Address(RVA = "0x3F6F0E0", Offset = "0x3F6F0E0", VA = "0x3F6F0E0")]
    public GachaStartPopupPresenter(
      GachaStartPopup view,
      GachaPaymentModel paymentModel,
      IGachaLogoTextureProvider logoTextureProvider)
    {
    }

    [Token(Token = "0x6016BB7")]
    [Address(RVA = "0x3F6F11C", Offset = "0x3F6F11C", VA = "0x3F6F11C", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6016BB8")]
    [Address(RVA = "0x3F6F698", Offset = "0x3F6F698", VA = "0x3F6F698", Slot = "5")]
    public void Release()
    {
    }

    [Token(Token = "0x6016BB9")]
    [Address(RVA = "0x3F6F69C", Offset = "0x3F6F69C", VA = "0x3F6F69C")]
    private void Decide()
    {
    }

    [Token(Token = "0x6016BBA")]
    [Address(RVA = "0x3F6F784", Offset = "0x3F6F784", VA = "0x3F6F784")]
    private void Cancel()
    {
    }
  }
}
