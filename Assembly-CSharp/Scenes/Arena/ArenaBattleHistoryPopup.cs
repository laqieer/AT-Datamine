// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaBattleHistoryPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003124")]
  public class ArenaBattleHistoryPopup : PopupBase
  {
    [Token(Token = "0x400D146")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Transform prefabRoot;
    [Token(Token = "0x400D147")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ArenaBattleHistoryListItem prefab;
    [Token(Token = "0x400D148")]
    [FieldOffset(Offset = "0x98")]
    private List<ArenaBattleHistoryType> arenaBattleHistories;
    [Token(Token = "0x400D149")]
    [FieldOffset(Offset = "0xA0")]
    private List<ArenaBattleHistoryListItem> itemList;
    [Token(Token = "0x400D14A")]
    [FieldOffset(Offset = "0xA8")]
    private ArenaLoader loader;

    [Token(Token = "0x60132E6")]
    [Address(RVA = "0x45E49A0", Offset = "0x45E49A0", VA = "0x45E49A0")]
    public IEnumerator InitializeWithOpen(ArenaTopSceneBase sceneBase) => (IEnumerator) null;

    [Token(Token = "0x60132E7")]
    [Address(RVA = "0x45E4A3C", Offset = "0x45E4A3C", VA = "0x45E4A3C", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x60132E8")]
    [Address(RVA = "0x45E4A44", Offset = "0x45E4A44", VA = "0x45E4A44", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60132E9")]
    [Address(RVA = "0x45E4A4C", Offset = "0x45E4A4C", VA = "0x45E4A4C")]
    private IEnumerator RequestArenaBattleHistory(long arenaId) => (IEnumerator) null;

    [Token(Token = "0x60132EA")]
    [Address(RVA = "0x45E4AE8", Offset = "0x45E4AE8", VA = "0x45E4AE8")]
    private void CreateList()
    {
    }

    [Token(Token = "0x60132EB")]
    [Address(RVA = "0x45E4D48", Offset = "0x45E4D48", VA = "0x45E4D48")]
    private void OnClickDetail(long battleId)
    {
    }

    [Token(Token = "0x60132EC")]
    [Address(RVA = "0x45E4EA4", Offset = "0x45E4EA4", VA = "0x45E4EA4")]
    public ArenaBattleHistoryPopup()
    {
    }
  }
}
