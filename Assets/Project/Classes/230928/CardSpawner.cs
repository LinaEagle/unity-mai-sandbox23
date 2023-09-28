using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Project.Classes._230928
{
    public enum CardType
    {
        Land,
        Unit,
        Spell,
    }

    [CreateAssetMenu(fileName = "MyCardDescription", menuName = "ScriptableObjects/MyCardDescription", order = 1)]
    public class MyCardDescription : ScriptableObject
    {
        public CardType type = CardType.Spell;
        public string Name;
        public Sprite image; 
    }

    [CreateAssetMenu(fileName = "MyCardDescriptions", menuName = "ScriptableObjects/MyCardDescriptions", order = 1)]
    public class MyCardDescriptions : ScriptableObject
    {
        public MyCardDescription[] descriptions;
    }

    public class CardSpawner
    {
        public Dictionary<CardType, int> cardCovers = new Dictionary<CardType, int>() {
            [CardType.Land] = 0,
            [CardType.Unit] = 1235,
            [CardType.Spell] = 45
        };

        public void Create(MyCardDescription[] cardDescriptions)
        {
            var data = new MyPseudoStruct();
            var cards = cardDescriptions
                .Where(x => x.type == CardType.Land)
                .ToArray();

            //var cards = new Card[cardDescriptions.Length];
            //for (var index = 0; index < cards.Length; index++)
            //{
            //    cards[index] = new Card(cardDescriptions[index], Vector3.zero, value);
            //}
        }
    }

    public class Card
    {
        public MyRealStruct other = new MyRealStruct();
        public readonly MyCardDescription _description;
        public int ID;
        public int Strength { get; private set; }

        public Card(MyCardDescription description, Vector3 position)
        {
            position.y = 0;
            other.position = position;

            _description = description;
            switch (description.type)
            {
                case CardType.Land:
                    break;
                case CardType.Unit:
                case CardType.Spell:
                    // todo do stuff
                    break;
                default:
                    break;
            }
        }
    }
}