using Plugin.Messaging;
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
        EntryCell name, phone, date, amount, tex;
        ImageCell img_order;
        TableSection fotosection, nuppud;
        Button sms_btn;
        Button call_btn;
        Button sub;
        StackLayout st;
        public MainPage()
        {
            call_btn = new Button { Text = "Helista" }; call_btn.Clicked += Call_btn_Clicked;
            sms_btn = new Button { Text = "Saada sms" }; sms_btn.Clicked += Sms_btn_Clicked;
            sub = new Button { Text = "Lisa arve" }; sub.Clicked += Sub_Clicked;

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
            tex = new EntryCell
            {
                Label = "Sms tekst",
                Placeholder = "Kirjuta teks sms-le",
                Keyboard = Keyboard.Default
            };
            st = new StackLayout
            {
                Children = { call_btn, sms_btn, sub },
                Orientation = StackOrientation.Horizontal
            };
            nuppud = new TableSection
            {
                new ViewCell() { View=st},
            };
            img_order = new ImageCell
            {
                ImageSource = ImageSource.FromFile("Fox.jpg"),
                Text = "Foto nimetus",
                Detail = "Foto kirjeldus"
            };
            fotosection = new TableSection();

            tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Andmete sissestamine")
                {
                    new TableSection("Põhiandmed:")
                    {
                        new EntryCell
                        {
                            Label="Nimi:",
                            Placeholder="Sissesta oma sõbra nimi",
                            Keyboard=Keyboard.Default
                        }
                    },
                    new TableSection("Kontaktandmed:")
                    {
                        phone,
                        date,
                        amount,
                        tex
                    },
                    fotosection,
                    nuppud
                }

            };
            Content = tableView;


        }

        private void Sub_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Sms_btn_Clicked(object sender, EventArgs e)
        {
            var sms = CrossMessaging.Current.SmsMessenger;
            if (sms.CanSendSms)
            {
                sms.SendSms(phone.Text, tex.Text);
            }
        }

        private void Call_btn_Clicked(object sender, EventArgs e)
        {
            var call = CrossMessaging.Current.PhoneDialer;
            if (call.CanMakePhoneCall)
            {
                call.MakePhoneCall(phone.Text);
            }
        }
    }
}
