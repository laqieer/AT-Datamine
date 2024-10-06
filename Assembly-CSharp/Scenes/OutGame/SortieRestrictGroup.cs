// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SortieRestrictGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003262")]
  internal class SortieRestrictGroup : MonoBehaviour
  {
    [Token(Token = "0x400D794")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject line;
    [Token(Token = "0x400D795")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RestrictContent restrictContent;

    [Token(Token = "0x6013A70")]
    [Address(RVA = "0x460C0A0", Offset = "0x460C0A0", VA = "0x460C0A0")]
    public bool SetSoriteRestrictInfo(QuestInfo questInfo) => new bool();

    [Token(Token = "0x6013A71")]
    [Address(RVA = "0x46219C8", Offset = "0x46219C8", VA = "0x46219C8")]
    private string GetSortieRestrictText(BattleForcedSortieData forcedSortieData) => (string) null;

    [Token(Token = "0x6013A72")]
    [Address(RVA = "0x4621BE8", Offset = "0x4621BE8", VA = "0x4621BE8")]
    public SortieRestrictGroup()
    {
    }
  }
}
