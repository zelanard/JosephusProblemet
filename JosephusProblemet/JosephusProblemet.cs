

namespace JosephusProblemet
{
    public partial class JosephusProblemet : Form
    {
        /// <summary>
        /// The number of prisoners
        /// </summary>
        private int PrisonersN { get; set; }

        /// <summary>
        /// Kill prisoners on the interval
        /// </summary>
        private int IntervalK { get; set; }

        public JosephusProblemet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set PrisonerN when the textbox is changed. Validate to 0 if NaN, Null or Empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxPrisonersN_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPrisonersN.Text))
            {
                try
                {
                    PrisonersN = Convert.ToInt32(textBoxPrisonersN.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    PrisonersN = 0;
                }
            }
            else { PrisonersN = 0; }
            EnableKillPrisoner();
        }

        /// <summary>
        /// Set IntervalK when the textbox is changed. Validate to 0 if NaN, Null or Empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextboxIntervalK_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxIntervalK.Text))
            {
                try
                {
                    IntervalK = Convert.ToInt32(textBoxIntervalK.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    IntervalK = 0;
                }
            }
            else { IntervalK = 0; }
            EnableKillPrisoner();
        }
        /// <summary>
        /// Enable the kill prisoners button if the conditions are met.
        /// </summary>
        private void EnableKillPrisoner()
        {
            if (PrisonersN > 0 && IntervalK > 0)
            {
                buttonKillPrisoners.Enabled = true;
            }
        }

        /// <summary>
        /// Start killing off the prisoners
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ButtonKillPrisoners_Click(object sender, EventArgs e)
        {
            int count = 0;
            int kill = 0;
            List<Prisoner> prisoners = new List<Prisoner>();

            // Populate the Prisoners List.
            for (int i = 0; i < PrisonersN; i++)
            {
                prisoners.Add(new Prisoner(i));
            }
            try
            {

                //Start murdering the prisoners!
                while (true)
                {
                    count++;

                    //Dead prisoners doesn't count. 
                    if (prisoners[count].Alive)
                    {
                        kill++;
                    }

                    //when kill reach IntervalK, someone dies.
                    if (kill == IntervalK)
                    {
                        prisoners[count].Kill();
                        kill = 0;
                    }

                    //end the loop if there's only one prisoner left.
                    if (IsLastManstanding(prisoners)) { break; }

                    //restart the count when we've reached the end of the list.
                    if (count >= prisoners.Count - 1)
                    {
                        count = -1;
                    }
                }

                //pop up and tell the user which prisoner survived
                MessageBox.Show(this, GetReuslt(prisoners));
            }
            catch
            {
                //inform the user that everyone is dead.
                MessageBox.Show(this, "An error have occured.. it seems everyone is dead!");
            }
        }

        /// <summary>
        /// Who Survived?
        /// </summary>
        /// <param name="prisoners"></param>
        /// <returns>A string informing of which prisoner survived</returns>
        private static string GetReuslt(List<Prisoner> prisoners)
        {
            //Find the prisoner who isn't dead.
            foreach (Prisoner pr in prisoners)
            {
                if (pr.Alive)
                {
                    return $"Prisoner number: {pr.ID} survived!";
                }
            }
            //Everyone is not supposed to be dead.
            throw new EveryoneIsDeadException();
        }
        /// <summary>
        /// Check if there's only one person left alive.
        /// </summary>
        /// <param name="prisoners"></param>
        /// <returns>true/false</returns>
        private static bool IsLastManstanding(List<Prisoner> prisoners)
        {
            int Alive = 0;
            //loop through the prisoners and find out if they're alive.
            foreach (Prisoner prisoner in prisoners)
            {
                if (prisoner.Alive)
                {
                    Alive++;
                    //if more than one prisoner is alive, reutrn false
                    if (Alive > 1)
                    {
                        return false;
                    }
                }
            }
            if (Alive == 1)
            {
                //if only one prisoner is alive, reutrn true.
                return true;
            }
            else
            {
                //Everyone is not supposed to be dead!
                throw new EveryoneIsDeadException();
            }
        }
    }
    /// <summary>
    /// A prisoner
    /// </summary>
    public class Prisoner
    {
        /// <summary>
        /// The prisoners ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Is the prisoner alive?
        /// </summary>
        public bool Alive { get; set; } = true;

        public Prisoner(int _ID)
        {
            this.ID = _ID;
            Alive = true;
        }
        /// <summary>
        /// Kill the prisoner!
        /// </summary>
        public void Kill()
        {
            this.Alive = false;
        }
    }

    /// <summary>
    /// Throw this exception when everyone is dead.
    /// </summary>
    public class EveryoneIsDeadException : Exception
    {
        public EveryoneIsDeadException() : base("Everyone is dead!") { }
    }
}