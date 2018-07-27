using System;
using System.Collections.Generic;
using System.Linq;
using CharacterBase.Enums;

namespace CharacterBase.Supports
{
    /// <summary>
    /// Набор кубиков для одного броска.
    /// </summary>
    public class DiceSet
    {
        #region Properties
        /// <summary>
        /// Набор кубиков.
        /// </summary>
        private Dictionary<Dice, int> Dices { get; set; }

        /// <summary>
        /// Набор модификаторов.
        /// </summary>
        private Dictionary<string, int> Modificator { get; set; }

        /// <summary>
        /// ГПСЧ.
        /// </summary>
        private Random Roller { get; }

        #endregion

        public DiceSet()
        {
            this.Dices = new Dictionary<Dice, int>();
            this.Modificator = new Dictionary<string, int>();
            this.Roller = new Random();
        }

        public void AddDice(Dice dice, int amount)
        {
            if (this.Dices.ContainsKey(dice))
                this.Dices[dice] += amount;
            else
                this.Dices[dice] = amount;
        }

        public void AddDices(Dictionary<Dice, int> dices)
        {
            foreach (KeyValuePair<Dice, int> pair in dices)
                this.AddDice(pair.Key, pair.Value);
        }

        public bool AddModificator(string modName, int modValue)
        {
            if (this.Modificator.ContainsKey(modName))
                return false;
            this.Modificator[modName] = modValue;
            return true;
        }

        public bool SetModificator(string modName, int modValue)
        {
            if (!this.Modificator.ContainsKey(modName))
                return false;
            this.Modificator[modName] = modValue;
            return true;
        }

        public bool AddModificators(Dictionary<string, int> modificators)
        {
            return modificators.Aggregate(true, (current, pair) => current & this.AddModificator(pair.Key, pair.Value));
        }

        public bool AddDiceSet(DiceSet diceSet)
        {
            this.AddDices(diceSet.Dices);
            return this.AddModificators(diceSet.Modificator);
        }

        public int Roll(bool critical=false)
        {
            int result = 0;
            foreach (KeyValuePair<Dice, int> dice in this.Dices)
                for (int i = 0; i < (critical?2*dice.Value:dice.Value); ++i)
                    result += (this.Roller.Next((int)dice.Key) + 1);
            return result + this.Modificator.Select(m => m.Value).Sum();
        }
    }
}