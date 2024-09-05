// Decompiled with JetBrains decompiler
// Type: StaqData.GachaListItemInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha.API;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002139")]
  public class GachaListItemInfo : IGachaModuleInfo
  {
    [Token(Token = "0x17002C6D")]
    public string GachaName
    {
      [Token(Token = "0x600CB6D"), Address(RVA = "0x1BA98C8", Offset = "0x1BA98C8", VA = "0x1BA98C8", Slot = "4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB6E"), Address(RVA = "0x1BA98D0", Offset = "0x1BA98D0", VA = "0x1BA98D0")] private set
      {
      }
    }

    [Token(Token = "0x17002C6E")]
    public string Title
    {
      [Token(Token = "0x600CB6F"), Address(RVA = "0x1BA98D8", Offset = "0x1BA98D8", VA = "0x1BA98D8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB70"), Address(RVA = "0x1BA98E0", Offset = "0x1BA98E0", VA = "0x1BA98E0")] private set
      {
      }
    }

    [Token(Token = "0x17002C6F")]
    public bool IsBadgeEnable
    {
      [Token(Token = "0x600CB71"), Address(RVA = "0x1BA98E8", Offset = "0x1BA98E8", VA = "0x1BA98E8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CB72"), Address(RVA = "0x1BA98F0", Offset = "0x1BA98F0", VA = "0x1BA98F0")] private set
      {
      }
    }

    [Token(Token = "0x17002C70")]
    public int Number
    {
      [Token(Token = "0x600CB73"), Address(RVA = "0x1BA98FC", Offset = "0x1BA98FC", VA = "0x1BA98FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB74"), Address(RVA = "0x1BA9904", Offset = "0x1BA9904", VA = "0x1BA9904")] private set
      {
      }
    }

    [Token(Token = "0x17002C71")]
    public List<GachaBackgroundResource> BackgroundResources
    {
      [Token(Token = "0x600CB75"), Address(RVA = "0x1BA990C", Offset = "0x1BA990C", VA = "0x1BA990C")] get
      {
        return (List<GachaBackgroundResource>) null;
      }
      [Token(Token = "0x600CB76"), Address(RVA = "0x1BA9914", Offset = "0x1BA9914", VA = "0x1BA9914")] private set
      {
      }
    }

    [Token(Token = "0x17002C72")]
    public string StartAt
    {
      [Token(Token = "0x600CB77"), Address(RVA = "0x1BA991C", Offset = "0x1BA991C", VA = "0x1BA991C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB78"), Address(RVA = "0x1BA9924", Offset = "0x1BA9924", VA = "0x1BA9924")] private set
      {
      }
    }

    [Token(Token = "0x17002C73")]
    public string EndAt
    {
      [Token(Token = "0x600CB79"), Address(RVA = "0x1BA992C", Offset = "0x1BA992C", VA = "0x1BA992C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB7A"), Address(RVA = "0x1BA9934", Offset = "0x1BA9934", VA = "0x1BA9934")] private set
      {
      }
    }

    [Token(Token = "0x17002C74")]
    public bool IsStoryGacha
    {
      [Token(Token = "0x600CB7B"), Address(RVA = "0x1BA993C", Offset = "0x1BA993C", VA = "0x1BA993C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C75")]
    public string ApiSchemaVersion
    {
      [Token(Token = "0x600CB7C"), Address(RVA = "0x1BA994C", Offset = "0x1BA994C", VA = "0x1BA994C", Slot = "5")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB7D"), Address(RVA = "0x1BA9954", Offset = "0x1BA9954", VA = "0x1BA9954")] private set
      {
      }
    }

    [Token(Token = "0x17002C76")]
    public ScheduleInfo ScheduleInfo
    {
      [Token(Token = "0x600CB7E"), Address(RVA = "0x1BA995C", Offset = "0x1BA995C", VA = "0x1BA995C")] get
      {
        return (ScheduleInfo) null;
      }
      [Token(Token = "0x600CB7F"), Address(RVA = "0x1BA9964", Offset = "0x1BA9964", VA = "0x1BA9964")] private set
      {
      }
    }

    [Token(Token = "0x17002C77")]
    public GachaTypeEnum GachaType
    {
      [Token(Token = "0x600CB80"), Address(RVA = "0x1BA996C", Offset = "0x1BA996C", VA = "0x1BA996C", Slot = "6")] get
      {
        return new GachaTypeEnum();
      }
      [Token(Token = "0x600CB81"), Address(RVA = "0x1BA9974", Offset = "0x1BA9974", VA = "0x1BA9974")] private set
      {
      }
    }

    [Token(Token = "0x600CB82")]
    [Address(RVA = "0x1BA940C", Offset = "0x1BA940C", VA = "0x1BA940C")]
    public static GachaListItemInfo CreateFromServerData(GachaModuleType serverData)
    {
      return (GachaListItemInfo) null;
    }

    [Token(Token = "0x600CB83")]
    [Address(RVA = "0x1BA9984", Offset = "0x1BA9984", VA = "0x1BA9984")]
    public bool IsOpenAt(DateTime now) => new bool();

    [Token(Token = "0x600CB84")]
    [Address(RVA = "0x1BA997C", Offset = "0x1BA997C", VA = "0x1BA997C")]
    public GachaListItemInfo()
    {
    }
  }
}
