using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ejer6_AndroidRelations
{
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {
        private Button _button1;
        private Button _button2;
        private Button _button3;
        private Button _button4;
        private Button _button5;
        private Button _button6;
        private Button _button7;
        private Button _button8;
        private Button _button9;
        private EditText _editText;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            AddBindForLayout();
            // Create your application here
        }

        private void AddBindForLayout()
        {
            _button1 = FindViewById<Button>(Resource.Id.button1);
            _button2 = FindViewById<Button>(Resource.Id.button2);
            _button3 = FindViewById<Button>(Resource.Id.button3);
            _button4 = FindViewById<Button>(Resource.Id.button4);
            _button5 = FindViewById<Button>(Resource.Id.button5);
            _button6 = FindViewById<Button>(Resource.Id.button6);
            _button7 = FindViewById<Button>(Resource.Id.button7);
            _button8 = FindViewById<Button>(Resource.Id.button8);
            _button9 = FindViewById<Button>(Resource.Id.button9);
            _editText = FindViewById<EditText>(Resource.Id.editText1);

            _button1.Click += aniadeNum;
            _button2.Click += aniadeNum;
            _button3.Click += aniadeNum;
            _button4.Click += aniadeNum;
            _button5.Click += aniadeNum;
            _button6.Click += aniadeNum;
            _button7.Click += aniadeNum;
            _button8.Click += aniadeNum;
            _button9.Click += aniadeNum;
        }

        private void aniadeNum(object sender, EventArgs e) {
            Button botin = (Button)sender;
            _editText.Text = _editText.Text+botin.Text;
        }
    }
}