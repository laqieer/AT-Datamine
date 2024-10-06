// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PrepareDotUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DotModelUI;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003226")]
  public class PrepareDotUnit : MonoBehaviour
  {
    [Token(Token = "0x400D636")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform dotModel;
    [Token(Token = "0x400D637")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject emptyUnit;
    [Token(Token = "0x400D638")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] elementIcons;
    [Token(Token = "0x400D639")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI platoonNo;
    [Token(Token = "0x400D63A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400D63B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private DotModelRenderUIImage dotModelUiImage;
    [Token(Token = "0x400D63C")]
    [FieldOffset(Offset = "0x48")]
    private GameObject dotObj;

    [Token(Token = "0x6013908")]
    [Address(RVA = "0x49CADE0", Offset = "0x49CADE0", VA = "0x49CADE0")]
    public void Initialize(
      Style styleData,
      int index,
      int partyIndex,
      bool isforceUnit,
      bool isSortieUnit,
      GameObject dotObj,
      bool overSlot)
    {
    }

    [Token(Token = "0x6013909")]
    [Address(RVA = "0x49CB060", Offset = "0x49CB060", VA = "0x49CB060")]
    private void SetElementIconActive(ElementTypeEnum? elementType)
    {
    }

    [Token(Token = "0x601390A")]
    [Address(RVA = "0x49CB178", Offset = "0x49CB178", VA = "0x49CB178")]
    private void SetPartyNumber(ForceTypeEnum forceType, int partyIndex)
    {
    }

    [Token(Token = "0x601390B")]
    [Address(RVA = "0x49CAFD4", Offset = "0x49CAFD4", VA = "0x49CAFD4")]
    public void Delete()
    {
    }

    [Token(Token = "0x601390C")]
    [Address(RVA = "0x49CB290", Offset = "0x49CB290", VA = "0x49CB290")]
    public PrepareDotUnit()
    {
    }
  }
}
