// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardBulkReleaseNodeContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200330D")]
  internal class AbilityBoardBulkReleaseNodeContent : MonoBehaviour
  {
    [Token(Token = "0x400DC86")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AbilityBoardIcon nodeIcon;
    [Token(Token = "0x400DC87")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text nodeText;
    [Token(Token = "0x400DC88")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform itemContentParent;
    [Token(Token = "0x400DC89")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AbilityBoardPaymentItemContent itemContent;
    [Token(Token = "0x400DC8A")]
    [FieldOffset(Offset = "0x38")]
    public IItemDetailController itemDetailController;
    [Token(Token = "0x400DC8B")]
    [FieldOffset(Offset = "0x40")]
    public IAbilityBoardIconLoader iconLoader;

    [Token(Token = "0x6014102")]
    [Address(RVA = "0x235567C", Offset = "0x235567C", VA = "0x235567C")]
    public void SetNodeData(AbilityBoardReleaseNodeData data, Style style)
    {
    }

    [Token(Token = "0x6014103")]
    [Address(RVA = "0x235597C", Offset = "0x235597C", VA = "0x235597C")]
    public AbilityBoardBulkReleaseNodeContent()
    {
    }
  }
}
