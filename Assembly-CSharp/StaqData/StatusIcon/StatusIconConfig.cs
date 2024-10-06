// Decompiled with JetBrains decompiler
// Type: StaqData.StatusIcon.StatusIconConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace StaqData.StatusIcon
{
  [Token(Token = "0x2002166")]
  [CreateAssetMenu(fileName = "StatusIconConfig", menuName = "ScriptableObjects/StatusIconConfig")]
  public sealed class StatusIconConfig : ScriptableObject
  {
    [Token(Token = "0x4008D72")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MainSkillIconSpriteSetter mainSkillIconSetter;
    [Token(Token = "0x4008D73")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SubSkillEffectIconSpriteSetter subSkillIconSetter;

    [Token(Token = "0x17002CE1")]
    public SpriteAtlas MainSkillIconAtlas
    {
      [Token(Token = "0x600CCB3"), Address(RVA = "0x1BB0FFC", Offset = "0x1BB0FFC", VA = "0x1BB0FFC")] get
      {
        return (SpriteAtlas) null;
      }
    }

    [Token(Token = "0x17002CE2")]
    public IReadOnlyList<SubSkillEffectIconParam> SubSkillIconParams
    {
      [Token(Token = "0x600CCB4"), Address(RVA = "0x1BB1658", Offset = "0x1BB1658", VA = "0x1BB1658")] get
      {
        return (IReadOnlyList<SubSkillEffectIconParam>) null;
      }
    }

    [Token(Token = "0x17002CE3")]
    public SpriteAtlas SubSkillIconAtlas
    {
      [Token(Token = "0x600CCB5"), Address(RVA = "0x1BB1314", Offset = "0x1BB1314", VA = "0x1BB1314")] get
      {
        return (SpriteAtlas) null;
      }
    }

    [Token(Token = "0x600CCB6")]
    [Address(RVA = "0x1BB0D68", Offset = "0x1BB0D68", VA = "0x1BB0D68")]
    public HashSet<string> GetAssetBundleLabels() => (HashSet<string>) null;

    [Token(Token = "0x600CCB7")]
    [Address(RVA = "0x1BB104C", Offset = "0x1BB104C", VA = "0x1BB104C")]
    public SubSkillEffectIconParam GetSubSkillIconParam(int masterId)
    {
      return (SubSkillEffectIconParam) null;
    }

    [Token(Token = "0x600CCB8")]
    [Address(RVA = "0x1BB1680", Offset = "0x1BB1680", VA = "0x1BB1680")]
    public StatusIconConfig()
    {
    }
  }
}
