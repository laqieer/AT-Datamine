// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossListSideMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.BossList
{
  [Token(Token = "0x2002D25")]
  public class BossListSideMenu : MonoBehaviour
  {
    [Token(Token = "0x400C1A3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text level;
    [Token(Token = "0x400C1A4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text title;
    [Token(Token = "0x400C1A5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI proLevel;
    [Token(Token = "0x400C1A6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI proTitle;
    [Token(Token = "0x400C1A7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image bg;
    [Token(Token = "0x400C1A8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400C1A9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C1AA")]
    [FieldOffset(Offset = "0x50")]
    private int stageId;

    [Token(Token = "0x6011AA0")]
    [Address(RVA = "0x42ACA38", Offset = "0x42ACA38", VA = "0x42ACA38")]
    public void Initialize(
      int stageId,
      Action<int> buttonCallback,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6011AA1")]
    [Address(RVA = "0x42AD29C", Offset = "0x42AD29C", VA = "0x42AD29C")]
    public void PlayAnimSelected()
    {
    }

    [Token(Token = "0x6011AA2")]
    [Address(RVA = "0x42AD2F4", Offset = "0x42AD2F4", VA = "0x42AD2F4")]
    public void PlayAnimUnselected()
    {
    }

    [Token(Token = "0x6011AA3")]
    [Address(RVA = "0x42AD34C", Offset = "0x42AD34C", VA = "0x42AD34C")]
    public BossListSideMenu()
    {
    }
  }
}
