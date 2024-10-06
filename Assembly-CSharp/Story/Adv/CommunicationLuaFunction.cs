// Decompiled with JetBrains decompiler
// Type: Story.Adv.CommunicationLuaFunction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Story.Adv
{
  [Token(Token = "0x200074C")]
  public static class CommunicationLuaFunction
  {
    [Token(Token = "0x60028D6")]
    [Address(RVA = "0x3678F24", Offset = "0x3678F24", VA = "0x3678F24")]
    public static CommunicationLuaFunction.Object Create(int communicationID, int locationID)
    {
      return (CommunicationLuaFunction.Object) null;
    }

    [Token(Token = "0x200074D")]
    [MoonSharpUserData]
    public class Object
    {
      [Token(Token = "0x1700060B")]
      public int CommunicationID
      {
        [Token(Token = "0x60028D7"), Address(RVA = "0x3678F9C", Offset = "0x3678F9C", VA = "0x3678F9C")] private get
        {
          return new int();
        }
        [Token(Token = "0x60028D8"), Address(RVA = "0x3678FA4", Offset = "0x3678FA4", VA = "0x3678FA4")] set
        {
        }
      }

      [Token(Token = "0x1700060C")]
      public int LocationID
      {
        [Token(Token = "0x60028D9"), Address(RVA = "0x3678FAC", Offset = "0x3678FAC", VA = "0x3678FAC")] private get
        {
          return new int();
        }
        [Token(Token = "0x60028DA"), Address(RVA = "0x3678FB4", Offset = "0x3678FB4", VA = "0x3678FB4")] set
        {
        }
      }

      [Token(Token = "0x1700060D")]
      public bool IsRankup
      {
        [Token(Token = "0x60028DB"), Address(RVA = "0x3678FBC", Offset = "0x3678FBC", VA = "0x3678FBC")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x1700060E")]
      public bool HasCondition
      {
        [Token(Token = "0x60028DC"), Address(RVA = "0x3679048", Offset = "0x3679048", VA = "0x3679048")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x1700060F")]
      private Communication Commu
      {
        [Token(Token = "0x60028DD"), Address(RVA = "0x3678FD8", Offset = "0x3678FD8", VA = "0x3678FD8")] get
        {
          return (Communication) null;
        }
      }

      [Token(Token = "0x60028DE")]
      [Address(RVA = "0x367907C", Offset = "0x367907C", VA = "0x367907C")]
      public IEnumerable<CommunicationLuaFunction.Location> GetLocations()
      {
        return (IEnumerable<CommunicationLuaFunction.Location>) null;
      }

      [Token(Token = "0x60028DF")]
      [Address(RVA = "0x367949C", Offset = "0x367949C", VA = "0x367949C")]
      public CommunicationLuaFunction.Location GetLocation()
      {
        return (CommunicationLuaFunction.Location) null;
      }

      [Token(Token = "0x60028E0")]
      [Address(RVA = "0x3679814", Offset = "0x3679814", VA = "0x3679814")]
      public LuaSequence.ParamControl.ComuParam GetTrustParam()
      {
        return (LuaSequence.ParamControl.ComuParam) null;
      }

      [Token(Token = "0x60028E1")]
      [Address(RVA = "0x367987C", Offset = "0x367987C", VA = "0x367987C")]
      public CommunicationLuaFunction.CommunicationCharacter GetCharacter()
      {
        return (CommunicationLuaFunction.CommunicationCharacter) null;
      }

      [Token(Token = "0x60028E2")]
      [Address(RVA = "0x3679960", Offset = "0x3679960", VA = "0x3679960")]
      public string GetRankupConditionHintText() => (string) null;

      [Token(Token = "0x60028E3")]
      [Address(RVA = "0x3679974", Offset = "0x3679974", VA = "0x3679974")]
      public string GetRankupHintText() => (string) null;

      [Token(Token = "0x60028E4")]
      [Address(RVA = "0x3678F94", Offset = "0x3678F94", VA = "0x3678F94")]
      public Object()
      {
      }
    }

    [Token(Token = "0x200074E")]
    [MoonSharpUserData]
    public class CommunicationCharacter
    {
      [Token(Token = "0x17000610")]
      public int CharacterID
      {
        [Token(Token = "0x60028E5"), Address(RVA = "0x3679990", Offset = "0x3679990", VA = "0x3679990")] get
        {
          return new int();
        }
        [Token(Token = "0x60028E6"), Address(RVA = "0x3679998", Offset = "0x3679998", VA = "0x3679998")] set
        {
        }
      }

      [Token(Token = "0x17000611")]
      public int StyleID
      {
        [Token(Token = "0x60028E7"), Address(RVA = "0x36799A0", Offset = "0x36799A0", VA = "0x36799A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000612")]
      public string CharaName
      {
        [Token(Token = "0x60028E8"), Address(RVA = "0x3679A48", Offset = "0x3679A48", VA = "0x3679A48")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60028E9")]
      [Address(RVA = "0x3679958", Offset = "0x3679958", VA = "0x3679958")]
      public CommunicationCharacter()
      {
      }
    }

    [Token(Token = "0x200074F")]
    [MoonSharpUserData]
    public class Location
    {
      [Token(Token = "0x17000613")]
      public int ID
      {
        [Token(Token = "0x60028EA"), Address(RVA = "0x3679A54", Offset = "0x3679A54", VA = "0x3679A54")] get
        {
          return new int();
        }
        [Token(Token = "0x60028EB"), Address(RVA = "0x3679A5C", Offset = "0x3679A5C", VA = "0x3679A5C")] set
        {
        }
      }

      [Token(Token = "0x17000614")]
      public bool Enable
      {
        [Token(Token = "0x60028EC"), Address(RVA = "0x3679A64", Offset = "0x3679A64", VA = "0x3679A64")] get
        {
          return new bool();
        }
        [Token(Token = "0x60028ED"), Address(RVA = "0x3679A6C", Offset = "0x3679A6C", VA = "0x3679A6C")] set
        {
        }
      }

      [Token(Token = "0x17000615")]
      public bool IsFavorite
      {
        [Token(Token = "0x60028EE"), Address(RVA = "0x3679A78", Offset = "0x3679A78", VA = "0x3679A78")] get
        {
          return new bool();
        }
        [Token(Token = "0x60028EF"), Address(RVA = "0x3679A80", Offset = "0x3679A80", VA = "0x3679A80")] set
        {
        }
      }

      [Token(Token = "0x17000616")]
      public string Name
      {
        [Token(Token = "0x60028F0"), Address(RVA = "0x3679A8C", Offset = "0x3679A8C", VA = "0x3679A8C")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000617")]
      public int IntValue
      {
        [Token(Token = "0x60028F1"), Address(RVA = "0x3679B34", Offset = "0x3679B34", VA = "0x3679B34")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000618")]
      public string TextValue
      {
        [Token(Token = "0x60028F2"), Address(RVA = "0x3679B3C", Offset = "0x3679B3C", VA = "0x3679B3C")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60028F3")]
      [Address(RVA = "0x367948C", Offset = "0x367948C", VA = "0x367948C")]
      public Location()
      {
      }
    }
  }
}
