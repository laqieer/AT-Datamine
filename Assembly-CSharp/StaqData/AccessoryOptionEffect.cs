// Decompiled with JetBrains decompiler
// Type: StaqData.AccessoryOptionEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using staq.SaveSchema;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200201A")]
  public class AccessoryOptionEffect : IOptionEffect
  {
    [Token(Token = "0x170027D9")]
    public int Slot
    {
      [Token(Token = "0x600BF7C"), Address(RVA = "0x20083EC", Offset = "0x20083EC", VA = "0x20083EC")] get
      {
        return new int();
      }
      [Token(Token = "0x600BF7D"), Address(RVA = "0x20083F4", Offset = "0x20083F4", VA = "0x20083F4")] private set
      {
      }
    }

    [Token(Token = "0x170027DA")]
    public int EffectId
    {
      [Token(Token = "0x600BF7E"), Address(RVA = "0x20083FC", Offset = "0x20083FC", VA = "0x20083FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600BF7F"), Address(RVA = "0x2008404", Offset = "0x2008404", VA = "0x2008404")] private set
      {
      }
    }

    [Token(Token = "0x170027DB")]
    public float EffectValue
    {
      [Token(Token = "0x600BF80"), Address(RVA = "0x200840C", Offset = "0x200840C", VA = "0x200840C", Slot = "5")] get
      {
        return new float();
      }
      [Token(Token = "0x600BF81"), Address(RVA = "0x2008414", Offset = "0x2008414", VA = "0x2008414")] private set
      {
      }
    }

    [Token(Token = "0x170027DC")]
    public AccessoryOptionData MasterData
    {
      [Token(Token = "0x600BF82"), Address(RVA = "0x200841C", Offset = "0x200841C", VA = "0x200841C")] get
      {
        return (AccessoryOptionData) null;
      }
      [Token(Token = "0x600BF83"), Address(RVA = "0x2008424", Offset = "0x2008424", VA = "0x2008424")] private set
      {
      }
    }

    [Token(Token = "0x170027DD")]
    public string Name
    {
      [Token(Token = "0x600BF84"), Address(RVA = "0x200842C", Offset = "0x200842C", VA = "0x200842C", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170027DE")]
    public int Grade
    {
      [Token(Token = "0x600BF85"), Address(RVA = "0x2008448", Offset = "0x2008448", VA = "0x2008448", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027DF")]
    public int IconSpriteId
    {
      [Token(Token = "0x600BF86"), Address(RVA = "0x2008464", Offset = "0x2008464", VA = "0x2008464", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027E0")]
    public bool IsUnLocked
    {
      [Token(Token = "0x600BF87"), Address(RVA = "0x20084EC", Offset = "0x20084EC", VA = "0x20084EC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BF88")]
    [Address(RVA = "0x2008048", Offset = "0x2008048", VA = "0x2008048")]
    public AccessoryOptionEffect(PlayerGearOptionType entity)
    {
    }

    [Token(Token = "0x600BF89")]
    [Address(RVA = "0x2008510", Offset = "0x2008510", VA = "0x2008510")]
    public AccessoryOptionEffect(EquipmentOption schema)
    {
    }

    [Token(Token = "0x600BF8A")]
    [Address(RVA = "0x20085FC", Offset = "0x20085FC", VA = "0x20085FC")]
    public string ToJson() => (string) null;
  }
}
