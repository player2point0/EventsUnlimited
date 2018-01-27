﻿using System;
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
        private string field;
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
        [Category("Validation")]
        public string Field
        {
            get { return field; }
            set { field = value; }
        }

        public override string ToString()
        {
            string text = base.Text;

            //required check
            if (required && text == "")
            {
                throw new ValidationException("Required field", field);
            }
            //size check
            if (text.Length > maxSize)
            {
                throw new ValidationException("Must be less than " + maxSize + " characters", text);
            }
            if(text.Length < minSize)
            {
                throw new ValidationException("Must be more than "+minSize+ " characters", text);
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
