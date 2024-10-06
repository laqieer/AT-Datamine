// Decompiled with JetBrains decompiler
// Type: Battle.IDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Particle;
using Battle.Process;
using Battle.Staging;
using Battle.UI;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200226F")]
  public interface IDirector : IStepUpdate
  {
    [Token(Token = "0x600D179")]
    void Initialize(BattleCore battleCore, ISystemFlags systemFlags);

    [Token(Token = "0x600D17A")]
    void Release();

    [Token(Token = "0x600D17B")]
    IEnumerator LoadResource();

    [Token(Token = "0x600D17C")]
    IEnumerator LoadItemIcon();

    [Token(Token = "0x17002D74")]
    MapDirectorBase Map { [Token(Token = "0x600D17D")] get; }

    [Token(Token = "0x17002D75")]
    CameraDirector Camera { [Token(Token = "0x600D17E")] get; }

    [Token(Token = "0x17002D76")]
    AttentionDirector Attention { [Token(Token = "0x600D17F")] get; }

    [Token(Token = "0x17002D77")]
    FieldDamageDirector FieldDmg { [Token(Token = "0x600D180")] get; }

    [Token(Token = "0x17002D78")]
    StagingDirector Staging { [Token(Token = "0x600D181")] get; }

    [Token(Token = "0x17002D79")]
    StagingDirector Adv { [Token(Token = "0x600D182")] get; }

    [Token(Token = "0x17002D7A")]
    BattleVoiceDirector Voice { [Token(Token = "0x600D183")] get; }

    [Token(Token = "0x17002D7B")]
    UIManager UI { [Token(Token = "0x600D184")] get; }

    [Token(Token = "0x17002D7C")]
    ActorDirector Actor { [Token(Token = "0x600D185")] get; }

    [Token(Token = "0x17002D7D")]
    ParticleEmitter Particle { [Token(Token = "0x600D186")] get; }

    [Token(Token = "0x17002D7E")]
    SimpleDuelActionReciever SimpleDuel { [Token(Token = "0x600D187")] get; }

    [Token(Token = "0x17002D7F")]
    BattleConfigAsset Config { [Token(Token = "0x600D188")] get; }

    [Token(Token = "0x17002D80")]
    ISystemFlags SystemFlags { [Token(Token = "0x600D189")] get; }

    [Token(Token = "0x600D18A")]
    void OnUsersUnitLpDown();
  }
}
