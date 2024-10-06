// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentEnhanceRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D57")]
  [Serializable]
  public class APIMind_equipmentEnhanceRequest
  {
    [Token(Token = "0x4007D56")]
    [FieldOffset(Offset = "0x10")]
    public string player_mind_equipment_id;
    [Token(Token = "0x4007D57")]
    [FieldOffset(Offset = "0x18")]
    public int soul_num;

    [Token(Token = "0x600AD15")]
    [Address(RVA = "0x1A48984", Offset = "0x1A48984", VA = "0x1A48984")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AD16")]
    [Address(RVA = "0x1A489CC", Offset = "0x1A489CC", VA = "0x1A489CC")]
    public APIMind_equipmentEnhanceRequest()
    {
    }
  }
}
