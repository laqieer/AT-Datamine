// Decompiled with JetBrains decompiler
// Type: StaqData.UnitSupportList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200210D")]
  public class UnitSupportList
  {
    [Token(Token = "0x4008C64")]
    [FieldOffset(Offset = "0x10")]
    private System.Collections.Generic.List<UnitSupportData> list;

    [Token(Token = "0x17002C08")]
    public IReadOnlyList<UnitSupportData> List
    {
      [Token(Token = "0x600CA27"), Address(RVA = "0x1BA0D58", Offset = "0x1BA0D58", VA = "0x1BA0D58")] get
      {
        return (IReadOnlyList<UnitSupportData>) null;
      }
    }

    [Token(Token = "0x600CA28")]
    [Address(RVA = "0x1BA0D60", Offset = "0x1BA0D60", VA = "0x1BA0D60")]
    public UnitSupportData GetSupportByCharaId(int charaId1, int charaId2)
    {
      return (UnitSupportData) null;
    }

    [Token(Token = "0x600CA29")]
    [Address(RVA = "0x1BA0E44", Offset = "0x1BA0E44", VA = "0x1BA0E44")]
    public void Apply(IReadOnlyList<PlayerUnitSupportType> list)
    {
    }

    [Token(Token = "0x600CA2A")]
    [Address(RVA = "0x1BA1224", Offset = "0x1BA1224", VA = "0x1BA1224")]
    public void Update(IReadOnlyList<PlayerUnitSupportType> list)
    {
    }

    [Token(Token = "0x600CA2B")]
    [Address(RVA = "0x1BA15FC", Offset = "0x1BA15FC", VA = "0x1BA15FC")]
    public UnitSupportList()
    {
    }
  }
}
