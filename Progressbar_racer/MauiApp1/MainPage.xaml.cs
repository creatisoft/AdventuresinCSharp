using System.Diagnostics;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    float _racer01;
    float _racer02;

    float _racerFinal01;
    float _racerFinal02;

    bool _isRaceRunning = true;


    public async void Racing()
    {
       // Random ran1 = new Random();
        //Random ran2 = new Random();
        //_racer01 = (float)ran1.NextDouble();
        //_racer02 = (float)ran2.NextDouble();

        //ProgressBar01.Progress = _racer01;
        //ProgressBar02.Progress = _racer02;
        

        while (_isRaceRunning == true)
        {

            Random ran1 = new Random();
            Random ran2 = new Random();
            _racer01 = (float)ran1.NextDouble();
            _racer02 = (float)ran2.NextDouble();


            if (_racer01 > 0.2f || _racer02 > 0.2f)
            {

                _racer01 = (float)ran1.NextDouble();
                _racer02 = (float)ran2.NextDouble();
            }
            else
            {

                _racerFinal01 = _racer01;
                _racerFinal02 = _racer02;

            }
            
            ProgressBar01.Progress += _racerFinal01;
            ProgressBar02.Progress += _racerFinal02;

            if(ProgressBar01.Progress == 1)
            {
                Label02.Text = "Progress Bar 1 is the Winner";
                _isRaceRunning = false;

            }else if(ProgressBar02.Progress == 1)
            {
                
                Label02.Text = "Progress Bar 2 is the Winner";
                _isRaceRunning = false;
            }
            await Task.Delay(60);

        }
        
    }


    public void OnStartClicked(Object? sender, EventArgs e)
    {
        Label02.Text = "WHO WILL WIN?";
        
        Racing();

        

    }
    public void OnStopClicked(Object? sender, EventArgs e)
    {
        ProgressBar01.Progress = 0;
        ProgressBar02.Progress = 0;
        _isRaceRunning = true;
        _racer01 = 0;
        _racer02 = 0;
        _racerFinal01 = 0;
        _racerFinal02 = 0;

    }

}