// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApHeader.ApHeaderModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Scenes.OutGame.APRecovery.ApHeader
{
  [Token(Token = "0x200397A")]
  public class ApHeaderModel
  {
    [Token(Token = "0x400FB26")]
    [FieldOffset(Offset = "0x20")]
    private int _nowAp;
    [Token(Token = "0x400FB27")]
    [FieldOffset(Offset = "0x24")]
    private float _apRecoveryTime;

    [Token(Token = "0x601697B")]
    [Address(RVA = "0x42F2A00", Offset = "0x42F2A00", VA = "0x42F2A00")]
    public ApHeaderModel()
    {
    }

    [Token(Token = "0x17004A6A")]
    public int NowAp
    {
      [Token(Token = "0x601697C"), Address(RVA = "0x42F2A9C", Offset = "0x42F2A9C", VA = "0x42F2A9C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A6B")]
    public float RecoveryTimeSec
    {
      [Token(Token = "0x601697D"), Address(RVA = "0x42F2AA4", Offset = "0x42F2AA4", VA = "0x42F2AA4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17004A6C")]
    public bool IsApMax
    {
      [Token(Token = "0x601697E"), Address(RVA = "0x42F2AAC", Offset = "0x42F2AAC", VA = "0x42F2AAC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004A6D")]
    public float RecoveryFullTimeSec
    {
      [Token(Token = "0x601697F"), Address(RVA = "0x42F2B54", Offset = "0x42F2B54", VA = "0x42F2B54")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17004A6E")]
    public Action<int> OnUpdatedAp
    {
      [Token(Token = "0x6016980"), Address(RVA = "0x42F2BB0", Offset = "0x42F2BB0", VA = "0x42F2BB0")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6016981"), Address(RVA = "0x42F2BB8", Offset = "0x42F2BB8", VA = "0x42F2BB8")] set
      {
      }
    }

    [Token(Token = "0x17004A6F")]
    public Action<float> OnUpdatedRecoveryTimeSec
    {
      [Token(Token = "0x6016982"), Address(RVA = "0x42F2BC0", Offset = "0x42F2BC0", VA = "0x42F2BC0")] get
      {
        return (Action<float>) null;
      }
      [Token(Token = "0x6016983"), Address(RVA = "0x42F2BC8", Offset = "0x42F2BC8", VA = "0x42F2BC8")] set
      {
      }
    }

    [Token(Token = "0x6016984")]
    [Address(RVA = "0x42F2BD0", Offset = "0x42F2BD0", VA = "0x42F2BD0")]
    public void UpdateTime()
    {
    }

    [Token(Token = "0x6016985")]
    [Address(RVA = "0x42F2C98", Offset = "0x42F2C98", VA = "0x42F2C98")]
    public void ApplyCurrentAp()
    {
    }

    [Token(Token = "0x6016986")]
    [Address(RVA = "0x42F2C58", Offset = "0x42F2C58", VA = "0x42F2C58")]
    private void SetAp(int ap)
    {
    }

    [Token(Token = "0x6016987")]
    [Address(RVA = "0x42F2C78", Offset = "0x42F2C78", VA = "0x42F2C78")]
    private void SetRecoveryTime(float time)
    {
    }

    [Token(Token = "0x17004A70")]
    private static Player Player
    {
      [Token(Token = "0x6016988"), Address(RVA = "0x42F2A44", Offset = "0x42F2A44", VA = "0x42F2A44")] get
      {
        return (Player) null;
      }
    }

    [Token(Token = "0x17004A71")]
    private static PlayerConstData PlayerConst
    {
      [Token(Token = "0x6016989"), Address(RVA = "0x42F2AD4", Offset = "0x42F2AD4", VA = "0x42F2AD4")] get
      {
        return (PlayerConstData) null;
      }
    }
  }
}
