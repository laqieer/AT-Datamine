// Decompiled with JetBrains decompiler
// Type: Gacha.GachaPayButtonPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200155E")]
  internal class GachaPayButtonPresenter : IGachaPayButtonPresenter
  {
    [Token(Token = "0x400621F")]
    [FieldOffset(Offset = "0x10")]
    private GachaPaymentModel model;
    [Token(Token = "0x4006220")]
    [FieldOffset(Offset = "0x18")]
    private ItemUtility.Parameter itemParameter;
    [Token(Token = "0x4006221")]
    [FieldOffset(Offset = "0x78")]
    private GachaAssetBundleInfo.AssetBundleInfo mainIconAssetBundleInfo;
    [Token(Token = "0x4006222")]
    [FieldOffset(Offset = "0x80")]
    private GachaAssetBundleInfo.AssetBundleInfo miniIconAssetBundleInfo;
    [Token(Token = "0x4006223")]
    [FieldOffset(Offset = "0x88")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x4006224")]
    [FieldOffset(Offset = "0x90")]
    public Action<GachaPaymentModel> PayButtonClicked;

    [Token(Token = "0x6007908")]
    [Address(RVA = "0x44F02CC", Offset = "0x44F02CC", VA = "0x44F02CC")]
    public GachaPayButtonPresenter(
      GachaPaymentModel model,
      Action<GachaPaymentModel> payButtonClicked,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6007909")]
    [Address(RVA = "0x44F0370", Offset = "0x44F0370", VA = "0x44F0370", Slot = "5")]
    public void AssignView(GachaPayButtonView view)
    {
    }

    [Token(Token = "0x600790A")]
    [Address(RVA = "0x44FFB00", Offset = "0x44FFB00", VA = "0x44FFB00", Slot = "4")]
    public void AssignGachaResultPayButtonView(GachaPayButtonView view)
    {
    }

    [Token(Token = "0x600790B")]
    [Address(RVA = "0x44FFBF0", Offset = "0x44FFBF0", VA = "0x44FFBF0")]
    public void OnPayButtonClicked()
    {
    }

    [Token(Token = "0x600790C")]
    [Address(RVA = "0x44FFA08", Offset = "0x44FFA08", VA = "0x44FFA08")]
    private void Preload()
    {
    }
  }
}
