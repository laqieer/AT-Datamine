// Decompiled with JetBrains decompiler
// Type: Gacha.SelectGachaTop
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
  [Token(Token = "0x2001569")]
  internal class SelectGachaTop : GachaTop
  {
    [Token(Token = "0x4006237")]
    [FieldOffset(Offset = "0x58")]
    public Action<GachaDetailInfo> SelectGachaPopupOpenCallback;
    [Token(Token = "0x4006238")]
    [FieldOffset(Offset = "0x60")]
    private SelectGachaTopView view;

    [Token(Token = "0x6007933")]
    [Address(RVA = "0x2294960", Offset = "0x2294960", VA = "0x2294960")]
    public SelectGachaTop(
      SelectGachaTopView view,
      GachaPayButtonTab gachaPayButtonTab,
      IGachaResourceProvider resourceProvider,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6007934")]
    [Address(RVA = "0x2294A20", Offset = "0x2294A20", VA = "0x2294A20")]
    private void OnSelectButtonClicked()
    {
    }

    [Token(Token = "0x6007935")]
    [Address(RVA = "0x2294A58", Offset = "0x2294A58", VA = "0x2294A58", Slot = "4")]
    public override void OnGachaDetailChanged(GachaInfoHolder gachaInfoHolder, string gachaName)
    {
    }

    [Token(Token = "0x6007936")]
    [Address(RVA = "0x2294BB0", Offset = "0x2294BB0", VA = "0x2294BB0")]
    private void SetupSelectGacha()
    {
    }

    [Token(Token = "0x6007937")]
    [Address(RVA = "0x2294CDC", Offset = "0x2294CDC", VA = "0x2294CDC")]
    public void Hide()
    {
    }
  }
}
