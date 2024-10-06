// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GlobalMenuOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B99")]
  public class GlobalMenuOption : MonoBehaviour
  {
    [Token(Token = "0x40034CF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GlobalMenuOptionBattleSettings battleSettings;
    [Token(Token = "0x40034D0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GlobalMenuOptionSoundGraphics soundGraphicSetting;
    [Token(Token = "0x40034D1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GlobalMenuOptionNotice noticeSetting;
    [Token(Token = "0x40034D2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GlobalMenuOptionDownload downloadSetting;
    [Token(Token = "0x40034D3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonToggle[] toggles;
    [Token(Token = "0x40034D4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<GameObject> objectsDisableIfPC;

    [Token(Token = "0x600422D")]
    [Address(RVA = "0x2A341F8", Offset = "0x2A341F8", VA = "0x2A341F8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600422E")]
    [Address(RVA = "0x2A342DC", Offset = "0x2A342DC", VA = "0x2A342DC")]
    private void DisableGameObjectsIfPC()
    {
    }

    [Token(Token = "0x600422F")]
    [Address(RVA = "0x2A34C68", Offset = "0x2A34C68", VA = "0x2A34C68")]
    public GlobalMenuOption()
    {
    }
  }
}
