// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitEquipmentSetRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EBB")]
  [Serializable]
  public class APIUnitEquipmentSetRequest
  {
    [Token(Token = "0x4008406")]
    [FieldOffset(Offset = "0x10")]
    public PlayerUnitEditEquipmentSetType player_unit_equipment_set;

    [Token(Token = "0x600B681")]
    [Address(RVA = "0x22ECD54", Offset = "0x22ECD54", VA = "0x22ECD54")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B682")]
    [Address(RVA = "0x22ECD9C", Offset = "0x22ECD9C", VA = "0x22ECD9C")]
    public APIUnitEquipmentSetRequest()
    {
    }
  }
}
