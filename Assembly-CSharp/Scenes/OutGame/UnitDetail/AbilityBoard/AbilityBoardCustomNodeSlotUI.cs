// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardCustomNodeSlotUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200331F")]
  public class AbilityBoardCustomNodeSlotUI : MonoBehaviour
  {
    [Token(Token = "0x400DD26")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x400DD27")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AbilityBoardCustomSlotContent gold;
    [Token(Token = "0x400DD28")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AbilityBoardCustomSlotContent silver;
    [Token(Token = "0x400DD29")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AbilityBoardCustomSlotContent bronze;
    [Token(Token = "0x400DD2A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text bonusText;
    [Token(Token = "0x400DD2B")]
    [FieldOffset(Offset = "0x40")]
    private AbilityBoardStyleSettingData styleSettingData;
    [Token(Token = "0x400DD2C")]
    [FieldOffset(Offset = "0x48")]
    private List<AbilityBoardCustomSlotContent> slots;

    [Token(Token = "0x601418E")]
    [Address(RVA = "0x20C0EC0", Offset = "0x20C0EC0", VA = "0x20C0EC0")]
    public void SetData(
      AbilityBoardStyleSettingData styleSettingData,
      List<int> nodeId,
      List<int> frameId,
      bool showText,
      int customId)
    {
    }

    [Token(Token = "0x601418F")]
    [Address(RVA = "0x20C1204", Offset = "0x20C1204", VA = "0x20C1204")]
    public void FirstOpen()
    {
    }

    [Token(Token = "0x6014190")]
    [Address(RVA = "0x20C6D38", Offset = "0x20C6D38", VA = "0x20C6D38")]
    private void CreateSlot(int nodeId, int frameId, string effect, bool showText)
    {
    }

    [Token(Token = "0x6014191")]
    [Address(RVA = "0x20C1F84", Offset = "0x20C1F84", VA = "0x20C1F84")]
    public void Clear()
    {
    }

    [Token(Token = "0x6014192")]
    [Address(RVA = "0x20C70A4", Offset = "0x20C70A4", VA = "0x20C70A4")]
    public AbilityBoardCustomNodeSlotUI()
    {
    }
  }
}
