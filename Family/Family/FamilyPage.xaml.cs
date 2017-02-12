using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace Family
{
    public partial class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            InitializeComponent();
            var layout = new StackLayout { Padding = new Thickness(20, 20, 20, 20) };

            //Greeting//
            var label = new Label() ;
            var greeting = new FormattedString();
            greeting.Spans.Add(new Span { Text = "Greetings from the Mauer Family!", FontAttributes = FontAttributes.Bold, FontSize = 32 });
            label.FormattedText = greeting;
            label.HorizontalTextAlignment = TextAlignment.Center;
            label.TextColor = Color.Blue;
            layout.Children.Add(label);


            //Grandparents//
            var labelGrandfather = new Label();
            var s = new FormattedString();
            s.Spans.Add(new Span { Text = "The dad's name is ", FontAttributes = FontAttributes.Bold, FontSize = 18 });
            s.Spans.Add(new Span { Text = "Clifford Mauer", FontAttributes = FontAttributes.Bold, FontSize = 24 });
            s.Spans.Add(new Span { Text = ".", FontAttributes = FontAttributes.Bold, FontSize = 18 });
            labelGrandfather.FormattedText = s;
            labelGrandfather.TextColor = Color.Red;
            layout.Children.Add(labelGrandfather);


            var labelGrandmother = new Label();
            var t = new FormattedString();
            t.Spans.Add(new Span { Text = "The mom's name is ", FontAttributes = FontAttributes.Bold, FontSize = 18 });
            t.Spans.Add(new Span { Text = "Sally Mauer", FontAttributes = FontAttributes.Bold, FontSize = 24 });
            t.Spans.Add(new Span { Text = ".", FontAttributes = FontAttributes.Bold, FontSize = 18 });
            labelGrandmother.FormattedText = t;
            labelGrandmother.TextColor = Color.Red;
            layout.Children.Add(labelGrandmother);


            //Children//
            var labelChildren = new Label();
            var ChildrenIntro = new FormattedString();
            ChildrenIntro.Spans.Add(new Span { Text = "We have two daughters.", FontAttributes = FontAttributes.Bold, FontSize = 18 });
            labelChildren.FormattedText = ChildrenIntro;
            labelChildren.HorizontalTextAlignment = TextAlignment.Center;
            labelChildren.TextColor = Color.Red;
            layout.Children.Add(labelChildren);

            //Carrie//
            var labelCarrie= new Label();
            var x = new FormattedString();
            x.Spans.Add(new Span { Text = "My oldest daughter is ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            x.Spans.Add(new Span { Text = "Carrie ", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            x.Spans.Add(new Span { Text = ". "+Environment.NewLine+"She is married to ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            x.Spans.Add(new Span { Text = "Steve Kioski", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            x.Spans.Add(new Span { Text = ".", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            labelCarrie.FormattedText = x;
            labelCarrie.TextColor = Color.Green;
            layout.Children.Add(labelCarrie);

            //Sarah//
            var labelSarah = new Label();
            var y = new FormattedString();
            y.Spans.Add(new Span { Text = "My youngest daughter is ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            y.Spans.Add(new Span { Text = "Sarah ", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            y.Spans.Add(new Span { Text = "."+Environment.NewLine+"She is married to ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            y.Spans.Add(new Span { Text = "Nicholas Rohlstad", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            y.Spans.Add(new Span { Text = ".", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            labelSarah.FormattedText = y;
            labelSarah.TextColor = Color.Green;
            layout.Children.Add(labelSarah);

            //Grandchildren//
            var labelGrandChildren = new Label();
            var GrandChildrenIntro = new FormattedString();
            GrandChildrenIntro.Spans.Add(new Span { Text = "We have three grandchildren.", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            labelGrandChildren.FormattedText = GrandChildrenIntro;
            labelGrandChildren.HorizontalTextAlignment = TextAlignment.Center;
            labelGrandChildren.TextColor = Color.Purple;
            layout.Children.Add(labelGrandChildren);

            //Gavin//
            var labelGavin = new Label();
            var a = new FormattedString();
            a.Spans.Add(new Span { Text = "My oldest grandchild is ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            a.Spans.Add(new Span { Text = "Gavin ", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            a.Spans.Add(new Span { Text = "."+Environment.NewLine+"His mom and dad are ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            a.Spans.Add(new Span { Text = "Sarah ", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            a.Spans.Add(new Span { Text = "and ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            a.Spans.Add(new Span { Text = "Nicholas", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            a.Spans.Add(new Span { Text = ".", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            labelGavin.FormattedText = a;
            labelGavin.TextColor = Color.Purple;
            layout.Children.Add(labelGavin);

            //Gavin//
            var labelMorgan = new Label();
            var b = new FormattedString();
            b.Spans.Add(new Span { Text = "The next oldest grandchild is ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            b.Spans.Add(new Span { Text = "Morgan ", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            b.Spans.Add(new Span { Text = "."+Environment.NewLine+"Her mom and dad are ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            b.Spans.Add(new Span { Text = "Sarah ", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            b.Spans.Add(new Span { Text = "and ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            b.Spans.Add(new Span { Text = "Nicholas", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            b.Spans.Add(new Span { Text = ".", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            labelMorgan.FormattedText = b;
            labelMorgan.TextColor = Color.Purple;
            layout.Children.Add(labelMorgan);

            //Bennett//
            var labelBennett = new Label();
            var c = new FormattedString();
            c.Spans.Add(new Span { Text = "The youngest grandchild is ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            c.Spans.Add(new Span { Text = "Bennet ", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            c.Spans.Add(new Span { Text = "."+Environment.NewLine+"His mom and dad are ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            c.Spans.Add(new Span { Text = "Carrie ", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            c.Spans.Add(new Span { Text = "and ", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            c.Spans.Add(new Span { Text = "Steve", FontAttributes = FontAttributes.Bold, FontSize = 22 });
            c.Spans.Add(new Span { Text = ".", FontAttributes = FontAttributes.Bold, FontSize = 16 });
            labelBennett.FormattedText = c;
            labelBennett.TextColor = Color.Purple;
            layout.Children.Add(labelBennett);

            Title = "Family";
            Content = new StackLayout
            {
               Spacing = 1,
               Padding = new Thickness(20, 20, 20, 20),
                Children =
                { label,
                  labelGrandfather,
                  labelGrandmother,
                  labelChildren,
                  labelCarrie,
                  labelSarah,
                  labelGrandChildren,
                  labelGavin,
                  labelMorgan,
                  labelBennett}
            };
        }
    }
}
