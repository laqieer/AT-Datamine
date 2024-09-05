// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Top.GuildRaidButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Top
{
  [Token(Token = "0x2002B8E")]
  internal class GuildRaidButton : MonoBehaviour
  {
    [Token(Token = "0x400B97C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400B97D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image buttonImage;
    [Token(Token = "0x400B97E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject beforeObj;
    [Token(Token = "0x400B97F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI beforeDate;
    [Token(Token = "0x400B980")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject afterObj;
    [Token(Token = "0x400B981")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject openObj;
    [Token(Token = "0x400B982")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI openDate;
    [Token(Token = "0x400B983")]
    [FieldOffset(Offset = "0x0")]
    private static string dateTimeFormat;
    [Token(Token = "0x400B984")]
    [FieldOffset(Offset = "0x50")]
    private int raidId;

    [Token(Token = "0x6011047")]
    [Address(RVA = "0x1C76630", Offset = "0x1C76630", VA = "0x1C76630")]
    public void Set(Action<int> buttonAction, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6011048")]
    [Address(RVA = "0x1C76A1C", Offset = "0x1C76A1C", VA = "0x1C76A1C")]
    private IEnumerator LoadOpenImage(AssetCachedSpawner assetCachedSpawner) => (IEnumerator) null;

    [Token(Token = "0x6011049")]
    [Address(RVA = "0x1C76AB8", Offset = "0x1C76AB8", VA = "0x1C76AB8")]
    public GuildRaidButton()
    {
    }

    [Token(Token = "0x601104A")]
    [Address(RVA = "0x1C76AC0", Offset = "0x1C76AC0", VA = "0x1C76AC0")]
    static GuildRaidButton()
    {
    }
  }
}
