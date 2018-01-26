using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsUnlimited
{
    public partial class ValidationTextBox : TextBox
    {
        private int maxSize;
        private int minSize;
        private bool required;
        private bool lettersOnly;
        private bool numbersOnly;
        //private string regEx;

        public ValidationTextBox()
        {
            InitializeComponent();
        }

        [Category("Validation")]
        public int MaxSize
        {
            get { return maxSize; }
            set { maxSize = value; }
        }
        [Category("Validation")]
        public int MinSize
        {
            get { return minSize; }
            set { minSize = value; }
        }
        [Category("Validation")]
        public bool Required
        {
            get { return required; }
            set { required = value; }
        }
        [Category("Validation")]
        public bool LettersOnly
        {
            get { return lettersOnly; }
            set { lettersOnly = value; }
        }
        [Category("Validation")]
        public bool NumbersOnly
        {
            get { return numbersOnly; }
            set { numbersOnly = value; }
        }

        public override string ToString()
        {
            string text = base.ToString();

            //size check
            if(text.Length > maxSize)
            {
                throw new ValidationException();
            }
            if(text.Length < minSize)
            {
                throw new ValidationException();
            }
            //required check
            if(required && text == "")
            {
                throw new ValidationException();
            }
            //letters check
            if(lettersOnly)
            {    

            }
            //number check
            if(numbersOnly)
            {

            }

            return text; 
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
