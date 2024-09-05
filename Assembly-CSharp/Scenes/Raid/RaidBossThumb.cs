// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.RaidBossThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029D2")]
  internal class RaidBossThumb : MonoBehaviour
  {
    [Token(Token = "0x400B23E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400B23F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image bossImage;
    [Token(Token = "0x400B240")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject hpObj;
    [Token(Token = "0x400B241")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Slider hpGauge;
    [Token(Token = "0x400B242")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI hpPercent;
    [Token(Token = "0x400B243")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI stageText;
    [Token(Token = "0x400B244")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400B245")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject surviveEffect;
    [Token(Token = "0x400B246")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject dyingEffect;
    [Token(Token = "0x400B247")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject surviveIcon;
    [Token(Token = "0x400B248")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject dyingIcon;
    [Token(Token = "0x400B249")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TrialMemberView trialMember;
    [Token(Token = "0x400B24A")]
    [FieldOffset(Offset = "0x78")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400B24B")]
    [FieldOffset(Offset = "0x80")]
    private Action<int, bool> onClickThumb;
    [Token(Token = "0x400B24C")]
    [FieldOffset(Offset = "0x88")]
    private int position;
    [Token(Token = "0x400B24D")]
    [FieldOffset(Offset = "0x8C")]
    private bool isAlive;

    [Token(Token = "0x60106A7")]
    [Address(RVA = "0x488B2D0", Offset = "0x488B2D0", VA = "0x488B2D0")]
    public void Initialize(Action<int, bool> onClickThumb, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60106A8")]
    [Address(RVA = "0x488B390", Offset = "0x488B390", VA = "0x488B390")]
    public void UpdateThumb(
      int lap,
      GuildRaidPositionType info,
      List<GuildMemberType> members,
      bool isHeld)
    {
    }

    [Token(Token = "0x60106A9")]
    [Address(RVA = "0x488B778", Offset = "0x488B778", VA = "0x488B778")]
    private void LoadBossImage(int styleId)
    {
    }

    [Token(Token = "0x60106AA")]
    [Address(RVA = "0x488B850", Offset = "0x488B850", VA = "0x488B850")]
    private void OnClickThumb()
    {
    }

    [Token(Token = "0x60106AB")]
    [Address(RVA = "0x488B87C", Offset = "0x488B87C", VA = "0x488B87C")]
    public RaidBossThumb()
    {
    }
  }
}
