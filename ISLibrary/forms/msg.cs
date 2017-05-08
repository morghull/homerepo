using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ISLibrary
{
    public partial class msg : Form
    {
        public msg()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Displays a message box with specified text, buttons, image.
        /// </summary>
        /// <param name="message">The text to display in the message box.</param>
        /// <param name="buttons">One of the ISLibrary.msg.DialogButtons values that specifies which
        ///     buttons to display in the message box.</param>
        /// <param name="image">One of the ISLibrary.msg.DialogImage values that specifies which
        ///     image to display in the message box.</param>
        /// <returns></returns>
        public static DialogResult Show(string message, DialogButtons buttons, DialogImage image)
        {
            mgsForm = new msg();
            mgsForm.Text = Application.ProductName;
            mgsForm.lblMessage.Text = message;
            mgsForm.pictureBox.Image = dicDialogImages[image];
            ButtonsInit(buttons);
            return mgsForm.ShowDialog();
        }
        /// <summary>
        /// Displays a message box with specified text, caption, buttons, image.
        /// </summary>
        /// <param name="message">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the ISLibrary.msg.DialogButtons values that specifies which
        ///     buttons to display in the message box.</param>
        /// <param name="image">One of the ISLibrary.msg.DialogImage values that specifies which
        ///     image to display in the message box.</param>
        /// <returns></returns>
        public static DialogResult Show(string message, string caption, DialogButtons buttons, DialogImage image)
        {
            mgsForm = new msg();
            mgsForm.Text = caption;
            mgsForm.lblMessage.Text = message;
            mgsForm.pictureBox.Image = dicDialogImages[image];
            ButtonsInit(buttons);
            return mgsForm.ShowDialog();
        }
        /// <summary>
        /// <para>Assosiates ISLibrary.msg.DialogButtons value with List&lt;Button&gt; in Dictionary ISLibrary.msg.dicDialogButtons.</para>
        /// <para>And for each Button in List&lt;Button&gt; attaches click event handlers to return specific DialogResult for this form.</para>
        /// </summary>
        /// <param name="buttons">One of the ISLibrary.msg.DialogButtons values that specifies which
        ///     buttons to display in the message box.</param>
        private static void ButtonsInit(DialogButtons buttons) 
        {
            foreach (Button btn in dicDialogButtons[buttons])
            {
                switch (btn.Name)
                {
                    case "btnOk": btn.Click += (s, e) => { mgsForm.DialogResult = System.Windows.Forms.DialogResult.OK; }; break;
                    case "btnCancel": btn.Click += (s, e) => { mgsForm.DialogResult = System.Windows.Forms.DialogResult.Cancel; }; break;
                    case "btnYes": btn.Click += (s, e) => { mgsForm.DialogResult = System.Windows.Forms.DialogResult.Yes; }; break;
                    case "btnNo": btn.Click += (s, e) => { mgsForm.DialogResult = System.Windows.Forms.DialogResult.No; }; break;
                }
                mgsForm.Controls.Add(btn);
            }
        }
        private static msg mgsForm;
        public enum DialogButtons
        {
            Ok,
            OkCancel,
            YesNo
        }
        public enum DialogImage
        {
            Error,
            Exclamation,
            Question,
            Info
        }
        #region Dictionaries initialization to assosiate them with proper enumeration
        private static Dictionary<DialogImage, Image> dicDialogImages = new Dictionary<DialogImage, Image>() 
        {         
            {DialogImage.Error,ISResources._48px_png_error},
            {DialogImage.Exclamation,ISResources._48px_png_excl},
            {DialogImage.Question,ISResources._48px_png_quest},
            {DialogImage.Info,ISResources._48px_png_info}
        };
        private static Dictionary<DialogButtons, List<Button>> dicDialogButtons = new Dictionary<DialogButtons, List<Button>>() 
        {         
            {
                DialogButtons.Ok,
                new List<Button>()
                {
                    new Button() 
                    {
                        Name = "btnOk",
                        Anchor = AnchorStyles.Bottom,
                        Size = new Size(75, 28),
                        Location = new Point(150, 114),
                        Text = "Ok",
                        Font = new Font("Arial", 11F)
                    }
                }
            },
            {
                DialogButtons.OkCancel,
                new List<Button>()
                {
                    new Button() 
                    {
                        Name = "btnOk",
                        Anchor = AnchorStyles.Bottom,
                        Size = new Size(75, 28),
                        Location = new Point(89, 114),
                        Text = "Ok",
                        Font = new Font("Arial", 11F)
                    },
                    new Button() 
                    {
                        Name = "btnCancel",
                        Anchor = AnchorStyles.Bottom,
                        Size = new Size(75, 28),
                        Location = new Point(194, 114),
                        Text = "Отмена",
                        Font = new Font("Arial", 11F)
                    }
                }
            },
            {
                DialogButtons.YesNo,new List<Button>()
                {
                    new Button() 
                    {
                        Name = "btnYes",
                        Anchor = AnchorStyles.Bottom,
                        Size = new Size(75, 28),
                        Location = new Point(95, 114),
                        Text = "Да",
                        Font = new Font("Arial", 11F)
                    },
                    new Button() 
                    {
                        Name = "btnNo",
                        Anchor = AnchorStyles.Bottom,
                        Size = new Size(75, 28),
                        Location = new Point(200, 114),
                        Text = "Нет",
                        Font = new Font("Arial", 11F)
                    }
                }
            }
        }; 
        #endregion
    }
}
