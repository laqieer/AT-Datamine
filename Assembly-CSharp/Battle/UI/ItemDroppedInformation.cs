// Decompiled with JetBrains decompiler
// Type: Battle.UI.ItemDroppedInformation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20022FB")]
  public class ItemDroppedInformation : MonoBehaviour
  {
    [Token(Token = "0x4009407")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x4009408")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI copperNumber;
    [Token(Token = "0x4009409")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI silverNumber;
    [Token(Token = "0x400940A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI goldNumber;
    [Token(Token = "0x400940B")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<ItemDroppedInformation.RareType, int> holdDropItems;

    [Token(Token = "0x600D5D5")]
    [Address(RVA = "0x1D18934", Offset = "0x1D18934", VA = "0x1D18934")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D5D6")]
    [Address(RVA = "0x1D18984", Offset = "0x1D18984", VA = "0x1D18984")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600D5D7")]
    [Address(RVA = "0x1D189AC", Offset = "0x1D189AC", VA = "0x1D189AC")]
    public void SetUp(BoardData boardData, BattlePlayerData battlePlayerData)
    {
    }

    [Token(Token = "0x600D5D8")]
    [Address(RVA = "0x1D18E90", Offset = "0x1D18E90", VA = "0x1D18E90")]
    public void Show()
    {
    }

    [Token(Token = "0x600D5D9")]
    [Address(RVA = "0x1D18988", Offset = "0x1D18988", VA = "0x1D18988")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D5DA")]
    [Address(RVA = "0x1D18EB4", Offset = "0x1D18EB4", VA = "0x1D18EB4")]
    public void UpdateChestDropItemNumber(
      BoardData boardData,
      BattlePlayerData battlePlayerData,
      bool effectPlay = true)
    {
    }

    [Token(Token = "0x600D5DB")]
    [Address(RVA = "0x1D191F0", Offset = "0x1D191F0", VA = "0x1D191F0")]
    public void UpdateEnemyDropItemNumber(
      BoardData boardData,
      BattlePlayerData battlePlayerData,
      DropData drop)
    {
    }

    [Token(Token = "0x600D5DC")]
    [Address(RVA = "0x1D18A34", Offset = "0x1D18A34", VA = "0x1D18A34")]
    public void UpdateItemNumber(BoardData boardData, BattlePlayerData battlePlayerData)
    {
    }

    [Token(Token = "0x600D5DD")]
    [Address(RVA = "0x1D19134", Offset = "0x1D19134", VA = "0x1D19134")]
    private void TweenAnimaPlay(ItemDroppedInformation.RareType rare)
    {
    }

    [Token(Token = "0x600D5DE")]
    [Address(RVA = "0x1D19260", Offset = "0x1D19260", VA = "0x1D19260")]
    public ItemDroppedInformation()
    {
    }

    [Token(Token = "0x20022FC")]
    public enum RareType
    {
      [Token(Token = "0x400940D")] Copper,
      [Token(Token = "0x400940E")] Silver,
      [Token(Token = "0x400940F")] Gold,
    }
  }
}
