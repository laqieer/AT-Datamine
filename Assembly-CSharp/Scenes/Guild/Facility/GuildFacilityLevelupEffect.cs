// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Facility.GuildFacilityLevelupEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Guild.Data;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Facility
{
  [Token(Token = "0x2002BFC")]
  public class GuildFacilityLevelupEffect : MonoBehaviour
  {
    [Token(Token = "0x400BB3E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject prosperityStatueStatus;
    [Token(Token = "0x400BB3F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject valorStatueStatus;
    [Token(Token = "0x400BB40")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject enduranceStatueStatus;
    [Token(Token = "0x400BB41")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject celerityStatueStatus;
    [Token(Token = "0x400BB42")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GuildFacilityStoneStatue prosperityStatue;
    [Token(Token = "0x400BB43")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GuildFacilityStoneStatue valorStatue;
    [Token(Token = "0x400BB44")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GuildFacilityStoneStatue enduranceStatue;
    [Token(Token = "0x400BB45")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GuildFacilityStoneStatue celerityStatue;
    [Token(Token = "0x400BB46")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<Statue.ID, Statue> dicIdStatue;
    [Token(Token = "0x400BB47")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI fromLevel;
    [Token(Token = "0x400BB48")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text toLevel;
    [Token(Token = "0x400BB49")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UITimelineController uITimelineController;
    [Token(Token = "0x400BB4A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CanvasGroup canvasGroup;

    [Token(Token = "0x60112DF")]
    [Address(RVA = "0x4A11DC4", Offset = "0x4A11DC4", VA = "0x4A11DC4")]
    public IEnumerator Initialize(GuildFacilityDetailInfo info, int fromLevel, int toLevel)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60112E0")]
    [Address(RVA = "0x4A131C8", Offset = "0x4A131C8", VA = "0x4A131C8")]
    public void Open()
    {
    }

    [Token(Token = "0x60112E1")]
    [Address(RVA = "0x4A132A8", Offset = "0x4A132A8", VA = "0x4A132A8")]
    public void Close()
    {
    }

    [Token(Token = "0x60112E2")]
    [Address(RVA = "0x4A13288", Offset = "0x4A13288", VA = "0x4A13288")]
    public void SetActiveInteractableContentCanvas(bool flag)
    {
    }

    [Token(Token = "0x60112E3")]
    [Address(RVA = "0x4A1334C", Offset = "0x4A1334C", VA = "0x4A1334C")]
    public void SetupFacilityList(GuildFacilityDetailInfo info)
    {
    }

    [Token(Token = "0x60112E4")]
    [Address(RVA = "0x4A1364C", Offset = "0x4A1364C", VA = "0x4A1364C")]
    public GuildFacilityLevelupEffect()
    {
    }
  }
}
