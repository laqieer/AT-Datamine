// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.TrialMemberContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029EA")]
  internal class TrialMemberContent : MonoBehaviour
  {
    [Token(Token = "0x400B2B2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StyleThumb memberThumb;
    [Token(Token = "0x400B2B3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI memberName;

    [Token(Token = "0x6010734")]
    [Address(RVA = "0x48904CC", Offset = "0x48904CC", VA = "0x48904CC")]
    public void SetTrialMember(
      GuildMemberType member,
      AssetCachedSpawner assetCachedSpawner,
      bool withName)
    {
    }

    [Token(Token = "0x6010735")]
    [Address(RVA = "0x48905A4", Offset = "0x48905A4", VA = "0x48905A4")]
    public TrialMemberContent()
    {
    }
  }
}
