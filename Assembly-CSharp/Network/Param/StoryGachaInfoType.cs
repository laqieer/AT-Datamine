// Decompiled with JetBrains decompiler
// Type: Network.Param.StoryGachaInfoType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B12")]
  [Serializable]
  public class StoryGachaInfoType
  {
    [Token(Token = "0x4007442")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int number;
    [Token(Token = "0x4007443")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int group_id;
    [Token(Token = "0x4007444")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string title;
    [Token(Token = "0x4007445")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool is_released;
    [Token(Token = "0x4007446")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int release_sequence_id;
    [Token(Token = "0x4007447")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string release_message_text;
    [Token(Token = "0x4007448")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int notice_status;

    [Token(Token = "0x17001CA4")]
    public int Number
    {
      [Token(Token = "0x6009EC5"), Address(RVA = "0x48F370C", Offset = "0x48F370C", VA = "0x48F370C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EC6"), Address(RVA = "0x48F3714", Offset = "0x48F3714", VA = "0x48F3714")] set
      {
      }
    }

    [Token(Token = "0x17001CA5")]
    public int GroupId
    {
      [Token(Token = "0x6009EC7"), Address(RVA = "0x48F371C", Offset = "0x48F371C", VA = "0x48F371C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EC8"), Address(RVA = "0x48F3724", Offset = "0x48F3724", VA = "0x48F3724")] set
      {
      }
    }

    [Token(Token = "0x17001CA6")]
    public string Title
    {
      [Token(Token = "0x6009EC9"), Address(RVA = "0x48F372C", Offset = "0x48F372C", VA = "0x48F372C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009ECA"), Address(RVA = "0x48F3734", Offset = "0x48F3734", VA = "0x48F3734")] set
      {
      }
    }

    [Token(Token = "0x17001CA7")]
    public bool IsReleased
    {
      [Token(Token = "0x6009ECB"), Address(RVA = "0x48F373C", Offset = "0x48F373C", VA = "0x48F373C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009ECC"), Address(RVA = "0x48F3744", Offset = "0x48F3744", VA = "0x48F3744")] set
      {
      }
    }

    [Token(Token = "0x17001CA8")]
    public int ReleaseSequenceId
    {
      [Token(Token = "0x6009ECD"), Address(RVA = "0x48F3750", Offset = "0x48F3750", VA = "0x48F3750")] get
      {
        return new int();
      }
      [Token(Token = "0x6009ECE"), Address(RVA = "0x48F3758", Offset = "0x48F3758", VA = "0x48F3758")] set
      {
      }
    }

    [Token(Token = "0x17001CA9")]
    public string ReleaseMessageText
    {
      [Token(Token = "0x6009ECF"), Address(RVA = "0x48F3760", Offset = "0x48F3760", VA = "0x48F3760")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009ED0"), Address(RVA = "0x48F3768", Offset = "0x48F3768", VA = "0x48F3768")] set
      {
      }
    }

    [Token(Token = "0x17001CAA")]
    public int NoticeStatus
    {
      [Token(Token = "0x6009ED1"), Address(RVA = "0x48F3770", Offset = "0x48F3770", VA = "0x48F3770")] get
      {
        return new int();
      }
      [Token(Token = "0x6009ED2"), Address(RVA = "0x48F3778", Offset = "0x48F3778", VA = "0x48F3778")] set
      {
      }
    }

    [Token(Token = "0x6009ED3")]
    [Address(RVA = "0x48F3780", Offset = "0x48F3780", VA = "0x48F3780")]
    public StoryGachaInfoType()
    {
    }
  }
}
