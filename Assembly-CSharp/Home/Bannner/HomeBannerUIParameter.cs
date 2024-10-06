// Decompiled with JetBrains decompiler
// Type: Home.Bannner.HomeBannerUIParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.RawData;
using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace Home.Bannner
{
  [Token(Token = "0x2000B8A")]
  internal class HomeBannerUIParameter
  {
    [Token(Token = "0x4003493")]
    [FieldOffset(Offset = "0x40")]
    public RawTextureHandle BannerTextureHandle;

    [Token(Token = "0x1700098A")]
    public BannerContentTypeEnum homeBannerType
    {
      [Token(Token = "0x60041BD"), Address(RVA = "0x2A31E80", Offset = "0x2A31E80", VA = "0x2A31E80")] get
      {
        return new BannerContentTypeEnum();
      }
      [Token(Token = "0x60041BE"), Address(RVA = "0x2A31E88", Offset = "0x2A31E88", VA = "0x2A31E88")] private set
      {
      }
    }

    [Token(Token = "0x1700098B")]
    public string ResourceName
    {
      [Token(Token = "0x60041BF"), Address(RVA = "0x2A31E90", Offset = "0x2A31E90", VA = "0x2A31E90")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60041C0"), Address(RVA = "0x2A31E98", Offset = "0x2A31E98", VA = "0x2A31E98")] private set
      {
      }
    }

    [Token(Token = "0x1700098C")]
    public int ShowPriority
    {
      [Token(Token = "0x60041C1"), Address(RVA = "0x2A31EA0", Offset = "0x2A31EA0", VA = "0x2A31EA0")] get
      {
        return new int();
      }
      [Token(Token = "0x60041C2"), Address(RVA = "0x2A31EA8", Offset = "0x2A31EA8", VA = "0x2A31EA8")] private set
      {
      }
    }

    [Token(Token = "0x1700098D")]
    public int RelationId
    {
      [Token(Token = "0x60041C3"), Address(RVA = "0x2A31EB0", Offset = "0x2A31EB0", VA = "0x2A31EB0")] get
      {
        return new int();
      }
      [Token(Token = "0x60041C4"), Address(RVA = "0x2A31EB8", Offset = "0x2A31EB8", VA = "0x2A31EB8")] private set
      {
      }
    }

    [Token(Token = "0x1700098E")]
    public string Url
    {
      [Token(Token = "0x60041C5"), Address(RVA = "0x2A31EC0", Offset = "0x2A31EC0", VA = "0x2A31EC0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60041C6"), Address(RVA = "0x2A31EC8", Offset = "0x2A31EC8", VA = "0x2A31EC8")] private set
      {
      }
    }

    [Token(Token = "0x1700098F")]
    public DateTime StartAt
    {
      [Token(Token = "0x60041C7"), Address(RVA = "0x2A31ED0", Offset = "0x2A31ED0", VA = "0x2A31ED0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x60041C8"), Address(RVA = "0x2A31ED8", Offset = "0x2A31ED8", VA = "0x2A31ED8")] private set
      {
      }
    }

    [Token(Token = "0x17000990")]
    public DateTime EndAt
    {
      [Token(Token = "0x60041C9"), Address(RVA = "0x2A31EE0", Offset = "0x2A31EE0", VA = "0x2A31EE0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x60041CA"), Address(RVA = "0x2A31EE8", Offset = "0x2A31EE8", VA = "0x2A31EE8")] private set
      {
      }
    }

    [Token(Token = "0x17000991")]
    public bool HasSchedule
    {
      [Token(Token = "0x60041CB"), Address(RVA = "0x2A31EF0", Offset = "0x2A31EF0", VA = "0x2A31EF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60041CC")]
    [Address(RVA = "0x2A2EF80", Offset = "0x2A2EF80", VA = "0x2A2EF80")]
    public static HomeBannerUIParameter CreateByServerData(HomeBannerType serverData)
    {
      return (HomeBannerUIParameter) null;
    }

    [Token(Token = "0x60041CD")]
    [Address(RVA = "0x2A30334", Offset = "0x2A30334", VA = "0x2A30334")]
    public void Release()
    {
    }

    [Token(Token = "0x60041CE")]
    [Address(RVA = "0x2A31F90", Offset = "0x2A31F90", VA = "0x2A31F90")]
    public string GetScheduleText() => (string) null;

    [Token(Token = "0x60041CF")]
    [Address(RVA = "0x2A31F88", Offset = "0x2A31F88", VA = "0x2A31F88")]
    public HomeBannerUIParameter()
    {
    }
  }
}
