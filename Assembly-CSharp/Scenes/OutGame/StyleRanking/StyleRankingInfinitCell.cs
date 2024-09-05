// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.StyleRankingInfinitCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.StyleRanking
{
  [Token(Token = "0x2003365")]
  internal class StyleRankingInfinitCell : InfiniteCellBase
  {
    [Token(Token = "0x400DEB0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleRankingThumb thumb;

    [Token(Token = "0x1700437C")]
    private StyleRankingCellResource Resource
    {
      [Token(Token = "0x6014321"), Address(RVA = "0x1E16D08", Offset = "0x1E16D08", VA = "0x1E16D08")] get
      {
        return (StyleRankingCellResource) null;
      }
    }

    [Token(Token = "0x6014322")]
    [Address(RVA = "0x1E16D90", Offset = "0x1E16D90", VA = "0x1E16D90", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6014323")]
    [Address(RVA = "0x1E1743C", Offset = "0x1E1743C", VA = "0x1E1743C")]
    public StyleRankingInfinitCell()
    {
    }
  }
}
