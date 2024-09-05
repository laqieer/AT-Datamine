// Decompiled with JetBrains decompiler
// Type: Battle.Data.IEffectParameterContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200272C")]
  public interface IEffectParameterContainer
  {
    [Token(Token = "0x170033F7")]
    System.Collections.Generic.List<EffectParameterData> List { [Token(Token = "0x600F3B5")] get; }

    [Token(Token = "0x170033F8")]
    int Count { [Token(Token = "0x600F3B6")] get; }

    [Token(Token = "0x170033F9")]
    bool Any { [Token(Token = "0x600F3B7")] get; }

    [Token(Token = "0x600F3B8")]
    void Add(EffectParameterData param);

    [Token(Token = "0x600F3B9")]
    void AddRange(IEnumerable<EffectParameterData> list);

    [Token(Token = "0x600F3BA")]
    void Remove(EffectParameterData param);

    [Token(Token = "0x600F3BB")]
    System.Collections.Generic.List<EffectParameterData> RemoveExpiredEffects();

    [Token(Token = "0x600F3BC")]
    void Clear();

    [Token(Token = "0x600F3BD")]
    System.Collections.Generic.List<EffectParameterData> GetDeactivateTriggeredEffects(
      EffectiveLengthTypeEnum length);
  }
}
