// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.Stamp.ChatStampItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.ChatInfo;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat.Stamp
{
  [Token(Token = "0x20030BD")]
  public class ChatStampItem : MonoBehaviour
  {
    [Token(Token = "0x400CF52")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image stampIcon;
    [Token(Token = "0x400CF53")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text stampText;
    [Token(Token = "0x400CF54")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject sePlayMark;
    [Token(Token = "0x400CF55")]
    [FieldOffset(Offset = "0x30")]
    private int stampID;
    [Token(Token = "0x400CF56")]
    [FieldOffset(Offset = "0x38")]
    private Action<int> onClick;

    [Token(Token = "0x60130AA")]
    [Address(RVA = "0x432DCEC", Offset = "0x432DCEC", VA = "0x432DCEC")]
    private void Awake()
    {
    }

    [Token(Token = "0x60130AB")]
    [Address(RVA = "0x432DDD4", Offset = "0x432DDD4", VA = "0x432DDD4")]
    public void SetData(int stampid, Action<int> onclick)
    {
    }

    [Token(Token = "0x60130AC")]
    [Address(RVA = "0x432DEBC", Offset = "0x432DEBC", VA = "0x432DEBC")]
    public void SetSprite(ChatInfoLoader loader)
    {
    }

    [Token(Token = "0x60130AD")]
    [Address(RVA = "0x432DEC0", Offset = "0x432DEC0", VA = "0x432DEC0")]
    private void LoadSprites(ChatInfoLoader loader)
    {
    }

    [Token(Token = "0x60130AE")]
    [Address(RVA = "0x432DF54", Offset = "0x432DF54", VA = "0x432DF54")]
    public void ChangeState(bool state)
    {
    }

    [Token(Token = "0x60130AF")]
    [Address(RVA = "0x432DDE0", Offset = "0x432DDE0", VA = "0x432DDE0")]
    private void SetSEMark()
    {
    }

    [Token(Token = "0x60130B0")]
    [Address(RVA = "0x432DFDC", Offset = "0x432DFDC", VA = "0x432DFDC")]
    public ChatStampItem()
    {
    }
  }
}
