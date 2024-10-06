// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.QuestNodeSpace
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A28")]
  public class QuestNodeSpace : QuestNodeBase
  {
    [Token(Token = "0x400B358")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform unitRoot;
    [Token(Token = "0x400B359")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform lineRoot;
    [Token(Token = "0x400B35A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform cursolRoot;
    [Token(Token = "0x400B35B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform lockEffectRoot;
    [Token(Token = "0x400B35C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform[] noClearObjectTable;
    [Token(Token = "0x400B35D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Transform[] clearObjectTable;
    [Token(Token = "0x400B35E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform[] accessoryRootTable;
    [Token(Token = "0x400B35F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject lockMark;
    [Token(Token = "0x400B360")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private QuestNodeText nodeNameText;
    [Token(Token = "0x400B362")]
    [FieldOffset(Offset = "0x68")]
    private List<QuestNodeConnectingLine> lines;

    [Token(Token = "0x1700395D")]
    public QuestNodeSpace.Parameter NodeParameter
    {
      [Token(Token = "0x6010813"), Address(RVA = "0x4C22EAC", Offset = "0x4C22EAC", VA = "0x4C22EAC")] private set
      {
      }
      [Token(Token = "0x6010814"), Address(RVA = "0x4C22EB4", Offset = "0x4C22EB4", VA = "0x4C22EB4")] get
      {
        return (QuestNodeSpace.Parameter) null;
      }
    }

    [Token(Token = "0x6010815")]
    [Address(RVA = "0x4C22EBC", Offset = "0x4C22EBC", VA = "0x4C22EBC")]
    public void Setup(QuestNodeSpace.Parameter parameter)
    {
    }

    [Token(Token = "0x6010816")]
    [Address(RVA = "0x4C22F80", Offset = "0x4C22F80", VA = "0x4C22F80")]
    public void SetState(NodeStateType nodeStateType)
    {
    }

    [Token(Token = "0x6010817")]
    [Address(RVA = "0x4C23088", Offset = "0x4C23088", VA = "0x4C23088")]
    public void AddLine(QuestNodeConnectingLine line)
    {
    }

    [Token(Token = "0x6010818")]
    [Address(RVA = "0x4C231B4", Offset = "0x4C231B4", VA = "0x4C231B4")]
    public void AddAccessory(QuestNodeAccessory accessory)
    {
    }

    [Token(Token = "0x6010819")]
    [Address(RVA = "0x4C225B0", Offset = "0x4C225B0", VA = "0x4C225B0")]
    public void SetSelect(QuestNodeUnit unit, QuestNodeSelectedMark mark)
    {
    }

    [Token(Token = "0x601081A")]
    [Address(RVA = "0x4C23370", Offset = "0x4C23370", VA = "0x4C23370")]
    public void SetUnit(QuestNodeUnit unit)
    {
    }

    [Token(Token = "0x601081B")]
    [Address(RVA = "0x4C23458", Offset = "0x4C23458", VA = "0x4C23458")]
    public bool CheckCollision(Vector3 worldPosition) => new bool();

    [Token(Token = "0x601081C")]
    [Address(RVA = "0x4C20EF0", Offset = "0x4C20EF0", VA = "0x4C20EF0")]
    public QuestNodeConnectingLine GetConnectLine(QuestNodeSpace target)
    {
      return (QuestNodeConnectingLine) null;
    }

    [Token(Token = "0x601081D")]
    [Address(RVA = "0x4C21020", Offset = "0x4C21020", VA = "0x4C21020")]
    public void SetUnleashEffect(GameObject target)
    {
    }

    [Token(Token = "0x601081E")]
    [Address(RVA = "0x4C22A44", Offset = "0x4C22A44", VA = "0x4C22A44")]
    public bool IsCanPlay() => new bool();

    [Token(Token = "0x601081F")]
    [Address(RVA = "0x4C2350C", Offset = "0x4C2350C", VA = "0x4C2350C")]
    public QuestNodeSpace()
    {
    }

    [Token(Token = "0x2002A29")]
    public class Parameter
    {
      [Token(Token = "0x1700395E")]
      public int Id
      {
        [Token(Token = "0x6010820"), Address(RVA = "0x4C23588", Offset = "0x4C23588", VA = "0x4C23588")] private set
        {
        }
        [Token(Token = "0x6010821"), Address(RVA = "0x4C23590", Offset = "0x4C23590", VA = "0x4C23590")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x1700395F")]
      public string Name
      {
        [Token(Token = "0x6010822"), Address(RVA = "0x4C23598", Offset = "0x4C23598", VA = "0x4C23598")] private set
        {
        }
        [Token(Token = "0x6010823"), Address(RVA = "0x4C235A0", Offset = "0x4C235A0", VA = "0x4C235A0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17003960")]
      public int NodeResourceId
      {
        [Token(Token = "0x6010824"), Address(RVA = "0x4C235A8", Offset = "0x4C235A8", VA = "0x4C235A8")] private set
        {
        }
        [Token(Token = "0x6010825"), Address(RVA = "0x4C235B0", Offset = "0x4C235B0", VA = "0x4C235B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17003961")]
      public NodeStateType StateType
      {
        [Token(Token = "0x6010826"), Address(RVA = "0x4C235B8", Offset = "0x4C235B8", VA = "0x4C235B8")] private set
        {
        }
        [Token(Token = "0x6010827"), Address(RVA = "0x4C235C0", Offset = "0x4C235C0", VA = "0x4C235C0")] get
        {
          return new NodeStateType();
        }
      }

      [Token(Token = "0x17003962")]
      public Vector3 Position
      {
        [Token(Token = "0x6010828"), Address(RVA = "0x4C235C8", Offset = "0x4C235C8", VA = "0x4C235C8")] private set
        {
        }
        [Token(Token = "0x6010829"), Address(RVA = "0x4C235D4", Offset = "0x4C235D4", VA = "0x4C235D4")] get
        {
          return new Vector3();
        }
      }

      [Token(Token = "0x17003963")]
      public int AccessoryId
      {
        [Token(Token = "0x601082A"), Address(RVA = "0x4C235E0", Offset = "0x4C235E0", VA = "0x4C235E0")] private set
        {
        }
        [Token(Token = "0x601082B"), Address(RVA = "0x4C235E8", Offset = "0x4C235E8", VA = "0x4C235E8")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17003964")]
      public int UnitStyleId
      {
        [Token(Token = "0x601082C"), Address(RVA = "0x4C235F0", Offset = "0x4C235F0", VA = "0x4C235F0")] private set
        {
        }
        [Token(Token = "0x601082D"), Address(RVA = "0x4C235F8", Offset = "0x4C235F8", VA = "0x4C235F8")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17003965")]
      public List<int> NextNodeList
      {
        [Token(Token = "0x601082E"), Address(RVA = "0x4C23600", Offset = "0x4C23600", VA = "0x4C23600")] private set
        {
        }
        [Token(Token = "0x601082F"), Address(RVA = "0x4C23608", Offset = "0x4C23608", VA = "0x4C23608")] get
        {
          return (List<int>) null;
        }
      }

      [Token(Token = "0x6010830")]
      [Address(RVA = "0x4C23610", Offset = "0x4C23610", VA = "0x4C23610")]
      public Parameter(
        int id,
        string name,
        int nodeResourceId,
        int accessoryId,
        int unitStyleId,
        NodeStateType stateType,
        Vector2 position,
        int[] next)
      {
      }

      [Token(Token = "0x6010831")]
      [Address(RVA = "0x4C23080", Offset = "0x4C23080", VA = "0x4C23080")]
      public void SetStatus(NodeStateType stateType)
      {
      }
    }
  }
}
