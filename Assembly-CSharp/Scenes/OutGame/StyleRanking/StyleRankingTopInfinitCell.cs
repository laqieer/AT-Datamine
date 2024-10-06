// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.StyleRankingTopInfinitCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.StyleRanking
{
  [Token(Token = "0x200337A")]
  internal class StyleRankingTopInfinitCell : InfiniteCellBase
  {
    [Token(Token = "0x400DF2D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleRankingThumb thumb;

    [Token(Token = "0x1700438F")]
    private StyleRankingTopCellResource Resource
    {
      [Token(Token = "0x60143AB"), Address(RVA = "0x1E1B064", Offset = "0x1E1B064", VA = "0x1E1B064")] get
      {
        return (StyleRankingTopCellResource) null;
      }
    }

    [Token(Token = "0x60143AC")]
    [Address(RVA = "0x1E1B0EC", Offset = "0x1E1B0EC", VA = "0x1E1B0EC", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x60143AD")]
    [Address(RVA = "0x1E1B318", Offset = "0x1E1B318", VA = "0x1E1B318")]
    public StyleRankingTopInfinitCell()
    {
    }
  }
}
