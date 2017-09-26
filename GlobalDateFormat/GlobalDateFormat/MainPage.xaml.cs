using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading.Tasks;
using Reactive.Bindings;
using Xamarin.Forms;

namespace GlobalDateFormat
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ResetBinding()
        {
            //var value = lblView.GetValue(Label.TextProperty);

            //var viewModel = BindingContext as MainPageViewModel;
            //viewModel.OutputDate.ForceNotify();
            //lblView.SetBinding(Label.TextProperty, new Binding("OutputDate.Value", BindingMode.Default, null, null, "{0:d}"));
        }

        private void btnJapanese_Clicked(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnEnglish_Clicked(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnGerman_Clicked(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnFrench_Clicked(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnItalian_Clicked(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnSpanish_Clicked(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnDutch_Clicked(object sender, EventArgs e)
        {
            ResetBinding();
        }

        private void btnDialog_Clicked(object sender, EventArgs e)
        {
            //ダイアログはスレッドカルチャではなく、端末のカルチャにやはり依存するようだ
            DependencyService.Get<IRequestBluetooth>().Request();
        }
    }

    public class MainPageViewModel
    {
        public ReactiveProperty<DateTime> OutputDate { get; set; }
        public ReactiveProperty<string> OutputString { get; set; }

        public ReactiveCommand CommandJapanese { get; set; }
        public ReactiveCommand CommandEnglish { get; set; }
        public ReactiveCommand CommandGerman { get; set; }
        public ReactiveCommand CommandFrench { get; set; }
        public ReactiveCommand CommandItalian { get; set; }
        public ReactiveCommand CommandSpanish { get; set; }
        public ReactiveCommand CommandDutch { get; set; }

        private void SetCulture(CultureInfo culture)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                DependencyService.Get<ICultureController>().ChangeCulture(culture);
            });
            OutputDate.ForceNotify();
        }

        public MainPageViewModel()
        {
            OutputDate = new ReactiveProperty<DateTime>(DateTime.Now);
            OutputString = new ReactiveProperty<string>(DateTime.Now.ToString());

            CommandJapanese = new ReactiveCommand();
            CommandJapanese.Subscribe(_ =>
            {
                Task.Run(() =>
                {
                    SetCulture(new CultureInfo("ja-JP"));
                });
            });

            CommandEnglish = new ReactiveCommand();
            CommandEnglish.Subscribe(_ =>
            {
                Task.Run(() =>
                {
                    SetCulture(new CultureInfo("en-US"));
                });
            });

            CommandGerman = new ReactiveCommand();
            CommandGerman.Subscribe(_ =>
            {
                Task.Run(() =>
                {
                    SetCulture(new CultureInfo("de-DE"));
                });
            });

            CommandFrench = new ReactiveCommand();
            CommandFrench.Subscribe(_ =>
            {
                Task.Run(() =>
                {
                    SetCulture(new CultureInfo("fr-FR"));
                });
            });

            CommandItalian = new ReactiveCommand();
            CommandItalian.Subscribe(_ =>
            {
                Task.Run(() =>
                {
                    SetCulture(new CultureInfo("it-IT"));
                });
            });

            CommandSpanish = new ReactiveCommand();
            CommandSpanish.Subscribe(_ =>
            {
                Task.Run(() =>
                {
                    SetCulture(new CultureInfo("es-ES"));
                });
            });

            CommandDutch = new ReactiveCommand();
            CommandDutch.Subscribe(_ =>
            {
                Task.Run(() =>
                {
                    SetCulture(new CultureInfo("nl-NL"));
                });
            });
        }
    }
}
