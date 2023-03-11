namespace EnqueteCSharp
{
    /// <summary>
    /// Votos de uma opção.
    /// </summary>
    class OptionScore : IComparable<OptionScore>
    {
        // Opção.
        public Option Option { get; private set; }

        // Número de votos.
        public int Count { get; private set; }

        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="option">Opção.</param>
        /// <param name="score">Número de votos</param>
        public OptionScore(Option option, int score)
        {
            this.Option = option;
            this.Count = score;
        }

        /// <summary>
        /// Define a comparação como ordem decrescente de votos. Se duas opções tiverem o mesmo número de votos,
        /// usa o críterio de ordem alfábetica do texto da opção.
        /// </summary>
        public int CompareTo(OptionScore other)
        {
            int comp = Count.CompareTo(other.Count);

            if (comp == 0)
            {
                return Option.Text.CompareTo(other.Option.Text);
            }

            return comp;
        }
    }
}