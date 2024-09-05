// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CharacterVoiceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001393")]
  [Serializable]
  public sealed class CharacterVoiceMaster : BaseMaster<CharacterVoiceData>
  {
    [Token(Token = "0x6006E08")]
    [Address(RVA = "0x470189C", Offset = "0x470189C", VA = "0x470189C")]
    public IReadOnlyDictionary<int, CharacterVoiceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CharacterVoiceData>) null;
    }

    [Token(Token = "0x6006E09")]
    [Address(RVA = "0x47018A4", Offset = "0x47018A4", VA = "0x47018A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E0A")]
    [Address(RVA = "0x4701904", Offset = "0x4701904", VA = "0x4701904", Slot = "5")]
    protected override CharacterVoiceData LoadEntity(IMasterDataReader reader)
    {
      return (CharacterVoiceData) null;
    }

    [Token(Token = "0x6006E0B")]
    [Address(RVA = "0x470195C", Offset = "0x470195C", VA = "0x470195C")]
    public CharacterVoiceMaster()
    {
    }
  }
}
