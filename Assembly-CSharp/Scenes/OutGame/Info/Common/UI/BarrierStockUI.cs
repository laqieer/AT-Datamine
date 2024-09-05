// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.BarrierStockUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035E6")]
  public class BarrierStockUI : MonoBehaviour
  {
    [Token(Token = "0x400EA7B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Tooltip("バリアの数")]
    private TextAccessor count;
    [Token(Token = "0x400EA7C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject goBarrierCount;
    [Token(Token = "0x400EA7D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextContainer barrierIndexNumber;
    [Token(Token = "0x400EA7E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ActiveObjectContainers currentHpActiveObjects;
    [Token(Token = "0x400EA7F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ActiveObjectContainers maxHpActiveObjects;
    [Token(Token = "0x400EA80")]
    [FieldOffset(Offset = "0x40")]
    private Toggle[] stocks;

    [Token(Token = "0x6015397")]
    [Address(RVA = "0x4D8C518", Offset = "0x4D8C518", VA = "0x4D8C518")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6015398")]
    [Address(RVA = "0x4D8C568", Offset = "0x4D8C568", VA = "0x4D8C568")]
    public void Set(int current, int max, string barrierIndex)
    {
    }

    [Token(Token = "0x6015399")]
    [Address(RVA = "0x4D8C680", Offset = "0x4D8C680", VA = "0x4D8C680")]
    public BarrierStockUI()
    {
    }
  }
}
