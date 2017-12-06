﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SQLiteSample
{
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var db = MainPage.getDatabase();
            String sName = eName.Text;
            String sNotes = eNotes.Text;
            //Boolean bDone = eDone.IsToggled;
            int iCount = int.Parse(eCount.Text);
            DateTime dCreated = eCreated.Date;

            TodoItem item = new TodoItem() { Name = sName, Notes = sNotes, Count=iCount };
            db.SaveItemAsync(item);
            DisplayAlert("TodoItem","追加されたよ","OK");
        }
    }
}
