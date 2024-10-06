// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitReincarnationRestoreRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001ECF")]
  [Serializable]
  public class APIUnitReincarnationRestoreRequest
  {
    [Token(Token = "0x4008456")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;

    [Token(Token = "0x600B6FF")]
    [Address(RVA = "0x212F394", Offset = "0x212F394", VA = "0x212F394")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B700")]
    [Address(RVA = "0x212F3DC", Offset = "0x212F3DC", VA = "0x212F3DC")]
    public APIUnitReincarnationRestoreRequest()
    {
    }
  }
}
