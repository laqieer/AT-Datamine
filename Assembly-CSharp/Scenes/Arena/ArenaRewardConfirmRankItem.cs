// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaRewardConfirmRankItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003114")]
  public class ArenaRewardConfirmRankItem : MonoBehaviour
  {
    [Token(Token = "0x400D0EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text rankTitle;
    [Token(Token = "0x400D0EF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ItemIcon itemIconPrefab;

    [Token(Token = "0x60132A7")]
    [Address(RVA = "0x45E02F8", Offset = "0x45E02F8", VA = "0x45E02F8")]
    public void Initialize(
      ArenaLoader loader,
      int min,
      int max,
      (ItemUtility.Parameter param, int quantity)[] rewards)
    {
    }

    [Token(Token = "0x60132A8")]
    [Address(RVA = "0x45E1D20", Offset = "0x45E1D20", VA = "0x45E1D20")]
    private void CreateRewards(
      (ItemUtility.Parameter param, int quantity)[] rewards)
    {
    }

    [Token(Token = "0x60132A9")]
    [Address(RVA = "0x45E1EF0", Offset = "0x45E1EF0", VA = "0x45E1EF0")]
    public ArenaRewardConfirmRankItem()
    {
    }
  }
}
