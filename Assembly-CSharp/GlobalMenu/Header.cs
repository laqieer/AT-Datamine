// Decompiled with JetBrains decompiler
// Type: GlobalMenu.Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B95")]
  public class Header : MonoBehaviour
  {
    [Token(Token = "0x40034B6")]
    public const string CommonAssetBundleName = "2dassets_ui_common";
    [Token(Token = "0x40034B7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ApRecoveryHeader _apHeader;
    [Token(Token = "0x40034B8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text stoneValue;
    [Token(Token = "0x40034B9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button stonePlusButton;
    [Token(Token = "0x40034BA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text moneyValue;
    [Token(Token = "0x40034BC")]
    [FieldOffset(Offset = "0x40")]
    private AssetCachedSpawner useSpawner;

    [Token(Token = "0x1700099D")]
    public Action<string> callToasterAction
    {
      [Token(Token = "0x6004215"), Address(RVA = "0x2A32F60", Offset = "0x2A32F60", VA = "0x2A32F60")] get
      {
        return (Action<string>) null;
      }
      [Token(Token = "0x6004216"), Address(RVA = "0x2A32F68", Offset = "0x2A32F68", VA = "0x2A32F68")] set
      {
      }
    }

    [Token(Token = "0x6004217")]
    [Address(RVA = "0x2A32F70", Offset = "0x2A32F70", VA = "0x2A32F70")]
    private void Awake()
    {
    }

    [Token(Token = "0x6004218")]
    [Address(RVA = "0x2A3304C", Offset = "0x2A3304C", VA = "0x2A3304C")]
    public void SetVisible(bool isVisible)
    {
    }

    [Token(Token = "0x6004219")]
    [Address(RVA = "0x2A33074", Offset = "0x2A33074", VA = "0x2A33074")]
    public void UpdateData(AssetCachedSpawner spawner = null)
    {
    }

    [Token(Token = "0x600421A")]
    [Address(RVA = "0x2A332D8", Offset = "0x2A332D8", VA = "0x2A332D8")]
    private void UpdateCoinText()
    {
    }

    [Token(Token = "0x600421B")]
    [Address(RVA = "0x2A333A0", Offset = "0x2A333A0", VA = "0x2A333A0")]
    public void OnAPButton()
    {
    }

    [Token(Token = "0x600421C")]
    [Address(RVA = "0x2A331E0", Offset = "0x2A331E0", VA = "0x2A331E0")]
    private bool InitApHeader() => new bool();

    [Token(Token = "0x600421D")]
    [Address(RVA = "0x2A3342C", Offset = "0x2A3342C", VA = "0x2A3342C")]
    private void OnStonePlusButton()
    {
    }

    [Token(Token = "0x600421E")]
    [Address(RVA = "0x2A335BC", Offset = "0x2A335BC", VA = "0x2A335BC")]
    public Header()
    {
    }
  }
}
