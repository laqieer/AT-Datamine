// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GlobalMenuOptionDownload
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame;
using Scenes.Title;
using System.Collections;
using UnityEngine;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B9C")]
  public class GlobalMenuOptionDownload : MonoBehaviour
  {
    [Token(Token = "0x40034EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BattleConfigItem downloadLightMode;
    [Token(Token = "0x40034EB")]
    [FieldOffset(Offset = "0x20")]
    private TitleMenuCacheClearPopup cacheClearPopup;

    [Token(Token = "0x6004247")]
    [Address(RVA = "0x2A34B60", Offset = "0x2A34B60", VA = "0x2A34B60")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6004248")]
    [Address(RVA = "0x2A35550", Offset = "0x2A35550", VA = "0x2A35550")]
    public void OnValueChangedLightMode(bool isOn)
    {
    }

    [Token(Token = "0x6004249")]
    [Address(RVA = "0x2A35620", Offset = "0x2A35620", VA = "0x2A35620")]
    public void OnDeleteCacheButton()
    {
    }

    [Token(Token = "0x600424A")]
    [Address(RVA = "0x2A35640", Offset = "0x2A35640", VA = "0x2A35640")]
    private IEnumerator OpenCacheClearPopup() => (IEnumerator) null;

    [Token(Token = "0x600424B")]
    [Address(RVA = "0x2A356D0", Offset = "0x2A356D0", VA = "0x2A356D0")]
    public GlobalMenuOptionDownload()
    {
    }
  }
}
