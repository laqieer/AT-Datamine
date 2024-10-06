// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.PartyCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AEE")]
  public class PartyCell : MonoBehaviour
  {
    [Token(Token = "0x401038A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UnitNodeDotCell[] unitNodeDotCells;

    [Token(Token = "0x60172F7")]
    [Address(RVA = "0x30131A4", Offset = "0x30131A4", VA = "0x30131A4")]
    public void InitPartyCell(int cellIndex, int styleid, bool dotInitSkip)
    {
    }

    [Token(Token = "0x60172F8")]
    [Address(RVA = "0x3013404", Offset = "0x3013404", VA = "0x3013404")]
    public void SetAttentionIcon(int cellIndex, bool isAttention)
    {
    }

    [Token(Token = "0x60172F9")]
    [Address(RVA = "0x30134E0", Offset = "0x30134E0", VA = "0x30134E0")]
    public PartyCell()
    {
    }
  }
}
