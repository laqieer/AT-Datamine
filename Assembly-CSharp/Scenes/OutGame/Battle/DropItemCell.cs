// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.DropItemCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x200373F")]
  public class DropItemCell : MonoBehaviour
  {
    [Token(Token = "0x400F146")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400F147")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F148")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string rewardInName;

    [Token(Token = "0x6015C2E")]
    [Address(RVA = "0x1B275E4", Offset = "0x1B275E4", VA = "0x1B275E4")]
    public void Initialize(ResultData.ItemData dropItem)
    {
    }

    [Token(Token = "0x6015C2F")]
    [Address(RVA = "0x1B2760C", Offset = "0x1B2760C", VA = "0x1B2760C")]
    public void Show()
    {
    }

    [Token(Token = "0x6015C30")]
    [Address(RVA = "0x1B27634", Offset = "0x1B27634", VA = "0x1B27634")]
    public DropItemCell()
    {
    }
  }
}
