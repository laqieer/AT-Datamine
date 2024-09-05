// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Builder.FreeMapPassiveMessageUIBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Control.Animation;
using FreeMap.UI.Element;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Builder
{
  [Token(Token = "0x2001776")]
  public class FreeMapPassiveMessageUIBuilder : FreeMapInstanceUIBuilder<FreeMapPassiveMessageUI>
  {
    [Token(Token = "0x40067FB")]
    private const string IconAssetBundleName = "ui_page_adv";
    [Token(Token = "0x40067FC")]
    private const string IconAssetName = "Adv_PassiveMessageIcon";
    [Token(Token = "0x40067FD")]
    private const string PassiveMsgAssetBundleName = "ui_page_adv";
    [Token(Token = "0x40067FE")]
    private const string PassiveMsgAssetName = "Adv_PassiveMessage";
    [Token(Token = "0x40067FF")]
    [FieldOffset(Offset = "0x0")]
    private static readonly UIShowTweenNameList AdvPassiveMsgIconShowTweenNameList;
    [Token(Token = "0x4006800")]
    [FieldOffset(Offset = "0x8")]
    private static readonly UIShowTweenNameList AdvPassiveMsgShowTweenNameList;
    [Token(Token = "0x4006802")]
    [FieldOffset(Offset = "0x20")]
    private GameObject iconPrefab;
    [Token(Token = "0x4006803")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> advMsgList;

    [Token(Token = "0x170014F8")]
    private FreeMapPassiveMessageParam UIParameter
    {
      [Token(Token = "0x60084ED"), Address(RVA = "0x4068E4C", Offset = "0x4068E4C", VA = "0x4068E4C")] get
      {
        return (FreeMapPassiveMessageParam) null;
      }
    }

    [Token(Token = "0x170014F9")]
    protected override Vector3 OffsetPos
    {
      [Token(Token = "0x60084EE"), Address(RVA = "0x4068E54", Offset = "0x4068E54", VA = "0x4068E54", Slot = "8")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x60084EF")]
    [Address(RVA = "0x4068E74", Offset = "0x4068E74", VA = "0x4068E74")]
    public FreeMapPassiveMessageUIBuilder(FreeMapPassiveMessageParam param)
    {
    }

    [Token(Token = "0x60084F0")]
    [Address(RVA = "0x4068ED0", Offset = "0x4068ED0", VA = "0x4068ED0", Slot = "9")]
    protected override void InitializeInternal(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x60084F1")]
    [Address(RVA = "0x40690FC", Offset = "0x40690FC", VA = "0x40690FC", Slot = "10")]
    protected override void BuildInternal(
      Transform uiParent,
      FreeMapInstance target,
      FreeMapUITransformHolder holder,
      FreeMapCommonElement commonElement,
      FreeMapIconEventControlElement iconEventElement)
    {
    }

    [Token(Token = "0x60084F2")]
    [Address(RVA = "0x4069548", Offset = "0x4069548", VA = "0x4069548", Slot = "12")]
    protected override void FinalizeInternal()
    {
    }

    [Token(Token = "0x60084F3")]
    [Address(RVA = "0x4069550", Offset = "0x4069550", VA = "0x4069550")]
    private void IconAssetLoadCallback(GameObject asset)
    {
    }

    [Token(Token = "0x60084F4")]
    [Address(RVA = "0x40696C4", Offset = "0x40696C4", VA = "0x40696C4")]
    private void PassiveMsgAssetLoadCallback(GameObject asset)
    {
    }

    [Token(Token = "0x60084F5")]
    [Address(RVA = "0x40699E8", Offset = "0x40699E8", VA = "0x40699E8")]
    static FreeMapPassiveMessageUIBuilder()
    {
    }
  }
}
