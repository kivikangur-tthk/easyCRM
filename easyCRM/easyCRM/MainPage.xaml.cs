using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace easyCRM
{
    public partial class MainPage : ContentPage
    {
        TableView tableView;
        EntryCell name, phone, date, amount;
        ImageCell img_order;
        TableSection fotosection, nuppud;
        Button sms_btn;
        Button call_btn;
        Button email_btn;
        StackLayout st;
        public MainPage()
        {
            call_btn = new Button { Text = "Helista" }; call_btn.Clicked += Call_btn_Clicked;
            sms_btn = new Button { Text = "Saada sms" }; sms_btn.Clicked += Sms_btn_Clicked;
            email_btn = new Button { Text = "Saada email" }; email_btn.Clicked += Email_btn_Clicked;
            phone = new EntryCell
            {
                Label= "Telefon:",
                Placeholder = "Sissesta number",
                Keyboard = Keyboard.Telephone
            };
            date = new EntryCell
            {
                Label = "Arve kuupäev:",
                Placeholder = "Sissesta kuupaev dd/mm/yyyy",
                Keyboard = Keyboard.Text
            };
            amount = new EntryCell
            {
                Label = "Kokku",
                Placeholder = "Kokku",
                Keyboard = Keyboard.Numeric
            };
            st = new
        }

        private void Email_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Sms_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Call_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
