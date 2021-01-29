namespace Assignment_Three.UI
{
    using System.Windows.Forms;

    public partial class Splash : Form
    {
        public Splash()
        {
            this.InitializeComponent();
        }

        /// <summary>
        ///     Increments Progress Bar by one as long as the startup value is false.
        /// </summary>
        public void UpdateProgress()
        {
            if (Core.startup)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(
                        new MethodInvoker(delegate { this.pbLoading.Value += 1; }
                        )
                    );
                }
            }
            else
            {
                this.CloseForm();
            }
        }

        /// <summary>
        ///     Sets a value for the label above the progress bar.
        /// </summary>
        /// <param name="label"></param>
        public void SetProgressLabel(string label)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(delegate { this.labelProgress.Text = label; }
                    )
                );
            }
            else
            {
                this.labelProgress.Text = label;
            }
        }

        /// <summary>
        ///     Increments maximum value that the progress bar can reach.
        /// </summary>
        public void IncrementLoadingProgressMax()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(delegate { this.pbLoading.Maximum++; }
                    )
                );
            }
            else
            {
                this.pbLoading.Maximum++;
            }
        }

        /// <summary>
        ///     Sets the maximum value that the progress bar can result in.
        /// </summary>
        /// <param name="value"></param>
        public void SetLoadingProgressMax(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(delegate { this.pbLoading.Maximum = value; }
                    )
                );
            }
            else
            {
                this.pbLoading.Maximum = value;
            }
        }

        // Due to cross thread, must dispose of form within this procedure.
        /// <summary>
        ///     Disposes the Form once startup has been reached.
        /// </summary>
        public void CloseForm()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(this.Dispose)
                );
            }
        }
    }
}