// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.RaidTopView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.API;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029E4")]
  internal class RaidTopView : MonoBehaviour
  {
    [Token(Token = "0x400B295")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI lapText;
    [Token(Token = "0x400B296")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI periodText;
    [Token(Token = "0x400B297")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RaidBossThumb[] raidBossThumb;

    [Token(Token = "0x601071D")]
    [Address(RVA = "0x488C750", Offset = "0x488C750", VA = "0x488C750")]
    public void Initialize(
      int raidId,
      Action<int, bool> onClickBossThumb,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601071E")]
    [Address(RVA = "0x488F334", Offset = "0x488F334", VA = "0x488F334")]
    public void UpdateTopView(APIGuildRaidTopResponse response, bool isHeld)
    {
    }

    [Token(Token = "0x601071F")]
    [Address(RVA = "0x488FB60", Offset = "0x488FB60", VA = "0x488FB60")]
    public RaidTopView()
    {
    }
  }
}
