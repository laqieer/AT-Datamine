// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI.BannerBG
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI
{
  [Token(Token = "0x2002DFC")]
  [Serializable]
  public class BannerBG
  {
    [Token(Token = "0x400C582")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("サブクエ")]
    private Sprite subquest;
    [Token(Token = "0x400C583")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("コミュ")]
    private Sprite communication;
    [Token(Token = "0x400C584")]
    [FieldOffset(Offset = "0x20")]
    [Header("施設")]
    [SerializeField]
    private Sprite facility;
    [Token(Token = "0x400C585")]
    [FieldOffset(Offset = "0x28")]
    [Header("オブリヴィエ")]
    [SerializeField]
    private Sprite obliviae;

    [Token(Token = "0x17003D47")]
    public Sprite Subquest
    {
      [Token(Token = "0x6011F96"), Address(RVA = "0x43774B4", Offset = "0x43774B4", VA = "0x43774B4")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17003D48")]
    public Sprite Communication
    {
      [Token(Token = "0x6011F97"), Address(RVA = "0x43774BC", Offset = "0x43774BC", VA = "0x43774BC")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17003D49")]
    public Sprite Facility
    {
      [Token(Token = "0x6011F98"), Address(RVA = "0x43774C4", Offset = "0x43774C4", VA = "0x43774C4")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17003D4A")]
    public Sprite Obliviae
    {
      [Token(Token = "0x6011F99"), Address(RVA = "0x43774CC", Offset = "0x43774CC", VA = "0x43774CC")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x6011F9A")]
    [Address(RVA = "0x43774D4", Offset = "0x43774D4", VA = "0x43774D4")]
    public BannerBG()
    {
    }
  }
}
