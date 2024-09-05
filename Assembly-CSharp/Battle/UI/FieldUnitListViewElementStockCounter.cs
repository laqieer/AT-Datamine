// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldUnitListViewElementStockCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200241F")]
  public class FieldUnitListViewElementStockCounter : MonoBehaviour
  {
    [Token(Token = "0x4009A93")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x4009A94")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI CurrentStockCounter;
    [Token(Token = "0x4009A95")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI MaxStockCounter;
    [Token(Token = "0x4009A96")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image Icon1;
    [Token(Token = "0x4009A97")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image Icon2;
    [Token(Token = "0x4009A98")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image Icon3;
    [Token(Token = "0x4009A99")]
    [FieldOffset(Offset = "0x48")]
    private StockCounterData stockCounterData;
    [Token(Token = "0x4009A9A")]
    [FieldOffset(Offset = "0x50")]
    private int beforeStockCounter;
    [Token(Token = "0x4009A9B")]
    [FieldOffset(Offset = "0x54")]
    private int currentStockCounter;
    [Token(Token = "0x4009A9C")]
    [FieldOffset(Offset = "0x58")]
    private int currentSetIconId;
    [Token(Token = "0x4009A9D")]
    [FieldOffset(Offset = "0x5C")]
    private bool isInit;
    [Token(Token = "0x4009A9E")]
    [FieldOffset(Offset = "0x60")]
    public string UporDownAnimationName;

    [Token(Token = "0x600DD53")]
    [Address(RVA = "0x1E27BC0", Offset = "0x1E27BC0", VA = "0x1E27BC0")]
    public void Show(
      StockCounterData stockCounterData,
      int currentStockCounter,
      bool isAnimationDelay)
    {
    }

    [Token(Token = "0x600DD54")]
    [Address(RVA = "0x1E27E24", Offset = "0x1E27E24", VA = "0x1E27E24")]
    private IEnumerator ShowInternal(bool isAnimationDelay) => (IEnumerator) null;

    [Token(Token = "0x600DD55")]
    [Address(RVA = "0x1E27EC8", Offset = "0x1E27EC8", VA = "0x1E27EC8")]
    private IEnumerator DoAnimation(string UporDownAnimationName) => (IEnumerator) null;

    [Token(Token = "0x600DD56")]
    [Address(RVA = "0x1E27DB4", Offset = "0x1E27DB4", VA = "0x1E27DB4")]
    public IEnumerator DoAnimationDelay() => (IEnumerator) null;

    [Token(Token = "0x600DD57")]
    [Address(RVA = "0x1E27F8C", Offset = "0x1E27F8C", VA = "0x1E27F8C")]
    public void StockCounterNumEvent()
    {
    }

    [Token(Token = "0x600DD58")]
    [Address(RVA = "0x1E28084", Offset = "0x1E28084", VA = "0x1E28084")]
    public FieldUnitListViewElementStockCounter()
    {
    }
  }
}
