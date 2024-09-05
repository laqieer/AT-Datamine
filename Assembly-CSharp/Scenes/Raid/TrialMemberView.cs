// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.TrialMemberView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029EB")]
  internal class TrialMemberView : MonoBehaviour
  {
    [Token(Token = "0x400B2B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TrialMemberContent[] memberContents;
    [Token(Token = "0x400B2B5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI moreMemberText;

    [Token(Token = "0x6010736")]
    [Address(RVA = "0x4887C54", Offset = "0x4887C54", VA = "0x4887C54")]
    public void SetTrialMember(
      List<string> playerIds,
      List<GuildMemberType> members,
      AssetCachedSpawner assetCachedSpawner,
      bool withName,
      bool isHeld)
    {
    }

    [Token(Token = "0x6010737")]
    [Address(RVA = "0x48905B4", Offset = "0x48905B4", VA = "0x48905B4")]
    public TrialMemberView()
    {
    }
  }
}
